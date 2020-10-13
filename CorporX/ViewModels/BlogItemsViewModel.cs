using CorporX.Data.Models;
using CorporX.Models;
using ReflectionIT.Mvc.Paging;
using System.Collections.Generic;

namespace CorporX.ViewModels
{
    public class BlogItemsViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public PagingList<BlogItem> PagingList { get; internal set; }
    }
}
