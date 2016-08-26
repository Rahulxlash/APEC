using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("clientMaster")]
    public class clientMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clientID { get; set; }
        public string Name { get; set; }
        public int districtID { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string ContactPerson { get; set; }


    }
}
