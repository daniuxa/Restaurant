using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Restaurant.Bll.Models.WineDTOs;
using Restaurant.Dal.Entities;

namespace Restaurant.Bll.Profiles
{
    public class WineProfile : Profile
    {
        public WineProfile()
        {
            CreateMap<Wine, WineForListDTO>();
            CreateMap<Wine, WineDetailInfoDTO>();
            CreateMap<WineCreationDTO, Wine>();

        }
    }
}
