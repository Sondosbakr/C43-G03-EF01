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
        public int Id { get; set; }
        [Column(name: "FName", TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Name Must Be Less Than 51",MinimumLength = 3)]

        public string? FirstName { get; set; }
        [Column(name: "LName" , TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Name Must Be Less Than 51", MinimumLength = 3)]
        public string?LastName {  get; set; }
        public string? Address { get; set; }

        
        public int Age { get; set; }
        public int DeptId { get; set; }
    }
}
