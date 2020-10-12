using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using CorporX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class HomeViewModel 
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Hero Heroes { get; set; }
        public List<Service> Promos { get; set; }
        public AboutUs About { get; set; }
        public List<Service> HomeServices { get; set; }
        public List<Project> Projects { get; set; }
        public List<BlogItem> BlogItems { get; set; }
        public List<Client> Clients { get; set; }
        public List<Member> Members { get; set; }
        public List<MemberLink> MemberLinks { get; set; }
    

    }
}
