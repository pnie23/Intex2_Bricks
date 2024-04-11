using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex2_Bricks.Models
{
    public class IBRecommendation
    {
        [Key]
        [ForeignKey("Product")]
        public int product_Id { get; set; }
        [ForeignKey("product_Id")]
        public Product? Product { get; set; }
        public string original_product { get; set; }
        public int recommended_product_1_Name { get; set; }
        public int recommended_product_1_Year { get; set; }
        public int Recommended_Product_1_Price { get; set; }
        public int recommended_product_1_Img_link { get; set; }
        public int recommended_product_2_Name { get; set; }
        public int recommended_product_2_Year { get; set; }
        public int Recommended_Product_2_Price { get; set; }
        public int recommended_product_2_Img_link { get; set; }
        public int recommended_product_3_Name { get; set; }
        public int recommended_product_3_Year { get; set; }
        public int Recommended_Product_3_Price { get; set; }
        public int recommended_product_3_Img_link { get; set; }
        public int recommended_product_4_Name { get; set; }
        public int recommended_product_4_Year { get; set; }
        public int Recommended_Product_4_Price { get; set; }
        public int recommended_product_4_Img_link { get; set; }

    }
}