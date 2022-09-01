namespace UltimateTeamApi.Data.Dtos
{
    public class SkillDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Stars { get; set; }
        public string? Gif { get; set; }

        public string? XboxControls { get; set; }
        public string? PlaystationControls { get; set; }

        public string? Dificulty { get; set; }
    }
}
