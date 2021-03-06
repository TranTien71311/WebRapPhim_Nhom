﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCinemaBooking.Areas.Admin.Models
{
    public class Seat_Level
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        public string Image { get; set; }
        public string Image_Selected { get; set; }
        public string Image_Checked { get; set; }
        public int Count_Cell { get; set; }
        [Required(ErrorMessage = "Giá không được bỏ trống")] public int Price { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }

        public ICollection<Seat> listSeat { get; set; }
    }
}
