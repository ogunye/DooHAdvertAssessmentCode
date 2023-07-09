using System.ComponentModel.DataAnnotations;

namespace DooHAdvertAPI.Models.DTO
{
    public class CityForCreatioDto
    {
        [Required]
        public string? Name { get; set; }
    }
}
