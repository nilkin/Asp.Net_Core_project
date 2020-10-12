using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Project:ContentEntity
    {
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public string Category { get; set; }
    }
}
