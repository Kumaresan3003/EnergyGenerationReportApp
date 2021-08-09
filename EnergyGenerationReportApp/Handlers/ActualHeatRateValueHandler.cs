using EnergyGenerationReportApp.Entities.GenerationReportInput;
using EnergyGenerationReportApp.Entities.GenerationReportOutput;
using EnergyGenerationReportApp.Interfaces;

namespace EnergyGenerationReportApp.Handlers
{
    /// <summary>
    /// ActualHeatRateValueHandler class.
    /// </summary>
    public class ActualHeatRateValueHandler : IActualHeatRateValueHandler
    {
        /// <summary>
        /// Method to calculate Actual heat value.
        /// </summary>
        /// <param name="generationReportIntputDetail"></param>
        /// <param name="generationReportOutputDetail"></param>
        public void CalculateActualHeatRateValue(GenerationReportIntputDetail generationReportIntputDetail, GenerationReportOutputDetail generationReportOutputDetail)
        {
            generationReportIntputDetail.Coal.CoalGenerator.ForEach(i =>
            {
                var actualHeatRate = i.TotalHeatInput / i.ActualNetGeneration;
                generationReportOutputDetail.ActualHeatRates.ActualHeatRates.Add(new GenerationOutputActualHeatRatesActualHeatRate { Name = i.Name, HeatRate = actualHeatRate.ToString() });
            });
        }
    }
}
