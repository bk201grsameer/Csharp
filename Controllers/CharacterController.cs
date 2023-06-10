using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectEf_1.Services.CharacterService;

namespace projectEf_1.Controllers
{
    // to make it controller
    [ApiController]
    [Route("api/[controller]")] //api/CharacterController
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService characterService;

        public CharacterController(ICharacterService characterService)
        {
            //character service injected inside the CharacterController 
            this.characterService = characterService;
        }


        //routes
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characterService.get_All_Character());
        }

        //get with parameter //via url
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) //this will work as the parameter
        {
            return Ok(characterService.get_Character_By_Id(id));
        }


        //via body
        [HttpPost]
        [Route("adduser")]
        public ActionResult<List<Character>> AddCharacter(Character obj) //the body will be 
        {
            return Ok(characterService.add_Character(obj));
        }

    }
}