using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class RoleMenu
    {
        [Key]
        public int Id { get; set; }
        public int RId { get; set; }
        public int MId { get; set; }
        public int C { get; set; }
        public int R { get; set; }
        public int U { get; set; }
        public int D { get; set; }

    }
}
