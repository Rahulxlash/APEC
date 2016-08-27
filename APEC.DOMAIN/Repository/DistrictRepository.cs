using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{
    public interface IDistrictRepository : IRepository<District>
    {

    }
    public class DistrictRepository : AbstractRepository<District>, IDistrictRepository
    {
        public DistrictRepository(IDatabaseFactory factory) :
            base(factory)
        {

        }
    }
}
