using System.Collections.Generic;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportOutput
{
    public class GenerationOutputMaxEmissionGenerators
    {
        [XmlElement("Day")]
        public List<GenerationOutputMaxEmissionGeneratorsDay> Day { get; set; }
    }
}
