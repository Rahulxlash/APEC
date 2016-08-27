using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Infrastructure
{
    public interface IUnitofWork
    {
        void SaveChanges();
    }

    public class UnitofWork: IUnitofWork
    {
        private APECDBContext dbContext;
        private readonly IDatabaseFactory databaseFactory;

        protected APECDBContext DbContext
        {
            get
            {
                return dbContext ?? (dbContext = databaseFactory.Get());
            }
        }

        public UnitofWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }

    }
}
