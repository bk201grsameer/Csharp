using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectEf_1.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> get_All_Character();
        Character? get_Character_By_Id(int id);
        List<Character> add_Character(Character obj);        
    }
}