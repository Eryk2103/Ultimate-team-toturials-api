using System.ComponentModel.DataAnnotations;

namespace UltimateTeamApi.Data.Models
{
    public class Tag
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? HexColor { get; set; }

        public ICollection<Skill> Skill { get; set; }
    }
}
