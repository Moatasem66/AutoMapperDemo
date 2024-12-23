using AutoMapper;
using AutoMapperDemo.DTOs;
using AutoMapperDemo.Entities;

namespace AutoMapperDemo.Mappings;

public class CustomerMapping : Profile
{
    public CustomerMapping()
    {
        CreateMap<Customer ,CustomerResponseDTO>();

        CreateMap<CustomerRequestDTO, Customer>()
            .ForMember(dest => dest.Name , opt => opt.MapFrom (src => $"{ src.Name} {src.Email}"));
            
    }
}
