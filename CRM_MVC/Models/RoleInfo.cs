using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class RoleInfo
    {
        [Key]
        public int RId { get; set; }
        public string RName { get; set; }
        public int Level { get; set; }
        public string Remark { get; set; }
    }
}
