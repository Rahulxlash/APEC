using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public string Department{ get; set; }
        public string ReportingTo{ get; set; }
        public string OrderNo{ get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
    }
}
