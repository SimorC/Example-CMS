using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CMS_Domain.Entity;
using Example_CMS.ViewModel;
using Profile = AutoMapper.Profile;

namespace Example_CMS.AutoMapperConfig
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            // Base
            CreateMap<EntityBase, EntityBaseViewModel>().ReverseMap();

            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}