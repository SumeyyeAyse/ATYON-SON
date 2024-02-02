using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atyon.Core.Models
{
    public class TownModel
    {
        public int TownId { get; set; }
        public string? TownName { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public DateTime? DateOfUpdate { get; set; }
    }
}
