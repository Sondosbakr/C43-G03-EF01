using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Column(name:"Name", TypeName ="varchar")]
        [StringLength(50, ErrorMessage = "Name Must Be Less Than 51", MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        public int Bonus { get; set; }
        [Column(TypeName = "decimal(10,2)")]

        public decimal Salary { get; set; }

        public string? Address  { get; set; }

        public int HourRate { get; set; }
        [Column(name: "Dept_Id")]
        public int DeparementId { get; set; }

        public ICollection<Department> Departments { get; set; } = new HashSet<Department>();
    }
}
