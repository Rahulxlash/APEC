using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{
    public interface IJobRepository : IRepository<Job>
    { }

    public class JobRepository : AbstractRepository<Job>, IJobRepository
    {
        public JobRepository(IDatabaseFactory factory)
            : base(factory)
        { }
    }
}
