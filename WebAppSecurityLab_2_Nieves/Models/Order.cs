using System.ComponentModel.DataAnnotations;

namespace Intex2_Bricks.Models
{
    public class Order
    {
        [Key]
        public int transaction_Id { get; set; }
        public int customer_Id  { get; set; }
        public DateOnly date { get; set; }
        public string day_of_week { get; set; }
        public int time { get; set; }
        public string entry_made { get; set; }
        public int amount { get; set; }
        public string type_of_transaction { get; set; }
        public string country_of_transaction { get; set; }
        public string shipping_address { get; set; }
        public string bank { get; set; }
        public string type_of_card { get; set; }
        public bool fraud { get; set; }
        public bool fulfilled { get; set; }
    }
}
