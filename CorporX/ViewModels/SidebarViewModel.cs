using CorporX.Data.Models;
using CorporX.Models;
using System.Collections.Generic;

namespace CorporX.ViewModels
{
    public class SidebarViewModel

    {
        public BlogItem BlogItem { get; set; }
        public Breadcrumb Breadcrumb { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
