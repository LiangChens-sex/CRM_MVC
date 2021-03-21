using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class EmpRole
    {
        [Key]
        public int Id { get; set; }
        public int RID { get; set; }
        public int EID { get; set; }
    }
}
