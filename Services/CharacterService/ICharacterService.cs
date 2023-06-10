using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectEf_1.Dtos.Character;

namespace projectEf_1.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDtos>>> get_All_Character();
        Task<ServiceResponse<GetCharacterDtos?>> get_Character_By_Id(int id);
        Task<ServiceResponse<List<GetCharacterDtos>>> add_Character(AddCharacterDtos obj);
    }
}