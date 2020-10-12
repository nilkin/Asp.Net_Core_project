using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using CorporX.Models;
using System.Collections.Generic;

namespace CorporX.ViewModels
{
    public class AboutUsViewModel
    {
        public  Breadcrumb Breadcrumb { get; set; }
        public List<Member> Members { get; set; }
        public List<MemberLink> MemberLinks { get; set; }
        public List<Service> Promos { get; set; }
        public AboutUs Abouts { get; set; }
        public List<Service> Deliver { get; set; }
        public List<Client> Clients { get; set; }
        public List<Partner> Partners { get; set; }
    }
}
