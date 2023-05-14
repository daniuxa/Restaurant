﻿using AutoMapper;
using Restaurant.Bll.Models.DishDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class DishProfile : Profile
    {
        public DishProfile()
        {
            CreateMap<Dish, DishForListDTO>();
            CreateMap<Dish, DishDetailInfoDTO>();
            CreateMap<DishCreationDTO, Dish>();
            //CreateMap<KeyValuePair<string, IEnumerable<Dish>>, DishDictionaryDTO>()
            //    .ForMember(destination => destination.TypeOfDish, member => member.MapFrom(source => source.Key))
            //    .ForMember(destination => destination.Dishes, member => member.MapFrom(source => source.Value));
        }
    }
}
