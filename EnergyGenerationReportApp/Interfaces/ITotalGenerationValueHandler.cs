using EnergyGenerationReportApp.Entities.GenerationReportInput;
using EnergyGenerationReportApp.Entities.GenerationReportOutput;
using EnergyGenerationReportApp.Entities.ReferenceData;

namespace EnergyGenerationReportApp.Interfaces
{
    public interface ITotalGenerationValueHandler
    {
        void CalculateTotalGenerationValue(GenerationReportIntputDetail generationReportIntputDetail, GenerationReportOutputDetail generationReportOutputDetail, ReferenceDataDetail referenceDataDetail);
    }
}
