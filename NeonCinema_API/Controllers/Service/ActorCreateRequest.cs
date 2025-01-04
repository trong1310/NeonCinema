using NeonCinema_Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace NeonCinema_API.Controllers.Service
{
    public class ActorCreateRequest
    {
        public Guid id { get; set; }
        [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "Họ và tên không được chứa số hoặc ký tự đặc biệt.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public EntityStatus Sex { get; set; }
        public EntityStatus Status { get; set; }
    }
    public class UpdateActorRequests
    {
        public Guid id { get; set; }
        [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "Họ và tên không được chứa số hoặc ký tự đặc biệt.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public EntityStatus sex { get; set; }
        public EntityStatus status { get; set; }
    }
    public class ActorResponse
    {
        public Guid id { get; set; }
        [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "Họ và tên không được chứa số hoặc ký tự đặc biệt.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public EntityStatus sex { get; set; }
        public EntityStatus status { get; set; }
    }
}
