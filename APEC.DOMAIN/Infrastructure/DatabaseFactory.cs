using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Infrastructure
{
    public interface IDatabaseFactory
    {
        APECDBContext Get();
    }

    public class DatabaseFactory:IDisposable, IDatabaseFactory
    {
        private APECDBContext dataContext;

        public APECDBContext Get()
        {
            return dataContext ?? (dataContext = new APECDBContext());
        }

        public void Dispose()
        {
            if (dataContext != null)
                dataContext.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
