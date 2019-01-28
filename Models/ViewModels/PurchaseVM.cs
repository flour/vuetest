using System.ComponentModel.DataAnnotations;

namespace testvue.Models.ViewModels
{
    public class PurchaseVM
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}