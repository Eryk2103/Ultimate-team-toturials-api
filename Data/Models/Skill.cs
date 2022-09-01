using System.ComponentModel.DataAnnotations;

namespace UltimateTeamApi.Data.Models
{
    public class Skill
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Stars { get; set; }
        [Required]
        public string? Gif { get; set; }
        [Required]
        public string? XboxControls{ get; set; }
        [Required]
        public string? PlaystationControls { get; set; }
        [Required]
        public string? Dificulty { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
