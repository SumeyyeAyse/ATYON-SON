using Atyon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Repositories
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        Task<IEnumerable<Facility>> GetAllAsync();
        Task<Facility> GetWithWasteStockByCodeAsync(int code);
        Task<IEnumerable<Facility>> GetAllWithWasteStockByWasteStockCodeAsync(int WasteStockCode);

        Task<Facility> GetWithCompanyByCodeAsync(int code);
        Task<IEnumerable<Facility>> GetAllWithCompanyByCompanyCodeAsync(int CompanyCode);

        Task<Facility> GetWithManufacturekByCodeAsync(int code);
        Task<IEnumerable<Facility>> GetAllWithManufactureByManufactureCodeAsync(int ManufactureCode);
        Task<Facility> GetFacilityWithWasteStockByWasteStockCodeAsync(int v, object wasteStockCode);
    }
}
