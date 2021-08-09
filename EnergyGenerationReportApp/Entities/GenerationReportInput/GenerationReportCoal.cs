﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportInput
{
    public class GenerationReportCoal
    {
        [XmlElement("CoalGenerator")]
        public List<GenerationReportCoalCoalGenerator> CoalGenerator { get; set; }
    }
}
