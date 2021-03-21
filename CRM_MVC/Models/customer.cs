using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Customer
    {
        [Key]
        public int CId { get; set; }
        public int CNO { get; set; }
        public int CName { get; set; }
        public int AID { get; set; }
        public int LId { get; set; }
        public int Credit { get; set; }
        public int State { get; set; }
        public int Remark { get; set; }
    }
}
