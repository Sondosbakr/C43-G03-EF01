using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01EFCore.Models
{
    [Table("Topic")]
    internal class Topic
    {
        public int Id { get; set; }
        [Column(name:"Name", TypeName ="varchar")]
        [StringLength(10)]
        [Required]
        public string Name { get; set; }
    }
}
