using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    internal class StudCourse
    {
        [Key]
        public int StudId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }

    }
}
