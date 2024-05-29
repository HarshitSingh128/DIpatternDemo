using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIpatternDemo.Models
{
    [Table("Product1")]
    public class Product1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)]//it is used to not show in output it mean views is not created by these property
        public int Isactive { get; set; }


    }
}
