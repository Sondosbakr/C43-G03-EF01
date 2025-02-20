using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Column(name: "FName", TypeName ="varchar")]
        [StringLength(50, ErrorMessage = "Name Must be Less Than 51 Char", MinimumLength = 3)] // Application Validation Min
        public string? FirstName { get; set; }

        [Column(name: "LName", TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Name Must be Less Than 51 Char", MinimumLength = 3)] // Application Validation Min
        public string? LastName { get; set; }
        [Column(name: "Address", TypeName ="varchar")]
        public string? Address { get; set; }
        [Column(name: "Dept_Id")]
        public int DepartmentId {  get; set; }
    }
}
