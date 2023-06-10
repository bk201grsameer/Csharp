using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using projectEf_1.Dtos.Character;
using projectEf_1.models;

namespace projectEf_1.Services.CharacterService
{


    public class CharacterService : ICharacterService
    {
        public readonly IMapper Mapper;
        public CharacterService(IMapper mapper)
        {
            // injecting mapper
            this.Mapper = mapper;

        }
        public static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id=1,Name="Sam"},
            new Character{Id=2,Name="pali"}
        };
        public async Task<ServiceResponse<List<GetCharacterDtos>>> add_Character(AddCharacterDtos obj)
        {
            characters.Add(this.Mapper.Map<Character>(obj));
            var res = new ServiceResponse<List<GetCharacterDtos>>();
            res.Data = characters.Select(c => this.Mapper.Map<GetCharacterDtos>(c)).ToList();
            return res;
        }

        public async Task<ServiceResponse<List<GetCharacterDtos>>> get_All_Character()
        {
            var res = new ServiceResponse<List<GetCharacterDtos>>();
            res.Data = characters.Select(c => this.Mapper.Map<GetCharacterDtos>(c)).ToList();
            return res;
        }

        public async Task<ServiceResponse<GetCharacterDtos?>> get_Character_By_Id(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            var res = new ServiceResponse<GetCharacterDtos>();
            //c# auto mapping
            res.Data = this.Mapper.Map<GetCharacterDtos>(character);
            return res;
        }
    }
}