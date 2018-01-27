using System.ComponentModel.DataAnnotations;

namespace BlueCafe.Core
{
    public class Beverage
    {
        public int BeverageId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
}