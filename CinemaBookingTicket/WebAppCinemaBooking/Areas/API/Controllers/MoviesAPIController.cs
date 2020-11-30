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
    public class MoviesAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public MoviesAPIController(DPContext context)
        {
            _context = context;
        }


        [HttpGet]
        public string ChangeStatus(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.ID == id);
            if (movie.Status == 1)
                movie.Status = 0;
            else
                movie.Status = 1;
            _context.Movies.Update(movie);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(movie);
        }
    }
}
