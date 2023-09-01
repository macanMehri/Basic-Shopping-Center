using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Cost { get; set; }    
        public int Amount { get; set; }
        public string? Brand { get; set; }
        public string? Category { get; set; }   
    }
}
