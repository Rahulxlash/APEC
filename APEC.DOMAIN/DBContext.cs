using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN
{
    public class APECDBContext : DbContext
    {
        public APECDBContext()
            : base("APECConnString")
        {
            Database.SetInitializer<APECDBContext>(new CreateDatabaseIfNotExists<APECDBContext>());
        }
        public virtual DbSet<Client> Clients{get;set;}
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
    }
}
