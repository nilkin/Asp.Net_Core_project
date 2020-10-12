using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using CorporX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class FaqViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<Faq> Fags { get; set; }
    }
}
