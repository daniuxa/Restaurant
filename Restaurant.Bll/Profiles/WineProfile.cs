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
            CreateMap<Wine, WineForListDTO>()
                .ForMember(destinationMember => destinationMember.Country,
                memberOptions => memberOptions.MapFrom(sourceMembersPath => sourceMembersPath.Region.Country))
                .ForMember(destinationMember => destinationMember.RegionName,
                memberOptions => memberOptions.MapFrom(sourceMembersPath => sourceMembersPath.Region.RegionName));
        }
    }
}
