using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Package:ContentEntity
    {
        public int Price { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public string BtnClass { get; set; }
        public string Class { get; set; }
    }
}
