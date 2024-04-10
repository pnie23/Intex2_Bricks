using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Intex2_Bricks.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int transaction_Id { get; set; }
        [BindNever]
        public ICollection<Cart.CartLine> Lines { get; set; } = new List<Cart.CartLine>();
        public int? customer_Id  { get; set; }
        [ForeignKey("customer_Id")]
        public Customer? Customer { get; set; }
        public string date { get; set; }
        public string day_of_week { get; set; }
        public int time { get; set; }
        public string entry_mode { get; set; }
        public int? amount { get; set; }
        public string type_of_transaction { get; set; }
        public string country_of_transaction { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        public string? shipping_address { get; set; }
        public string bank { get; set; }
        public string type_of_card { get; set; }
        public bool fraud { get; set; }
        public bool fulfilled { get; set; }
    }
}
