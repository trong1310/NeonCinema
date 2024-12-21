using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention
{
	public static class ClaimExtension
	{
		public static string? GetUsername(this ClaimsPrincipal user) => user.FindFirst("username")?.Value;
		public static string? GetUuid(this ClaimsPrincipal user) => user.FindFirst("uuid")?.Value;
		public static string? GetRole(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.Role)?.Value;

	}
}
