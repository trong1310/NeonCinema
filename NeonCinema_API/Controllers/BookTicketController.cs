using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.Configuration;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTicketController : ControllerBase
    {
        IEntityRepository<BookTickets> _repos;
        IMapper _mapper;
        public BookTicketController(IEntityRepository<BookTickets> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

      
    }
}
