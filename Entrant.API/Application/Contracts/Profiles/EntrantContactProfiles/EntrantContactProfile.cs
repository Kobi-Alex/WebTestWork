using System;
using AutoMapper;
using Entrant.Domain.Entities;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;

namespace Entrant.API.Application.Contracts.Profiles.EntrantContactProfiles
{
    public class EntrantContactProfile : Profile
    {
        public EntrantContactProfile()
        {
            CreateMap<EntrantContact, EntrantContactReadDto>();
            CreateMap<EntrantContactReadDto, EntrantContact>();
            CreateMap<EntrantContactUpdateDto, EntrantContact>();
        }
    }
}