using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using CorporX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class ServiceViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<Service> Services { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Service> Promo { get; set; }
        public Setting Setting { get; set; }
    }
}
