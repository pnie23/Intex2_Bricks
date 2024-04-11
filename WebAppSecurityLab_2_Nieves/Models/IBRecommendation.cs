using System.ComponentModel.DataAnnotations;

namespace Intex2_Bricks.Models
{
    public class IBRecommendation
    {
        [Key]
        [Required]
        public string original_product { get; set; }
        public int recommended_product_1 { get; set; }
        public int recommended_product_1_Name { get; set; }
        public int recommended_product_1_Year { get; set; }
        public int recommended_product_1_Img_link { get; set; }
        public int recommended_product_2 { get; set; }
        public int recommended_product_2_Name { get; set; }
        public int recommended_product_2_Year { get; set; }
        public int recommended_product_2_Img_link { get; set; }
        public int recommended_product_3 { get; set; }
        public int recommended_product_3_Name { get; set; }
        public int recommended_product_3_Year { get; set; }
        public int recommended_product_3_Img_link { get; set; }
        public int recommended_product_4 { get; set; }
        public int recommended_product_4_Name { get; set; }
        public int recommended_product_4_Year { get; set; }
        public int recommended_product_4_Img_link { get; set; }

    }
}
