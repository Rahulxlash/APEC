using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{

    public interface IPostRepository: IRepository<Post>
    {

    }

    public class PostRepository : AbstractRepository<Post>, IPostRepository
    {
        public PostRepository(IDatabaseFactory factory)
            : base(factory)
        {

        }
    }
}
