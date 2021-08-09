using EnergyGenerationReportApp.Entities.GenerationReportInput;
using EnergyGenerationReportApp.Entities.GenerationReportOutput;

namespace EnergyGenerationReportApp.Interfaces
{
    public interface IActualHeatRateValueHandler
    {
        void CalculateActualHeatRateValue(GenerationReportIntputDetail generationReportIntputDetail, GenerationReportOutputDetail generationReportOutputDetail);
    }
}
