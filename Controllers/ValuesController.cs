using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using signin_for.Model;
using signin_forAPI.Data;
using EntityFramework7Relationships.DTOs;

namespace signin_for.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ValuesController (ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetBagpacks()
        {
            return Ok(_context.Bagpacks);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterById(int id)
        {
            var character = await _context.Characters
                .Include(c => c.Bagpack)
                .Include(c => c.Weapons)
                .Include(c => c.Factions)
                .FirstOrDefaultAsync(c=>c.Id== id);
            return Ok(character);

        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDto request)
        {
            var newCharacter = new Character
            {
                Name = request.Name,
            };

            var bagpack = new Bagpack { Description = request.Bagpack.Description, Character = newCharacter };
            var weapon = request.Weapons.Select(w => new Weapon { Name = w.Name, Character = newCharacter }).ToList();
            var faction = request.Factions.Select(f => new Faction { Name = f.Name, Characters = new List<Character> { newCharacter } }).ToList();

            newCharacter.Bagpack = bagpack;
            newCharacter.Weapons = weapon;
            newCharacter.Factions = faction;


            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();
            return Ok(await _context.Characters.Include(c=>c.Bagpack).Include(c => c.Weapons).ToListAsync());
        }



    }
}
