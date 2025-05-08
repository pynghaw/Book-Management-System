using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVCNoEF.Models;

namespace WebMVCNoEF.Data
{
    public class WebMVCNoEFContext : DbContext
    {
        public WebMVCNoEFContext (DbContextOptions<WebMVCNoEFContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVCNoEF.Models.BookViewModel> BookViewModel { get; set; } = default!;
    }
}
