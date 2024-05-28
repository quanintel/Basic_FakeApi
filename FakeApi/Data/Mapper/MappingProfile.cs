using AutoMapper;
using FakeApi.Data.Dtos;
using FakeApi.Data.Entities;

namespace FakeApi.Data.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Hospital, HospitalDto>().ReverseMap();
        CreateMap<Warehouse, WarehouseDto>().ReverseMap();
        CreateMap<Company, CompanyDto>().ReverseMap();
        CreateMap<MomentType, MomentTypeDto>().ReverseMap();
        CreateMap<WarehouseProduct, WarehouseProductDto>().ReverseMap();
        CreateMap<WarehouseInput, WarehouseInputDto>().ReverseMap();
        CreateMap<WarehouseTransactionHistory, WarehouseTransactionHistoryDto>().ReverseMap();
        CreateMap<Unit, UnitDto>().ReverseMap();
    }
}