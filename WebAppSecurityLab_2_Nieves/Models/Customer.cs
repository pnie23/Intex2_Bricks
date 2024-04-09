using System.ComponentModel.DataAnnotations;

namespace Intex2_Bricks.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int customer_Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateOnly birth_date { get; set; }
        public string country_of_residence {get; set; }
        public string? gender { get; set; }
        public int age { get; set; }
    }
}
