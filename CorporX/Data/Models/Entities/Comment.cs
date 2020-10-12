using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class Comment:ContentEntity
    {
        public string Website { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
