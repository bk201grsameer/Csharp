using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectEf_1.Dtos.Character;
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
        public async Task<ServiceResponse<List<GetCharacterDtos>>> Get()
        {
            return await characterService.get_All_Character();
        }

        //get with parameter //via url
        [HttpGet("{id}")]
        public async Task<ServiceResponse<GetCharacterDtos?>> GetSingle(int id) //this will work as the parameter
        {
            return await (characterService.get_Character_By_Id(id));
        }


        //via body
        [HttpPost]
        [Route("adduser")]
        public async Task<ServiceResponse<List<GetCharacterDtos>>> AddCharacter(AddCharacterDtos obj) //the body will be 
        {
            return await (characterService.add_Character(obj));
        }

    }
}