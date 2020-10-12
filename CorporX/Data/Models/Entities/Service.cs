using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Service:ContentEntity
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public bool IsPromoHome { get; set; }
        public bool IsDeliver { get; set; }
        public bool IsPromoAbout { get; set; }
        public bool IsPromoServ { get; set; }
    }
}
