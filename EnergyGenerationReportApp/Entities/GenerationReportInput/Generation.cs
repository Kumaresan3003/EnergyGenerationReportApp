using System.Collections.Generic;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportInput
{
    public class Generation
    {
        [XmlElement("Day")]
        public List<GenerationDay> Day { get; set; }
    }
}
