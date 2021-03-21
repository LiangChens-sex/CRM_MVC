using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Customer_Service
    {
        [Key]
        public int sid { get; set; }
        public int service_type { get; set; }
        public int CID { get; set; }
        public int EID_create { get; set; }
        public DateTime create_time { get; set; }
        public int state { get; set; }
        public int EID_appoint{ get; set; }
        public DateTime ftime { get; set; }
        public int EID_do{ get; set; }
        public string remark { get; set; }
        public DateTime do_time { get; set; }
        public string do_result { get; set; }
        public int pleased { get; set; }















    }
}
