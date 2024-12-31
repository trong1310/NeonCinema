using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.Utili
{
	public static class Uliti
	{
		public static string GenerateCode()
		{
			StringBuilder builder = new StringBuilder("UDKH");
			Enumerable
			   .Range(65, 26)
				.Select(e => ((char)e).ToString())
				.Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
				.Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
				.OrderBy(e => Guid.NewGuid())
				.Take(10)
				.ToList().ForEach(e => builder.Append(e));
			string id = builder.ToString();
			return id;
		}
		public static long GenerateBillCode()
		{
			int maxDigits = 15;
			Random random = new Random();

			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < maxDigits; i++)
			{
				builder.Append(random.Next(0, 10));
			}
			if (long.TryParse(builder.ToString(), out long billCode))
			{
				return billCode;
			}
			throw new InvalidOperationException($"Unable to generate a valid ulong Bill Code. Generated value: {builder}");
		}



	}
}
