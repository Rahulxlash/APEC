﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Infrastructure
{
    public interface IDatabaseFactory
    {
        APECDBContext Get();
    }

    public class DatabaseFactory : IDisposable, IDatabaseFactory
    {
        private APECDBContext dataContext;

        public APECDBContext Get()
        {
            if (dataContext == null)
            {
                dataContext = new APECDBContext();
                dataContext.Database.Log = msg => Debug.WriteLine(msg);
            }
            return dataContext;
        }

        public void Dispose()
        {
            if (dataContext != null)
                dataContext.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
