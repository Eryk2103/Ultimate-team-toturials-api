using AutoMapper;
using UltimateTeamApi.Data.Dtos;
using UltimateTeamApi.Data.Models;

namespace UltimateTeamApi.Data
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Skill, SkillDto>();
            CreateMap<SkillDto, Skill>();
            
        }
    }
}
