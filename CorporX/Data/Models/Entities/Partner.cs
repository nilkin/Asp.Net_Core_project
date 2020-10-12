using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public string Url { get; set; }
    }
}
