using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assign01EFCore.Models
{
    [PrimaryKey(nameof(InstructorId), nameof(CourseId))]
    public class InstructorCourse
    {
        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public string? Evaluation { get; set; }

    }
}
