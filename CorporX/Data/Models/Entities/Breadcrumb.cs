using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Data.Models
{
    public class Breadcrumb
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        [NotMapped]
        public string Link { get; set; }
        public string Path { get; set; }
    }
}
