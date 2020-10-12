using CorporX.Data;
using CorporX.Data.Models;
using CorporX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class BlogItemsViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<BlogItem> BlogItems { get; set; }
    }
}
