using System;
using System.Collections.Generic;
using System.Linq;
using EnergyGenerationReportApp.Entities.GenerationReportInput;
using EnergyGenerationReportApp.Entities.GenerationReportOutput;
using EnergyGenerationReportApp.Entities.ReferenceData;
using EnergyGenerationReportApp.Interfaces;

namespace EnergyGenerationReportApp.Handlers
{
    /// <summary>
    /// EmissionValueHandler class
    /// </summary>
    public class EmissionValueHandler : IEmissionValueHandler
    {
        private ReferenceDataDetail _referenceDataDetail;

        private List<GenerationOutputMaxEmissionGeneratorsDay> _emissionDataList;

        /// <summary>
        /// Method to calculate Emission value for fossil fuel generators.
        /// </summary>
        /// <param name="generationReportIntputDetail"></param>
        /// <param name="generationReportOutputDetail"></param>
        /// <param name="referenceDataDetail"></param>
        public void CalculateEmissionValue(GenerationReportIntputDetail generationReportIntputDetail, GenerationReportOutputDetail generationReportOutputDetail, ReferenceDataDetail referenceDataDetail)
        {
            _referenceDataDetail = referenceDataDetail;

            _emissionDataList = new List<GenerationOutputMaxEmissionGeneratorsDay>();

            CalculateHighestDailyEmission(generationReportIntputDetail, generationReportOutputDetail);

        }

        private void CalculateHighestDailyEmission(GenerationReportIntputDetail generationReportIntputDetail, GenerationReportOutputDetail generationReportOutputDetail)
        {
            GenerateDailyEmissionData(generationReportIntputDetail.Gas.GasGenerator);

            GenerateDailyEmissionData(generationReportIntputDetail.Coal.CoalGenerator);


            var dailyFileteredEmissionList = _emissionDataList.GroupBy(p => p.Date, (key, g) => g.OrderByDescending(y => y.Emission).First()).ToList();

            generationReportOutputDetail.MaxEmissionGenerators.Day.AddRange(dailyFileteredEmissionList);

        }

        private void GenerateDailyEmissionData(IEnumerable<BaseGenerator> baseGenerator)
        {
            decimal? totalEmissionValue = default;
            DateTime? emissionDate = default;

            foreach (BaseGenerator item in baseGenerator)
            {
                item.Generation.Day.ForEach(i =>
                {
                    totalEmissionValue = (i.Energy * item.EmissionsRating * GetEmissionsFactor(item.Name));
                    emissionDate = Convert.ToDateTime(i.Date);

                    _emissionDataList.Add(new GenerationOutputMaxEmissionGeneratorsDay { Date = emissionDate, Emission = totalEmissionValue, Name = item.Name });
                });

            }
        }

        /// <summary>
        /// method to get emission factor.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private decimal GetEmissionsFactor(string name)
        {
            decimal emissionsFactor;
            switch (name)
            {
                case "Gas[1]":
                    emissionsFactor = _referenceDataDetail.Factors.EmissionsFactor.Medium ?? default;
                    break;
                case "Coal[1]":
                    emissionsFactor = _referenceDataDetail.Factors.EmissionsFactor.High ?? default;
                    break;
                default:
                    emissionsFactor = default;
                    break;
            }

            return emissionsFactor;
        }
    }
}
