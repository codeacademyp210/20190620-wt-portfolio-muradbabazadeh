using Adam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Adam.DAL
{
    public class AdamContext: DbContext
    {
       

        public AdamContext() : base("AdamCN")
        {

        }
        DbSet<AboutMe> AboutMe { get; set; }
        DbSet<Experience> Experience { get; set; }
        DbSet<HeaderSection> HeaderSection { get; set; }

        






        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}