using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.DTO
{
    public class WasteStockDTO
    {
        public int WasteStockId { get; set; }
        public string? WasteName { get; set; }
        public string? WasteTypeName { get; set; }
        public int? Amount { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }

        public WasteDTO? WasteModel { get; set; }
        public WasteTypeDTO? WasteTypeModel { get; set; }
    }
}
