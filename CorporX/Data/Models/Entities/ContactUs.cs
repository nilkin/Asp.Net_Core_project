using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Fullname")]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(300)]
        [Required(ErrorMessage = "Please enter Your Message")]
        public string Message { get; set; }
    }
}
