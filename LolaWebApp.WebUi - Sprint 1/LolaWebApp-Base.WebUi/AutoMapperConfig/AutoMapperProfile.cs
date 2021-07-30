using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LolaApp.Entities;
using LolaWebApp_Base.WebUi.Models;

namespace LolaWebApp_Base.WebUi.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}