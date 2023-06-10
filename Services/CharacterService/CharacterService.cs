using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectEf_1.models;

namespace projectEf_1.Services.CharacterService
{


    public class CharacterService : ICharacterService
    {
        public static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id=1,Name="Sam"},
            new Character{Id=2,Name="pali"}
        };
        public List<Character> add_Character(Character obj)
        {
            characters.Add(obj);
            return characters;
        }

        public List<Character> get_All_Character()
        {
            return characters;
        }

        public Character? get_Character_By_Id(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}