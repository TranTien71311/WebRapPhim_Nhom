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
    public class CinemasAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public CinemasAPIController(DPContext context)
        {
            _context = context;
        }


        [HttpGet]
        public string ChangeStatus(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(m => m.ID == id);
            if (cinema.Status == 1)
                cinema.Status = 0;
            else
                cinema.Status = 1;
            _context.Cinemas.Update(cinema);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(cinema);
        }

    }
}
