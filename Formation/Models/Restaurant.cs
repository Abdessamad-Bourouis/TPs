using System.ComponentModel.DataAnnotations;

namespace Formation.Models
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Description { get; set; } = string.Empty;


    }
}
