using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInMVC.Models
{
   public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int DepartmentId { get; set; }
        public string Semester { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
