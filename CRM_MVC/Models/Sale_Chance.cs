using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Sale_Chance
    {
        [Key]
        public int SId { get; set; }
        public string SNO { get; set; }
        public int EID_create{ get; set; }
        public DateTime CTime { get; set; }
        public int EID_appoint{ get; set; }
        public DateTime FTime { get; set; }
        public int EID_do{ get; set; }
        public int State { get; set; }
        public string Remark { get; set; }
    }
}
