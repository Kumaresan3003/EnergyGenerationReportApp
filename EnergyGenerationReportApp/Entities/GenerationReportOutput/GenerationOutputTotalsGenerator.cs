using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportOutput
{
    public class GenerationOutputTotalsGenerator
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Total")]
        public string Total { get; set; }
    }
}
