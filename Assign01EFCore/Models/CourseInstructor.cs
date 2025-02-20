using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    [Table("Course_Inst")]
    internal class CourseInstructor
    {
        [Column(name: "Inst_Id")]
        [Key]
        public int InstructorId { get; set; }
        [Column(name: "Course_Id")]
        public int CourseId { get;  set; }
        [NotMapped]
        public int evaluate {  get; set; }
    }
}
