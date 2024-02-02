using Atyon.Core.Models;
using Atyon.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Atyon.Data.Repositories
{
    public class WasteStockRepository : Repository<WasteStock>, IWasteStockRepository
    {
        public WasteStockRepository(AtyonDataContext context)
            : base(context)
        { }

        public async Task<IEnumerable<WasteStock>> GetAllWtithFacilitiesAsync()
        {
            return await AtyonDataContext.WasteStocks
                .Include(a => a.WasteStockCodeNavigation)
                .ToListAsync();
        }


        public Task<WasteStock> GetWithFacilitiesByCodeAsync(int code)
        {
            return AtyonDataContext.WasteStocks
                .Include(a => a.WasteStockCodeNavigation)
                .SingleOrDefaultAsync(a => a.WasteStockCode == code);
        }

        private AtyonDataContext AtyonDataContext
        {
            get { return Context as AtyonDataContext; }
        }
    }