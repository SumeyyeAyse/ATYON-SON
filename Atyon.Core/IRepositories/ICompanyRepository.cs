using Atyon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<IEnumerable<Company>> GetAllWtithFacilitiesAsync();
        Task<Company> GetWithFacilitiesByCodeAsync(int code);
    }
}
