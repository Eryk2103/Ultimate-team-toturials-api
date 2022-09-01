using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using UltimateTeamApi.Data;
using UltimateTeamApi.Data.Dtos;
using UltimateTeamApi.Data.Models;

namespace UltimateTeamApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SkillController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /*
        [HttpGet]
        public async Task<ActionResult<Result<SkillDto>>> GetAllSkills(int pageIndex = 0, int pageSize = 10, int? starsFilter = null, string? dificulty = null)
        {
            var skillsCtx = _context.Skills.Select(s => new SkillDto
            {
                Id = s.Id,
                Name = s.Name,
                Stars = s.Stars,
                Dificulty = s.Dificulty,
                XboxControlsImgUrl = s.XboxControlsImgUrl,
                PlaystationControlsImgUrl = s.PlaystationControlsImgUrl,
                VideoUrl = s.VideoUrl
            });
            if (starsFilter > 0 && starsFilter <= 6)
            {
                skillsCtx = skillsCtx.Where(s => s.Stars == starsFilter);
            }
            if (dificulty != null)
            {
                if (dificulty.ToLower() == "easy" || dificulty.ToLower() == "medium" || dificulty.ToLower() == "hard")
                {
                    skillsCtx = skillsCtx.Where(s => s.Dificulty == dificulty);
                }
            }
            var skills = await Result<SkillDto>.CreateAsync(pageIndex, pageSize, skillsCtx);

            return Ok(skills);

        }
        */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillDto>>> GetAllSkills()
        {
            var skills = await _context.Skills.Include(s=>s.Tags).ToListAsync();
            return Ok(_mapper.Map<IEnumerable<SkillDto>>(skills));
        }
            [HttpGet("{id}", Name = "GetSkillById")]
        public async Task<ActionResult<SkillDto>> GetSkillById(int id)
        {
            var skill = await _context.Skills
               .FirstOrDefaultAsync(m => m.Id == id);

            if (skill != null)
            {
                return Ok(_mapper.Map<SkillDto>(skill));
            }
            return NotFound();
        }
        
    }
}

