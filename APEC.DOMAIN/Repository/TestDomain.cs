using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{
    public class TestDomain:DBContext
    {
        DBContext dbContext = new DBContext();
        public void TestMethod()
        {
            var list = dbContext.TestModel.ToList();
        }
    }
}
