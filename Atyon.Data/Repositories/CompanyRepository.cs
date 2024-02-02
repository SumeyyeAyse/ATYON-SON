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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(AtyonDataContext context)
            :base(context)
            { }

        public async Task<IEnumerable<Company>> GetAllWtithFacilitiesAsync()
        {
            return await AtyonDataContext.Companies
                .Include(a => a.CompanyCodeNavigation)
                .ToListAsync();
        }


        public Task<Company> GetWithFacilitiesByCodeAsync(int code)
        {
            return AtyonDataContext.Companies
                .Include(a => a.CompanyCodeNavigation)
                .SingleOrDefaultAsync(a => a.CompanyCode == code);
        }

        private AtyonDataContext AtyonDataContext
        {
            get { return Context as AtyonDataContext; }
        }
    }
}
