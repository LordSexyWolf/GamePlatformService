using System.ComponentModel.DataAnnotations;

namespace GamePlatformService.Dtos
{
    public class PlatformReadDtos
    {
        
        public int Id { get; set; }
        public String Name { get; set; }
        public string Publisher { get; set; }
        public double Cost { get; set; }
    }
}
