using System;
using System.Collections.Generic;

namespace EFCOREDBFirst.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? Joindate { get; set; }
        public string Designation { get; set; }
        public int? Salary { get; set; }
        public string Pid { get; set; }

        public virtual Project P { get; set; }
    }
}
