using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoangDucManh253.Models
{
    public class HDM0253
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string HDMId { get; set; }
        [Required]
        [StringLength(50)]
        public string HDMName { get; set; }
        public bool HDMGender { get; set; }
    }
}
