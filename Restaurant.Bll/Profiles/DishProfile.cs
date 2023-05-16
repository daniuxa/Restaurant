using AutoMapper;
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
            CreateMap<Dish, DishForUpdateDTO>();
            CreateMap<DishForUpdateDTO, Dish>();

        }
    }
}
