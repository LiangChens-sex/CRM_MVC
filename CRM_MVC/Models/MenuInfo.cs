using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class MenuInfo
    {
        [Key]
        public int MId { get; set; }
        public string MName { get; set; }
        public string URL { get; set; }
        public string Remark { get; set; }
        public int PId { get; set; }
        public int Sort { get; set; }
    }
}
