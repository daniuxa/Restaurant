using AutoMapper;
using Restaurant.Bll.Models.ClientDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDTO>();
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<ClientForCreationDTO, Client>()
                .ForMember(destination => destination.FirstName, 
                member => member.MapFrom(source => ParserOfName.ParseForNameSurname(source.Name, ParserOfName.NameOrSurname.Name)))
                .ForMember(destination => destination.LastName, 
                member => member.MapFrom(source => ParserOfName.ParseForNameSurname(source.Name, ParserOfName.NameOrSurname.Surname)));
        }
    }
}
