using Atyon.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atyon.Core.Repositories;
using Atyon.Data.Repositories;

namespace Atyon.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AtyonDataContext _context;
        private FacilityRepository _facilityRepository;
        private CompanyRepository _companyRepository;
        private ManufactureRepository _manufactureRepository;
        private WasteStockRepository _wasteStockRepository;

        public UnitOfWork(AtyonDataContext context)
        {
            this._context = context;
        }

        public IFacilityRepository Facilities => _facilityRepository = _facilityRepository ?? new FacilityRepository(_context);

        public ICompanyRepository Companies => _companyRepository = _companyRepository ?? new CompanyRepository(_context);
        public IManufactureRepository Manufactures => _manufactureRepository = _manufactureRepository ?? new ManufactureRepository(_context);
        public IWasteStockRepository WasteStocks => _wasteStockRepository = _wasteStockRepository ?? new WasteStockRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
