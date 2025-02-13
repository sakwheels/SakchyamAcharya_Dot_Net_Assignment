using System.ComponentModel.DataAnnotations;

namespace SakchyamAcharya1_Dot_Net_Assignment.Models
{
    public class OrderPlease
    {
        [Key] // This specifies the primary key
        public int Id { get; set; } // Primary key property

        [Required]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
