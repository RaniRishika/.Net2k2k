using System;
using System.Collections.Generic;

namespace HandsOnAPIDemo2.Models
{
    public partial class Employee
    {
        public string Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
