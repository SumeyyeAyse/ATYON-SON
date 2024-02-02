using Atyon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Services
{
    public interface IFacilityService
    {
        Task<IEnumerable<Facility>> GetAll();


        Task<Facility> CreateFacility(Facility newFacility);
        Task UpdateFacility(Facility facilityToBeUpdated, Facility facility);
        Task DeleteFacility(Facility facility);


        Task<Facility> GetWithWasteStockByCodeAsync(int code);
        Task<IEnumerable<Facility>> GetFacilityWithWasteStockByWasteStockCodeAsync(int id, int WasteStockCode);



        Task<Facility> GetWithCompanyByCodeAsync(int code);
        Task<IEnumerable<Facility>> GetAllWithCompanyByCompanyCodeAsync(int CompanyCode);



        Task<Facility> GetWithManufacturekByCodeAsync(int code);
        Task<IEnumerable<Facility>> GetAllWithManufactureByManufactureCodeAsync(int ManufactureCode);
    }
}
