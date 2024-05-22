
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIpatternDemo.Models
{
    [Table("Student1")]
    public class Student1
    {

        [Key]
        public int Sid { get; set; }
        [Required]
        public string? Sname { get; set; }
        [Required]
        public int Sage { get; set; }
        [Required]
        public string? Semail { get; set; }

        [ScaffoldColumn(false)]//it is used to not show in output it mean views is not created by these property
        public int Isactive { get; set; }
    }
}
