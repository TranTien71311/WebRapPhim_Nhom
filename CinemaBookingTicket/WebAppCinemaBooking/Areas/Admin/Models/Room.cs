using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCinemaBooking.Areas.Admin.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Sức chứa không được bỏ trống")] public int Capacity { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        [Required(ErrorMessage = "Rạp Phim không được bỏ trống")] public int Cinema_ID { get; set; }
        [ForeignKey("Cinema_ID")]

        public virtual Cinema Cinema { get; set; }
    }
}
