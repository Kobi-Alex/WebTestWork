using System;
using AutoMapper;
using Entrant.Domain.Entities;
using Entrant.API.Application.Contracts.Dtos.EntrantIncedentDtos;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;

namespace Entrant.API.Application.Contracts.Profiles.EntrantIncedentProfiles
{
    public class EntrantIncedentProfile : Profile
    {
        public EntrantIncedentProfile()
        {
            CreateMap<EntrantIncedent, EntrantIncedentReadDto>();
            CreateMap<EntrantIncedentReadDto, EntrantIncedent>();
            CreateMap<EntrantIncedentUpdateDto, EntrantIncedent>();
            CreateMap<EntrantIncedent, EntrantContactCreateDto>();
            CreateMap<EntrantContactCreateDto, EntrantIncedent>();
        }
    }
}
