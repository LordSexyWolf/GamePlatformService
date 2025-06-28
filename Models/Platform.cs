using System.ComponentModel.DataAnnotations;

namespace GamePlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public double Cost { get; set; }
    }
}
