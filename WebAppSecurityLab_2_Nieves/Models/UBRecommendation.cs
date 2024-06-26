﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex2_Bricks.Models
{
    public class UBRecommendation
    {
        [Key]
        public int? customer_Id { get; set; }
        [ForeignKey("customer_Id")]
        public Customer? Customer { get; set; }
        public string Recommended_Product_1_Name { get; set; }
        public int Recommended_Product_1_Year { get; set; }
        public int Recommended_Product_1_Price { get; set; }
        public string Recommended_Product_1_Img_Link { get; set; }
        public string Recommended_Product_2_Name { get; set; }
        public int Recommended_Product_2_Year { get; set; }
        public int Recommended_Product_2_Price { get; set; }
        public string Recommended_Product_2_Img_Link { get; set; }
        public string Recommended_Product_3_Name { get; set; }
        public int Recommended_Product_3_Year { get; set; }
        public int Recommended_Product_3_Price { get; set; }
        public string Recommended_Product_3_Img_Link { get; set; }
        public string Recommended_Product_4_Name { get; set; }
        public int Recommended_Product_4_Year { get; set; }
        public int Recommended_Product_4_Price { get; set; }
        public string Recommended_Product_4_Img_Link { get; set; }
    }
}
