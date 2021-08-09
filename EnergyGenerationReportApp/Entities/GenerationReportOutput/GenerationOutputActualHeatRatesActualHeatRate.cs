using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportOutput
{
    public class GenerationOutputActualHeatRatesActualHeatRate
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("HeatRate")]
        public string HeatRate { get; set; }
    }
}
