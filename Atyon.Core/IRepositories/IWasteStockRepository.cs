using Atyon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Repositories
{
     public interface IWasteStockRepository : IRepository<WasteStock>
    {
        Task<IEnumerable<WasteStock>> GetAllWtithFacilitiesAsync();
        Task<WasteStock> GetWithFacilitiesByCodeAsync(int code);
    }
}
