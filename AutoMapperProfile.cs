using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using projectEf_1.Dtos.Character;

namespace projectEf_1
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDtos>();
            CreateMap<AddCharacterDtos, Character>();
        }
    }
}