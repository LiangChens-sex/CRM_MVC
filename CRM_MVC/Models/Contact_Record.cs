using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class Contact_Record
    {
        [Key]
        public int RId { get; set; }
        public int CID { get; set; }
        public DateTime RTime { get; set; }
        public string address { get; set; }
        public string outline { get; set; }
        public string detail { get; set; }
        public string remark { get; set; }

    }
}
