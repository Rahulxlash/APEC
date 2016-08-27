using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    public class Block
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlockId { get; set; }

        public int DistrictId { get; set; }
        public string Name { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }
    }
}
