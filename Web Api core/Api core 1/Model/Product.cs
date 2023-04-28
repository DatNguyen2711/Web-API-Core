using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_core_1.Model
{
    [Table("Book")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [Range(0,double.MaxValue)]
        public int Price { get; set; }
        public int categoryID { get; set; }

    }
}
