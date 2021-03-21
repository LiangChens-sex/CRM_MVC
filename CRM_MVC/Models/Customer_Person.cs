using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Customer_Person
    {
        [Key]
        public int PId { get; set; }
        public int CID { get; set; }
        public string PName { get; set; }
        public int Sex { get; set; }
        public string Telphone { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }

    }
}
