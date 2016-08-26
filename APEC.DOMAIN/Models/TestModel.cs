using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("testTable")]
    public class TestModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int autoID { get; set; }

        public string Name { get; set; }

    }
}
