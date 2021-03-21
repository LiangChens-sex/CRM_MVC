using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Buy_Product
    {
        [Key]
        public int RId { get; set; }
        public int CID { get; set; }
        public string BNO { get; set; }
        public DateTime BTime { get; set; }
        public int Product { get; set; }
        public int PNum { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal Discount { get; set; }
        public string Remark { get; set; }
    }
}
