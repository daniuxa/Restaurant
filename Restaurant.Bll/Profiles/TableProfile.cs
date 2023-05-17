using AutoMapper;
using Restaurant.Dal.Entities;
using Restaurant.Bll.Models.TableDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class TableProfile : Profile
    {
        public TableProfile()
        {
            CreateMap<TableForCreationDTO, Table>();
            CreateMap<Table, TableDTO>()
                .ForMember(destination => destination.Description, 
                member => member.MapFrom(source => "Table Number " + source.TableNumber + " for " + source.AmountOfPlaces + "persons"));
        }
    }
}
