using Atyon.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core
{
    public interface IUnitOfWork : IDisposable
    {
        
        ICompanyRepository Companies { get; }
        
        IFacilityRepository Facilities { get; }
        IManufactureRepository Manufactures { get; }
        IWasteStockRepository WasteStocks { get; }
        Task<int> CommitAsync();
    }
}
