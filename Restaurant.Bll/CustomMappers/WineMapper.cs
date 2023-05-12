using AutoMapper;
using Restaurant.Bll.Models.WineDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.CustomMappers
{
    public static class WineMapper
    {
        public static IDictionary<string, IEnumerable<WineForListDTO>> MapDictionary(IMapper _mapper, IDictionary<string, IEnumerable<Wine>> notMappedDictionary)
        {
            IDictionary<string, IEnumerable<WineForListDTO>> mappedDictionary = new Dictionary<string, IEnumerable<WineForListDTO>>();
            foreach (var notMapped in notMappedDictionary)
            {
                mappedDictionary.Add(notMapped.Key, _mapper.Map<IEnumerable<WineForListDTO>>(notMapped.Value));
            }
            return mappedDictionary;
        }
    }
}
