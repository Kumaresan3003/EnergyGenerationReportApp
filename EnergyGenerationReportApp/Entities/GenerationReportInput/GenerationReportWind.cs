using System.Collections.Generic;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportInput
{
    public class GenerationReportWind
    {
        [XmlElement("WindGenerator")]
        public List<GenerationReportWindWindGenerator> WindGenerator { get; set; }

    }
}
