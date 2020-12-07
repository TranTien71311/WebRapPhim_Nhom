using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAppCinemaBooking.Areas.Admin.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCinemaBooking.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomsAPIController : ControllerBase
    {
            private readonly DPContext _context;

            public RoomsAPIController(DPContext context)
            {
                _context = context;
            }


            [HttpGet]
            public string ChangeStatus(int id)
            {
                var room = _context.Rooms.FirstOrDefault(m => m.ID == id);
                if (room.Status == 1)
                    room.Status = 0;
                else
                    room.Status = 1;
                _context.Rooms.Update(room);
                _context.SaveChanges();
                return JsonConvert.SerializeObject(room);
            }

    }
}
