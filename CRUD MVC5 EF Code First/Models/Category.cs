using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_MVC5_EF_Code_First.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    public class CategoryContext : DbContext
    {
        public CategoryContext() : base("Category")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CategoryContext, CRUD_MVC5_EF_Code_First.Migrations.Configuration>());
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}