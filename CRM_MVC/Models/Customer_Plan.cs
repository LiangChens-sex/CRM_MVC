using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Customer_plan
    {
        [Key]
        public int PId { get; set; }
        public int SId { get; set; }
        public DateTime PTime { get; set; }
        public string Remark { get; set; }
        public bool Result { get; set; }

    }
}
