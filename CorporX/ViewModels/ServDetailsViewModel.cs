using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using CorporX.Models;

namespace CorporX.ViewModels
{
    public class ServDetailsViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Service Details { get; set; }
        public Setting Sett { get; set; }
    }
}
