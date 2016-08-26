using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN.Models
{
    [Table("BLOCK_MASTER")]
    public class blockMaster
    {
        public string DISTRICT_NAME{ get; set; }
        public string BLOCK_NAME  { get; set; }
    }
    [Table("DEPARTMENT_MASTER")]
    public class DEPARTMENT_MASTER
    {
        public int INDEX { get; set; }
        public string DEPARTMENTNAME { get; set; }
        public string INDPT { get; set; }
        public string UNDERDPT { get; set; }
        public string ORDERDPT { get; set; }
        
    }

    [Table("DISTRICT_MASTER")]
    public class DISTRICT_MASTER
    {
        public string DISTRICTNAME { get; set; }
    }

}
