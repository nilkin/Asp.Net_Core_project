using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Member: ContentEntity
    {
        public string Position { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public List<MemberLink> MemberLinks { get; set; }
    }
}
