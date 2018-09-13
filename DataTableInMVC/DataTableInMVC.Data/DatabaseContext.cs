using DataTableInMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInMVC.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("DatabaseConnection")
        {

        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
    }
}
