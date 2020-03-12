using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFDAL.Models
{
    [Table("Project")]
    public class Project
    {
        [Key] //set primary key
        public int ProjectID { get; set; }
        [Required] //set not null
        [StringLength(30)]
        public string ProjectName { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }
        //set one to many relation with Employee
        public IEnumerable<Employee> Employees { get; set; }
    }
}
