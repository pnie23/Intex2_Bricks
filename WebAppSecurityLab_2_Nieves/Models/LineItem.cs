using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex2_Bricks.Models
{
    public class LineItem
    {
        [ForeignKey("TransactionId")]
        [Required]
        public int transaction_Id { get; set; }
        public Order? Order { get; set; }
        [ForeignKey("ProductId")]
        [Required]
        public int? product_Id { get; set; }
        public Product? Product { get; set; }
        public int qty { get; set; }
        public int? rating { get; set; }
    }
}
