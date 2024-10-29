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
	public class PromotionCustomerResp : IEntityRepository<PromotionUsers>
	{
		private readonly NeonCinemasContext _context;

		public PromotionCustomerResp(NeonCinemasContext context)
		{
			_context = context;
		}

		public async Task<HttpResponseMessage> Create(PromotionUsers entity, CancellationToken cancellationToken)
		{
			try
			{
				entity.Status = PromotionStatus.Unused;

				_context.PromotionUsers.Add(entity);
				await _context.SaveChangesAsync(cancellationToken);


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

		public Task<HttpResponseMessage> Delete(PromotionUsers entity, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<List<PromotionUsers>> GetAll(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<PromotionUsers> GetById(Guid id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public async Task<HttpResponseMessage> Update(PromotionUsers entity, CancellationToken cancellationToken)
		{
			try
			{
				entity.Status = PromotionStatus.Used;


				_context.PromotionUsers.Update(entity);
				await _context.SaveChangesAsync(cancellationToken);


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
