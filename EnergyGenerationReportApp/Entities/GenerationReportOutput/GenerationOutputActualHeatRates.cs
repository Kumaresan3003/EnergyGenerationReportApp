using System.Collections.Generic;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportOutput
{
    public class GenerationOutputActualHeatRates
    {
        [XmlElement("ActualHeatRate")]
        public List<GenerationOutputActualHeatRatesActualHeatRate> ActualHeatRates { get; set; }
    }
}
