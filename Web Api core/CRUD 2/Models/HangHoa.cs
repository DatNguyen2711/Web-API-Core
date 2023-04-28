namespace CRUD_2.Models
{
    public class HangHoaVM
    {
        public string TenHh { get; set; }
        public double Dongia { get;set; }
        public int code { get; set; }       
    }

    public class HangHoa : HangHoaVM { 
        public Guid MaHangHoa { get; set; }
    }
}
