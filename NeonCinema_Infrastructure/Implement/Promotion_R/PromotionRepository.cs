using Com.CloudRail.SI.ServiceCode.Commands;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Promotion_R
{
    public class PromotionRepository : IEntityRepository<Promotion>
    {
        private readonly NeonCinemasContext _context;
        public PromotionRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(Promotion entity, CancellationToken cancellationToken)
        {
            try
            {
                entity.Status = PromotionStatus.InActive;
                _context.Promotions.Add(entity);
                await _context.SaveChangesAsync();


                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Create successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }

        }

        public async Task<HttpResponseMessage> Delete(Promotion entity, CancellationToken cancellationToken)
        {
            try
            {
                var pro = await GetById(entity.ID, cancellationToken);

                if (pro == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Not found")
                    };
                }

                _context.Promotions.Remove(pro);
                await _context.SaveChangesAsync();

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete successfully")
                };
            }
            catch (Exception ex) 
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }

        }

        public async Task<List<Promotion>> GetAll(CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _context.Promotions.ToListAsync();

                if(lst == null)
                {
                    throw new Exception("Null");
                }

                return lst;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Promotion> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _context.Promotions.FindAsync(id);

                if (entity == null)
                {
                    throw new Exception("Not found");
                }

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(Promotion entity, CancellationToken cancellationToken)
        {
            try
            {
                var pro = await GetById(entity.ID, cancellationToken);

                if (pro == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Not found")
                    };
                }

                pro.Name = entity.Name;
                pro.Code = entity.Code;
                pro.Description = entity.Description;
                pro.DiscountAmount = entity.DiscountAmount;
                pro.DiscountPercentage = entity.DiscountPercentage;
                pro.StartDate = entity.StartDate;
                pro.EndDate = entity.EndDate;
                pro.Status = entity.Status;


                _context.Promotions.Update(pro);
                await _context.SaveChangesAsync();


                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Update successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }
    }
}
