using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN
{
    public class DBContext : DbContext
    {
        public DBContext():base("APECConnString")
        {

        }
        public virtual DbSet<TestModel> TestModel{get;set;}
    }
}
