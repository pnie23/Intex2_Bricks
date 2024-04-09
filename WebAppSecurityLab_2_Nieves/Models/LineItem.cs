using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex2_Bricks.Models
{
    [PrimaryKey(nameof(transaction_Id), nameof(product_Id))]
    public class LineItem
    {
        public int transaction_Id { get; set; }
        public Order? Order { get; set; }
        public int? product_Id { get; set; }
        public Product? Product { get; set; }
        public int qty { get; set; }
        public int? rating { get; set; }
    }
}
