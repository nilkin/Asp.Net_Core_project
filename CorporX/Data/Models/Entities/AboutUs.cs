using CorporX.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Data.Models.Entities
{
    public class AboutUs : ContentEntity
    {
        public string Context { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
