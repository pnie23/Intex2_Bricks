using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Intex2_Bricks.Models
{
    [PrimaryKey(nameof(customer_Id))]
    public class UBRecommendation
    {
        public int? customer_Id { get; set; }
        public Customer? Customer { get; set; }
        public int recommended_product_1 { get; set; }
        public int recommended_product_2 { get; set; }
        public int recommended_product_3 { get; set; }
        public int recommended_product_4 { get; set; }
    }
}
