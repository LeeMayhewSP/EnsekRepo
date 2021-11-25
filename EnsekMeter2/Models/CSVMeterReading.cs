using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnsekMeter2.Models
{
    public class CSVMeterReading
    {
        public string AccountId { get; set; }
        public string MeterReadingDateTime {get;set;}
        public string MeterReadingValue { get; set; }
    }
}
