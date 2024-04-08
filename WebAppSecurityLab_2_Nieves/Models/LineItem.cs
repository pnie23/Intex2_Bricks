using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex2_Bricks.Models
{
    public class LineItem
    {
        [Key]
        public int transaction_Id { get; set; }
        [Key]
        public int product_Id { get; set; }
        public int qty { get; set; }
        public int? rating { get; set; }
    }
}
