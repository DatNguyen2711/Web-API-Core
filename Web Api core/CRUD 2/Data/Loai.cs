using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_2.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenLoai { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set;}
    
    }
}
