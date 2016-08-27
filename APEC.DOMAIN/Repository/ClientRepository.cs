using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{
    
    public interface IClientRepository : IRepository<Client>
    {

    }
    public class ClientRepository : AbstractRepository<Client>, IClientRepository
    {
        public ClientRepository(IDatabaseFactory factory) :
            base(factory)
        {

        }

    }
}
