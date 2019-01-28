using System.ComponentModel.DataAnnotations;

namespace testvue.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}