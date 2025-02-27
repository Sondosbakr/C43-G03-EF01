using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    public class Course
    {
        //Id,Name,Duration,Discription
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }

        
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        [ForeignKey(nameof(Topic))]
        public int? TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<InstructorCourse> CourseInstructors { get; set; } = new HashSet<InstructorCourse>();
    }
}
