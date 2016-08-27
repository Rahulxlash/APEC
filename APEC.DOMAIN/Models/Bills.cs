using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    public class BillHeader
    {
        public int BillId { get; set; }
        public int ClientId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime BillDate { get; set; }
        public string Type { get; set; }
        public bool Paid { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string PaymentDetails { get; set; }
        public double Amount { get; set; }
        public double Taxes { get; set; }
        public double TotalAmount { get; set; }

    }

    public class BillDetails
    {
        public int BillId { get; set; }
        public int BillDetailsId { get; set; }
        public int EmployeeId { get; set; }
        public double TotalDays { get; set; }
        public int PresentDays { get; set; }
        public int AbsentDays { get; set; }
        public double Amount { get; set; }
        public double Taxes{ get; set; }
        public double TotalAmount { get; set; }


        
    }
}
