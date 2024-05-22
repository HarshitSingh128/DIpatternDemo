using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIpatternDemo.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key] //this is primary key in the table
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }//? to allow null from db
        [Required]
        public string? City { get; set; }
        [Required]
        public Decimal Salary { get; set; }

        [ScaffoldColumn(false)]//it is used to not show in output it mean views is not created by these property
        public int Isactive { get; set; }
    }
}
