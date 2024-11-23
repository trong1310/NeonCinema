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

        public async Task<HttpResponseMessage> CreateTicketPrice(TicketPriceCreateRequest ticketPriceDTO)
        {
            var screening = await _context.Screening.FindAsync(ticketPriceDTO.ScreeningID);
            var showTime = await _context.ShowTimes.FindAsync(ticketPriceDTO.ShowTimeID);
            var seatType = await _context.SeatTypes.FindAsync(ticketPriceDTO.SeatTypeID);
            var ticketPriceSetting = await _context.TicketPriceSettings
                .FirstOrDefaultAsync(x => x.ID == Guid.Parse("4BAB0DA1-D912-4A87-8E21-CB7A665657D3")); // Assuming you have one global setting

            if (screening == null || showTime == null || seatType == null || ticketPriceSetting == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Screening, ShowTime, SeatType, or TicketPriceSetting not found.")
                };
            }

            decimal basePrice = 0;
            DateTime screeningDate = screening.ShowDate;
            TimeSpan showStartTime = showTime.StartTime;

            // Xác định giá cơ bản theo ngày trong tuần và giờ chiếu
            if (screeningDate.DayOfWeek == DayOfWeek.Monday ||
                screeningDate.DayOfWeek == DayOfWeek.Tuesday ||
                screeningDate.DayOfWeek == DayOfWeek.Wednesday ||
                screeningDate.DayOfWeek == DayOfWeek.Thursday)
            {
                basePrice = showStartTime < new TimeSpan(17, 0, 0)
                    ? ticketPriceSetting.PriceBefore17hWeekDay
                    : ticketPriceSetting.PriceAfter17hWeekDay;
            }
            else if (screeningDate.DayOfWeek == DayOfWeek.Friday ||
                     screeningDate.DayOfWeek == DayOfWeek.Saturday ||
                     screeningDate.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice = showStartTime < new TimeSpan(17, 0, 0)
                    ? ticketPriceSetting.PriceBefore17hWeekeend
                    : ticketPriceSetting.PriceAfter17hWeekeend;
            }

            // Thêm phụ phí cho loại ghế
            if (seatType.SeatTypeName == "Ghế Vip")
            {
                basePrice += ticketPriceSetting.SurchargeVIP;
            }
            else if (seatType.SeatTypeName == "Ghế đôi")
            {
                basePrice += ticketPriceSetting.SurchargeCouple;
            }

            // Create the TicketPrice entity to insert or update
            var ticketPrice = new TicketPrice
            {
                ID = Guid.NewGuid(),
                Price = ticketPriceDTO.Price > 0 ? ticketPriceDTO.Price : basePrice,
                SeatTypeID = ticketPriceDTO.SeatTypeID,
                ShowTimeID = ticketPriceDTO.ShowTimeID,
                ScreeningID = ticketPriceDTO.ScreeningID,
                TicketPriceSettingID = Guid.Parse("4BAB0DA1-D912-4A87-8E21-CB7A665657D3")
            };

            _context.TicketPrice.Add(ticketPrice);
            await _context.SaveChangesAsync();
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        public async Task<List<TicketPriceDTO>> GetAllTicketPrices()
        {
            var ticketPrice = await _context.TicketPrice
                    .Select(x => new TicketPriceDTO
                    {
                        ID = x.ID,
                        ScreeningID = x.ScreeningID,
                        ShowTimeID = x.ShowTimeID,
                        SeatTypeID = x.SeatTypeID,
                        Price = x.Price,
                    }).ToListAsync();
            return ticketPrice;
        }

        public async Task<TicketPriceDTO> GetTicketPriceById(Guid id)
        {
            var ticketPrice = await _context.TicketPrice
              .Include(t => t.Screening)
              .Include(t => t.SeatTypeID)
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
                SeatTypeID = ticketPrice.SeatTypeID,
                ShowTimeID = ticketPrice.ShowTimeID,
                ScreeningID = ticketPrice.ScreeningID
            };
        }

        public async Task<HttpResponseMessage> UpdateTicketPrice(TicketPriceDTO ticketPrice)
        {
            var existingTicketPrice = await _context.TicketPrice
                .FirstOrDefaultAsync(tp => tp.ID == ticketPrice.ID);

            if (existingTicketPrice == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }

            existingTicketPrice.Price = ticketPrice.Price;
            await _context.SaveChangesAsync();

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
        private decimal CalculateBasePrice(DateTime screeningDate, TimeSpan showStartTime, SeatType seatType,
            NeonCinema_Domain.Database.Entities.TicketPriceSetting ticketPriceSetting)
        {
            decimal basePrice = 0;

            // Calculate base price based on the day of the week and showtime
            if (screeningDate.DayOfWeek == DayOfWeek.Monday ||
                screeningDate.DayOfWeek == DayOfWeek.Tuesday ||
                screeningDate.DayOfWeek == DayOfWeek.Wednesday ||
                screeningDate.DayOfWeek == DayOfWeek.Thursday)
            {
                basePrice = showStartTime < new TimeSpan(17, 0, 0) ? ticketPriceSetting.PriceBefore17hWeekDay  : ticketPriceSetting.PriceAfter17hWeekDay ;
            }
            else if (screeningDate.DayOfWeek == DayOfWeek.Friday ||
                     screeningDate.DayOfWeek == DayOfWeek.Saturday ||
                     screeningDate.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice = showStartTime < new TimeSpan(17, 0, 0) ? ticketPriceSetting.PriceBefore17hWeekeend  : ticketPriceSetting.PriceAfter17hWeekeend ;
            }

            // Additional charges for seat types
            if (seatType.SeatTypeName == "Ghế Vip")
            {
                basePrice += ticketPriceSetting.SurchargeVIP;
            }
            else if (seatType.SeatTypeName == "Ghế đôi")
            {
                basePrice += ticketPriceSetting.SurchargeCouple;
            }

            return basePrice;
        }
    }

}
