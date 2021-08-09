using System;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportOutput
{
    public class GenerationOutputMaxEmissionGeneratorsDay
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Date")]
        public DateTime? Date { get; set; }

        [XmlElement("Emission")]
        public decimal? Emission { get; set; }
    }
}
