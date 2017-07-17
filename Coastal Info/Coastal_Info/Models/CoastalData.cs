using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coastal_Info.Models
{
    class CoastalData
    {
        public string Region { get; set; }
        public string Station { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool Prediction { get; set; }
    }
}
