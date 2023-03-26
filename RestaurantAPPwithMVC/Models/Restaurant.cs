using System.ComponentModel.DataAnnotations;

namespace RestaurantAPPwithMVC.Models
{
    public class Restaurant
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;


    }
}
