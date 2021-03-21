using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Customer_Away
    {
        [Key]
        public int AId { get; set; }
        public int CId { get; set; }
        public int State { get; set; }
        public string Reamrk { get; set; }

    }
}
