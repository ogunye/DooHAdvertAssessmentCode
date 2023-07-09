using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DooHAdvertAPI.Models
{
    [Table("City")]
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        public List<Adverts>? Adverts { get; set; }
    }
}
