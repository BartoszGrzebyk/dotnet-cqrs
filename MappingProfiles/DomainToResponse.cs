using AutoMapper;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Models;

namespace dotnet_cqrs.MappingProfiles;

public class DomainToResponse : Profile
{
   public DomainToResponse()
	 {
			CreateMap<Item, ItemDto>();
	 }
}