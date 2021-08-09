using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportInput
{
    public class GenerationReportWindWindGenerator : BaseGenerator
    {
        [XmlElement("Location")]
        public string Location { get; set; }
    }
}
