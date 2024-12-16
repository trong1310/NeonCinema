using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Resp
{
	public class RankMemberResp
	{
		public Guid Id { get; set; }
		public Guid AccountId { get; set; }
		public string AccountName { get; set; }
		public string Rank {  get; set; }
		public double Point {  get; set; }

	}
}
