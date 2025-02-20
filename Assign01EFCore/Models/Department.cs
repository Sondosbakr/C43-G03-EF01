using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(name: "Ins_Id")]
        public int InstructorId { get; set; }
        public int HiringDate { get; set; }
    }
}
