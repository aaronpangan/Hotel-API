using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hotel_API.Dto;
using Hotel_API.DTO;
using Hotel_API.Model;

namespace Hotel_API.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<CountryModel, CountryDTO>().ReverseMap();

            CreateMap<CountryModel, CreateCountryDTO>().ReverseMap();

            CreateMap<HotelModel, HotelDTO>().ReverseMap();

            CreateMap<HotelModel, CreateHotelDTO>().ReverseMap();
        }
    }
}