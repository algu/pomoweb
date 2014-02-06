using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using pomoweb.Domain.Entities;
using pomoweb.ViewModels;

namespace pomoweb.Models
{
    public class PomowebMapperProfile : Profile
    {
        protected override void Configure()
        {

            //create all maps
            CreateMap<Pomodoro, PomoFull>();


        }
    }
}