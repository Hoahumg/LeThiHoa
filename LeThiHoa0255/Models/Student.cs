using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeThiHoa0255.Models
{
    public class Student
    {
        [Key]
        public int Malop { get; set; }
        public string Ten { get; set; }
        public string Masinhvien { get; set; }
    }
}