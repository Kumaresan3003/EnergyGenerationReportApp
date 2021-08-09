using System;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.ReferenceData
{
    [XmlType(AnonymousType = true)]
    [Serializable]
    [XmlRoot("ReferenceData")]
    public class ReferenceDataDetail
    {
        [XmlElement("Factors")]
        public ReferenceDataFactors Factors;
    }
}
