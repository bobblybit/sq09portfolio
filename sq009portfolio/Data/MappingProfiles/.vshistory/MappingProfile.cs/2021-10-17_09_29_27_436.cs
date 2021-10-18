using AutoMapper;
using portfolio.Data.Dto;
using portfolio.Data.Models;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.MappingProfiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<AppUser, UserToReturnDTO>().ReverseMap();
            CreateMap<Skill, SkillToReturnDTO>().ReverseMap();
            CreateMap<Contact, ContactToReturnDTO>().ReverseMap();
            CreateMap<Projects, ProjectToReturnDTO>().ReverseMap();
        }
    }
}
