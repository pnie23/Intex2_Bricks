using System.ComponentModel.DataAnnotations;

namespace Intex2_Bricks.Models
{
    public class IBRecommendation
    {
        [Key]
        [Required]
        public string original_product { get; set; }
        public int recommended_product_1 { get; set; }
        public int recommended_product_2 { get; set; }
        public int recommended_product_3 { get; set; }
        public int recommended_product_4 { get; set; }
    }
}
