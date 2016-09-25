using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{
    public interface IRegistrationRepository : IRepository<Registration>
    {
    }

    public class RegistrationRepository : AbstractRepository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(IDatabaseFactory factory)
            : base(factory) { }

    }
}
