using Atyon.Core.Models;
using Atyon.Core.Repositories;
using Atyon.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Atyon.Data.Repositories
{
    public class FacilityRepository : Repository<Facility> , IFacilityRepository
    {
        public FacilityRepository(AtyonDataContext context)
             : base(context)
        { }

        public async Task<IEnumerable<Facility>> GetAllAsync()
        {
            return await AtyonDataContext.Facilities
                .ToListAsync();
        }

        public async Task<Facility> GetWithWasteStockByCodeAsync(int code)
        {
            return await AtyonDataContext.Facilities
                .Include(a => a.WasteStocks)
                .SingleOrDefaultAsync(a => a.WasteStockCode == code);
        }

        public async Task<IEnumerable<Facility>> GetAllWithWasteStockByWasteStockCodeAsync(int WasteStockCode)
        {
            return await AtyonDataContext.Facilities
                .Include(a => a.WasteStocks)
                .Where(a => a.WasteStockCode == WasteStockCode)
                .ToListAsync();
        }

        public async Task<Facility> GetWithCompanyByCodeAsync(int code)
        {
            return await AtyonDataContext.Facilities
                .Include(a => a.Companies)
                .SingleOrDefaultAsync(a => a.CompanyCode == code);
        }

        public async Task<IEnumerable<Facility>> GetAllWithCompanyByCompanyCodeAsync(int CompanyCode)
        {
            return await AtyonDataContext.Facilities
                .Include(a => a.Companies)
                .Where(a => a.CompanyCode == CompanyCode)
                .ToListAsync();
        }

        public async Task<Facility> GetWithManufacturekByCodeAsync(int code)
        {
            return await AtyonDataContext.Facilities
                .Include(a => a.Manufactures)
                .SingleOrDefaultAsync(a => a.ManufactureCode == code);
        }

        public async Task<IEnumerable<Facility>> GetAllWithManufactureByManufactureCodeAsync(int ManufactureCode)
        {
            return await AtyonDataContext.Facilities
                .Include(a => a.Manufactures)
                .Where(a => a.ManufactureCode == ManufactureCode)
                .ToListAsync();
        }

        private AtyonDataContext AtyonDataContext
        {
            get { return Context as AtyonDataContext; }
        }
    }
}
