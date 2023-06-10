using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace projectEf_1.Controllers
{
    // to make it controller
    [ApiController]
    [Route("api/[controller]")] //api/CharacterController
    public class CharacterController : ControllerBase
    {
        public static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id=1,Name="Sam"},
            new Character{Id=2,Name="pali"}
        };

        //routes
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        //get with parameter //via url
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) //this will work as the parameter
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }


        //via body
        [HttpPost]
        [Route("adduser")]
        public ActionResult<List<Character>> AddCharacter(Character obj) //the body will be 
        {
            characters.Add(obj);
            return Ok(characters);
        }
        
    }
}