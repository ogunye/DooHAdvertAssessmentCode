using System.ComponentModel.DataAnnotations;

namespace DooHAdvertWebApp.Models
{
    public class AdvertBillBoard
    {
        public int Id { get; set; }        
        public string? Path { get; set; }
        public string? CityName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Priority { get; set; }
    }
}
