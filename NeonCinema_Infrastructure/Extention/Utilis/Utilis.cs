using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.Utilis
{
    public class Utilis
    {
        public string GenerateCode()
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
    }
}
