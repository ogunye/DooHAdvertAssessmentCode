using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DooHAdvertAPI.Models
{
    public class Adverts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Path { get; set; }

        [MaxLength(200)]
        public string? CityName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }


        [Range(1, 10)]
        public int Priority { get; set; }

           
    }
}
