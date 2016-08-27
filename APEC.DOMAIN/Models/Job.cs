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
        public int JobID { get; set; }

        public int ClientID { get; set; }

        public string JobTitle { get; set; }

        public string Description { get; set; }

        public int DaysInMonth { get; set; }

    }
}
