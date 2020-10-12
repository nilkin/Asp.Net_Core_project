using System.ComponentModel.DataAnnotations;

namespace CorporX.Models
{
    public class SocialLink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
