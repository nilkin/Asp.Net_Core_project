using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Hero:ContentEntity
    {
        public string Heading { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }

    }
}
