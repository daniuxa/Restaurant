using AutoMapper;
using Restaurant.Bll.Models.DrinkDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class DrinkProfile : Profile
    {
        public DrinkProfile()
        {
            CreateMap<Drink, DrinkForListDTO>();
            CreateMap<Drink, DrinkDetailInfoDTO>();
            CreateMap<DrinkCreationDTO, Drink>();
        }
    }
}
