using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.TicketPrice;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement
{
    public class TicketPriceRepository : ITicketPriceRepository
    {
        private readonly NeonCinemasContext _context;

        public TicketPriceRepository(NeonCinemasContext context)
        {
            _context = context;
        }

        public async Task<TicketPriceDTO> GetTicketPriceByIdAsync(Guid id)
        {
            var ticketPrice = await _context.TicketPrice
                .Where(t => t.ID == id)
                .Include(t => t.Screening)
                .Include(t => t.Seats)
                .Include(t => t.ShowTimes)
                .FirstOrDefaultAsync();

            if (ticketPrice == null)
            {
                return null;
            }

            return new TicketPriceDTO
            {
                ID = ticketPrice.ID,
                Price = ticketPrice.Price,
				SeatID = ticketPrice.SeatID,
                ShowTimeID = ticketPrice.ShowTimeID,
                ScreeningID = ticketPrice.ScreeningID
            };
        }

        public async Task<List<TicketPriceDTO>> GetTicketPricesAsync()
        {
            var ticketPrices = await _context.TicketPrice
                .Include(t => t.Screening)
                .Include(t => t.Seats)
                .Include(t => t.ShowTimes)
                .ToListAsync();

            return ticketPrices.Select(ticketPrice => new TicketPriceDTO
            {
                ID = ticketPrice.ID,
                Price = ticketPrice.Price,
                SeatID = ticketPrice.SeatID,
                ShowTimeID = ticketPrice.ShowTimeID,
                ScreeningID = ticketPrice.ScreeningID
            }).ToList();
        }

        public async Task<HttpResponseMessage> SetupPrice(TicketPriceCreateRequest ticketPriceDTO)
        {
            // Validate the existence of the Screening, ShowTime, and SeatType
            var screening = await _context.Screening.FindAsync(ticketPriceDTO.ScreeningID);
            var showTime = await _context.ShowTimes.FindAsync(ticketPriceDTO.ShowTimeID);
            var seatType = await _context.SeatTypes.FindAsync(ticketPriceDTO.SeatTypeID);

            if (screening == null || showTime == null || seatType == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }

            DateTime screeningDate = screening.ShowDate;
            TimeSpan showStartTime = showTime.StartTime;
            decimal basePrice = CalculateBasePrice(screeningDate, showStartTime, seatType); 


            basePrice = decimal.Parse(basePrice.ToString("F3"));

            // Create the TicketPrice entity to insert or update
            var ticketPrice = new TicketPrice
            {
                ID = Guid.NewGuid(),
                Price = (ticketPriceDTO.Price == 0 || !ticketPriceDTO.Price.HasValue) ? basePrice : ticketPriceDTO.Price.Value,
                SeatID = ticketPriceDTO.SeatTypeID,
                ShowTimeID = ticketPriceDTO.ShowTimeID,
                ScreeningID = ticketPriceDTO.ScreeningID
            };

            // Check if the ticket price exists, update or add it
            var existingTicketPrice = await _context.TicketPrice
                .FirstOrDefaultAsync(tp => tp.ID == ticketPriceDTO.ID);

            //if (existingTicketPrice != null)
            //{
            //    existingTicketPrice.Price = ticketPriceDTO.Price; // Update the price
            //    _context.TicketPrice.Update(existingTicketPrice);
            //}
            //else
            //{
            //    _context.TicketPrice.Add(ticketPrice); // Insert new ticket price
            //}
            _context.TicketPrice.Add(ticketPrice);
            await _context.SaveChangesAsync();
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        public async Task<HttpResponseMessage> UpdateTicketPriceAsync(TicketPriceDTO ticketPriceDTO)
        {
            var existingTicketPrice = await _context.TicketPrice
                .FirstOrDefaultAsync(tp => tp.ID == ticketPriceDTO.ID);

            if (existingTicketPrice == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }

            existingTicketPrice.Price = ticketPriceDTO.Price;
            await _context.SaveChangesAsync();

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        private decimal CalculateBasePrice(DateTime screeningDate, TimeSpan showStartTime, SeatType seatType)
        {
            decimal basePrice = 0;

            // Calculate base price based on the day of the week and showtime
            if (screeningDate.DayOfWeek == DayOfWeek.Monday ||
                screeningDate.DayOfWeek == DayOfWeek.Tuesday ||
                screeningDate.DayOfWeek == DayOfWeek.Wednesday ||
                screeningDate.DayOfWeek == DayOfWeek.Thursday)
            {
                basePrice = showStartTime < new TimeSpan(17, 0, 0) ? 50m : 60m;
            }
            else if (screeningDate.DayOfWeek == DayOfWeek.Friday ||
                     screeningDate.DayOfWeek == DayOfWeek.Saturday ||
                     screeningDate.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice = showStartTime < new TimeSpan(17, 0, 0) ? 60m : 70m;
            }

            // Additional charges for seat types
            if (seatType.SeatTypeName == "Ghế Vip")
            {
                basePrice += 30m;
            }
            else if (seatType.SeatTypeName == "Ghế Đôi")
            {
                basePrice += 50m;
            }

            return basePrice;
        }
    }

}
