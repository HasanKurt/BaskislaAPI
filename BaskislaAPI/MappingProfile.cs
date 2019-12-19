using AutoMapper;
using Entities.Models;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaskislaAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<PersonForCreationDTO, Person>();
            CreateMap<PersonForUpdateDto, Person>();

        }
    }
}
