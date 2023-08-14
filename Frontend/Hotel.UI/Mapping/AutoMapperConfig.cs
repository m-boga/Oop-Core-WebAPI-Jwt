using AutoMapper;
using Hotel.EntityLayer.Concrete;
using Hotel.UI.Dtos.RegisterDto;
using Hotel.UI.Dtos.ServiceDto;

namespace Hotel.UI.Mapping
{
    public class AutoMapperConfig :Profile  
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
        }
    }
}
