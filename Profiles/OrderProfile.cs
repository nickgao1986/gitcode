using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XieChengAPI.Dtos;
using XieChengAPI.Models;

namespace XieChengAPI.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(
                    dest => dest.State,
                    opt =>
                    {
                        opt.MapFrom(src => src.State.ToString());
                    }
                );
        }
    }
}
