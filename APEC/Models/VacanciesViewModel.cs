using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APEC.DOMAIN.Models;

namespace APEC.Models
{
    public class VacanciesViewModel
    {
            public IList<Job> CurrentJobs { get; set; }
            public IList<Job> ExpiredJobs { get; set; }
    }
}