using System.ComponentModel.DataAnnotations;

namespace CRUD_2.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }
    }
}
