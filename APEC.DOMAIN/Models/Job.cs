using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("Jobs")]
    public class Job
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int jobID{ get; set; }

        public int clientID { get; set; }

        public string jobTitle { get; set; }

        public string Description { get; set; }

        public int daysInMonth { get; set; }

    }
}
