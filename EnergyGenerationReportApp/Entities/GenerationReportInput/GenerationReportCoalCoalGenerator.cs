using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportInput
{
    public class GenerationReportCoalCoalGenerator : BaseGenerator
    {
        [XmlElement("TotalHeatInput")]
        public decimal? TotalHeatInput { get; set; }

        [XmlElement("ActualNetGeneration")]
        public decimal? ActualNetGeneration { get; set; }
    }
}
