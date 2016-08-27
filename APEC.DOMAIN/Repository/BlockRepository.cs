using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{

    public interface IBlockRepository : IRepository<Block> { }
    public class BlockRepository:AbstractRepository<Block>, IBlockRepository
    {
        public BlockRepository(IDatabaseFactory factory) :
            base(factory)
        {
            
        }
    }
}
