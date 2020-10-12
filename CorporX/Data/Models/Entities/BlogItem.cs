using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class BlogItem : ContentEntity
    {
        public string Text { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public DateTime AddedDate { get; set; }
        [NotMapped]
        public string BlogType { get; set; }
        public bool IsSidebar { get; set; }
    }
}
