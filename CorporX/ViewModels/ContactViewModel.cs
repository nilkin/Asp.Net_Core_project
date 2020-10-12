using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class ContactViewModel
    {
        public Setting Sett { get; set; }
        public Breadcrumb Breadcrumb { get; set; }
        public Setting Setting { get; set; }
    }
}
