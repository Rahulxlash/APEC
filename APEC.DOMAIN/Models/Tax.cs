using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
       [Table("Tax")]
   public class Tax
    {
        public int RecordID { get; set; }
        public string TaxType { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public double Rate{ get; set; }

    }
}
