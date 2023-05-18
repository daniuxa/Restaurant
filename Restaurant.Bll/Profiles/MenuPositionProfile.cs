using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Restaurant.Bll.Models.MenuPositionDTOs;
using Restaurant.Dal.Entities;

namespace Restaurant.Bll.Profiles
{
    public class MenuPositionProfile : Profile
    {
        public MenuPositionProfile()
        {
            CreateMap<MenuPosition, MenuPositionForListDTO>();
            CreateMap<MenuPositionCreationDTO, MenuPosition>();
            CreateMap<MenuPosition, MenuPositionDTO>();
            CreateMap<MenuPositionDTO, MenuPosition>();
        }
    }
}
