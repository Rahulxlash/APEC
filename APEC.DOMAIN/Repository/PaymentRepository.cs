using APEC.DOMAIN.Infrastructure;
using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Repository
{
    public interface IPaymentRepository : IRepository<Payment>
    {

    }
    
    public class PaymentRepository:AbstractRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(IDatabaseFactory factory)
            : base(factory)
        {

        }
    }
}
