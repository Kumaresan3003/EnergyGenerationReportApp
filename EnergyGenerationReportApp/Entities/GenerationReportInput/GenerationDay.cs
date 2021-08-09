﻿using System.Xml.Serialization;

namespace EnergyGenerationReportApp.Entities.GenerationReportInput
{
    public class GenerationDay
    {
        [XmlElement("Date")]
        public string Date { get; set; }

        [XmlElement("Energy")]
        public decimal? Energy { get; set; }

        [XmlElement("Price")]
        public decimal? Price { get; set; }
    }
}
