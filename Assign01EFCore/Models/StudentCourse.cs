using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    [Table("StudCourse")]
    internal class StudentCourse
    {
        [Column(name: "StudId")]
        [Key]
        public int StudentId { get; set; }
        [Column(name: "CourseId")]
        public int CourseId { get; set; }
        [Range(10, 100)]
        public int Grade { get; set; }


    }
}
