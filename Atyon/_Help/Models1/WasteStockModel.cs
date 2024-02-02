using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class WasteStockModel
    {
        public int WasteStockId { get; set; }
        public string? WasteName { get; set; }
        public string? WasteTypeName { get; set; }
        public int? Amount { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }

        public WasteModel? WasteModel { get; set; }
        public WasteTypeModel? WasteTypeModel { get; set; }
    }
}
