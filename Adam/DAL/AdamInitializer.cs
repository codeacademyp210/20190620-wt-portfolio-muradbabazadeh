using Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Adam.DAL
{
    public class AdamInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<AdamContext>
    {
        protected override void Seed(AdamContext context)
        {
            var header = new HeaderSection { Headerh1 = "Adam Soe" };
           
        }
    }
}