using System.ComponentModel.DataAnnotations;

namespace GamePlatformService.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public double Cost { get; set; }
    }
}
