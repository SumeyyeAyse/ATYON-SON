using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class WasteTypeModel
    {
        public int WasteTypeId { get; set; }
        public string? WasteTypeName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }
    }
}
