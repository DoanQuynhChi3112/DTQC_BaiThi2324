
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTQC_BaiThi2324.Models;
    [Table("DTQC114Person")]
public class DTQC114Person

{
        [Key]
        public string? DTQC114PersonID { get; set; }
        public int DTQC114Age { get; set; }
        public DateTime DTQC114Ngaysinh { get; set; }
        
}
