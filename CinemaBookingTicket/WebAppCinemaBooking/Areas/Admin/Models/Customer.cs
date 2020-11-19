using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCinemaBooking.Areas.Admin.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Password không được bỏ trống")] public string Pass { get; set; }
        [Required(ErrorMessage = "Email không được bỏ trống")] public string Email { get; set; }
        public string BirthDay { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Total_Spending { get; set; }
        public string Avatar { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
    }
}
