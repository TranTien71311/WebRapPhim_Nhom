using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCinemaBooking.Areas.Admin.Data;

namespace WebAppCinemaBooking.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Seat_LevelAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public Seat_LevelAPIController(DPContext context)
        {
            _context = context;
        }


        [HttpGet]
        public string ChangeStatus(int id)
        {
            var seat_Level = _context.Seat_Levels.FirstOrDefault(m => m.ID == id);
            if (seat_Level.Status == 1)
                seat_Level.Status = 0;
            else
                seat_Level.Status = 1;
            _context.Seat_Levels.Update(seat_Level);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(seat_Level);
        }
    }
}
