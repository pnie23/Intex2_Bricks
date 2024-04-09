using System.ComponentModel.DataAnnotations;

namespace Intex2_Bricks.Models
{
    public class Recommendation
    {
        [Key]
        [Required]
        public string asin { get; set; }
        public int Rec1 { get; set; }
        public int Rec2 { get; set; }
        public int Rec3 { get; set; }
        public int Rec4 { get; set; }
    }
}
