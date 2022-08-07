using System;
using AutoMapper;
using Entrant.Domain.Entities;
using Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos;

namespace Entrant.API.Application.Contracts.Profiles.EntrantAccountProfiles
{
    public class EntrantAccountProfile : Profile
    {
        public EntrantAccountProfile()
        {
            CreateMap<EntrantAccount, EntrantAccountReadDto>();
            CreateMap<EntrantAccountReadDto, EntrantAccount>();
            CreateMap<EntrantAccountUpdateDto, EntrantAccount>();
        }
    }
}
