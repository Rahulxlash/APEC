using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    public class Job
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        public int ClientId { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        public string Description { get; set; }

        [Display(Name = "Days")]
        public int DaysInMonth { get; set; }

        [Display(Name = "Last Date")]
        public DateTime ApplicationLastDate { get; set; }

        public bool ResultDeclared { get; set; }
        [Display(Name = "Infomation URL")]
        public string InfoLink { get; set; }
        [Display(Name = "Posts")]
        public int NumberofPosts { get; set; }
        [Display(Name = "Proposed Salary")]
        public decimal ProposedSalary { get; set; }

        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

    }
}
