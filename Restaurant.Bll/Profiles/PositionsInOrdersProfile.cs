using AutoMapper;
using Restaurant.Bll.Models.PositionsInOrders;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class PositionsInOrdersProfile : Profile
    {
        public PositionsInOrdersProfile()
        {
            CreateMap<PositionsInOrdersForCreationDTO, PositionInOrder>();
            CreateMap<PositionInOrder, PositionInOrderDTO>();
            CreateMap<PositionInOrder, PositionInOrderDTO>().ReverseMap();

        }
    }
}
