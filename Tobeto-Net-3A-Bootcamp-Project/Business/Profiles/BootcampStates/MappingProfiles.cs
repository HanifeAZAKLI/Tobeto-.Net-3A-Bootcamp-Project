﻿using AutoMapper;
using Business.Requests.Bootcamps;
using Business.Requests.BootcampStates;
using Business.Responses.BootcampStates;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.BootcampStates
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<BootcampState, CreateBootcampStateRequest>().ReverseMap();
            CreateMap<BootcampState, DeleteBootcampStateRequest>().ReverseMap();
            CreateMap<BootcampState, UpdateBootcampStateRequest>().ReverseMap();

            CreateMap<BootcampState, GetAllBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, CreateBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, DeleteBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, GetByIdBootcampStateResponse>().ReverseMap();
            CreateMap<BootcampState, UpdateBootcampStateResponse>().ReverseMap();
        }
    }
}
