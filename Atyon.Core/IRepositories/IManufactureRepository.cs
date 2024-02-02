using Atyon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Repositories
{
    public interface IManufactureRepository : IRepository<Manufacture>
    {
        Task<IEnumerable<Manufacture>> GetAllWtithFacilitiesAsync();
        Task<Manufacture> GetWithFacilitiesByCodeAsync(int code);
    }
}
