using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int EId { get; set; }
        public string ENO { get; set; }
        public string Password { get; set; }
        public string EName { get; set; }
        public string IDCard { get; set; }
        public int DID { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }








    }
}
