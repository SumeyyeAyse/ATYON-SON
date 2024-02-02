using Atyon.Core.Models;
using Atyon.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Data.Repositories
{
    public class ManufactureRepository : Repository<Manufacture>, IManufactureRepository
    {
        public ManufactureRepository(AtyonDataContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Manufacture>> GetAllWtithFacilitiesAsync()
        {
            return await AtyonDataContext.Manufactures
                .Include(a => a.ManufactureCodeNavigation)
                .ToListAsync();
        }


        public Task<Manufacture> GetWithFacilitiesByCodeAsync(int code)
        {
            return AtyonDataContext.Manufactures
                .Include(a => a.ManufactureCodeNavigation)
                .SingleOrDefaultAsync(a => a.ManufactureCode == code);
        }

        private AtyonDataContext AtyonDataContext
        {
            get { return Context as AtyonDataContext; }
        }
    }
}
