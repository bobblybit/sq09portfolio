using AutoMapper;
using portfolio.Data.Dto;
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

            CreateMap<User, UserToReturn>().ReverseMap();
            //CreateMap<Skill, SkillToReturnDto>().ReverseMap();
            //CreateMap<WorkHistory, WorkHistoryToReturnDto>().ReverseMap();
            //CreateMap<EducationHistory, EducationHistoryToReturnDto>().ReverseMap();
            //CreateMap<Project, ProjectToReturnDto>().ReverseMap();
        }
    }
}
