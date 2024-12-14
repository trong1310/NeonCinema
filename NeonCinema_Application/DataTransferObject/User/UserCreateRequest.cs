using Microsoft.AspNetCore.Http;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User
{
    public class UserCreateRequest
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOrBriht { get; set; }
        public string? Images { get; set; }
        public bool? Gender { get; set; }
        public string? Adderss { get; set; }
        public string? PassWord  { get; set; }
    }

}
