using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Language
{
    public class UpdateLanguageRequest
    {
        public Guid ID { get; set; }
        public string LanguageName { get; set; }
    }
}
