
using Microsoft.AspNetCore.Mvc;
namespace dotnet_rpg.Controllers{
    [ApiController]
    [Route("api/[controller]")]

    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character> {
        new Character {Id = 342},
        new Character { Id=123, Name ="Sam"}
        };
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        [HttpGet]
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }

        [HttpGet("GetByID")]
        public ActionResult<Character> GetByIDe(int id)
        {
            return Ok(characters.Where(x => x.Id == id));
        }
        [HttpPost]
        public ActionResult<List<Character>> AddNew(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }

    }

    
    
}
