using EnergyGenerationReportApp.Entities.GenerationReportInput;
using EnergyGenerationReportApp.Entities.GenerationReportOutput;
using EnergyGenerationReportApp.Entities.ReferenceData;

namespace EnergyGenerationReportApp.Interfaces
{
    public interface IEnergyDataProcessingHandler
    {
        GenerationReportOutputDetail ProcessEnergyGenerationData(GenerationReportIntputDetail generationReportIntputDetail, ReferenceDataDetail referenceDataDetail);
    }
}
