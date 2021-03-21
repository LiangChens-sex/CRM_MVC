using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Base_Dictionary
    {
        [Key]
        public int did { get; set; }
        public string data_type { get; set; }
        public string data_code { get; set; }
        public string data_value { get; set; }
        public int pid { get; set; }
        public int sort { get; set; }
        public string remark { get; set; }
    }
}
