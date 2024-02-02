using Atyon.Core.Models;
using Atyon.DTO;
using AutoMapper;
using City = Atyon.DTO.City;
using Company = Atyon.DTO.Company;
using Facility = Atyon.DTO.Facility;
using FacilityQualificationType = Atyon.DTO.FacilityQualificationType;
using FacilityType = Atyon.DTO.FacilityType;
using Manufacture = Atyon.DTO.Manufacture;
using Product = Atyon.DTO.Product;
using Town = Atyon.DTO.Town;
using Waste = Atyon.DTO.Waste;
using WasteStock = Atyon.DTO.WasteStock;
using WasteType = Atyon.DTO.WasteType;

namespace Atyon.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Resource to Domain
            CreateMap<City, CityDTO>();
            CreateMap<Company, CompanyDTO>();
            CreateMap<Facility, FacilityDTO>();
            CreateMap<FacilityQualificationType, FacilityQualificationTypeDTO>();
            CreateMap<FacilityType, FacilityTypeDTO>();
            CreateMap<Manufacture, ManufactureDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Town, TownDTO>();
            CreateMap<Waste, WasteDTO>();
            CreateMap<WasteStock, WasteStockDTO>();
            CreateMap<WasteType, WasteTypeDTO>();

            // Domain to Resource
            CreateMap<CityDTO, City>();
            CreateMap<CompanyDTO, Company>();
            CreateMap<FacilityDTO, Facility>();
            CreateMap<FacilityQualificationTypeDTO, FacilityQualificationType>();
            CreateMap<FacilityTypeDTO, FacilityType>();
            CreateMap<ManufactureDTO, Manufacture>();
            CreateMap<ProductDTO, Product>();
            CreateMap<TownDTO, Town>();
            CreateMap<WasteDTO, Waste>();
            CreateMap<WasteStockDTO, WasteStock>();
            CreateMap<WasteTypeDTO, WasteType>();
        }
    }
}
