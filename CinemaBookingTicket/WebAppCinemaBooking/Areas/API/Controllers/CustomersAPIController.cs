﻿using Microsoft.AspNetCore.Http;
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
    public class CustomersAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public CustomersAPIController(DPContext context)
        {
            _context = context;
        }


        [HttpGet]
        public string ChangeStatus(int id)
        {
            var customer = _context.Customers.FirstOrDefault(m => m.ID == id);
            if (customer.Status == 1)
                customer.Status = 0;
            else
                customer.Status = 1;
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return JsonConvert.SerializeObject(customer);
        }
    }
}
