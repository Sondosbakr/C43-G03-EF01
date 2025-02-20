using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    [Table("Course")]
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(name: "Name", TypeName = "varchar")]
        [MaxLength(50)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TopId { get; set; }
        public DateTime Duration { get; set; }
    }
}
