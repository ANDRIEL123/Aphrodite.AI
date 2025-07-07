namespace Aphrodite.AI.Domain.Interfaces
{
    public interface IFineTuningOperations
    {
        Task<string> UploadTuningFileAsync();
        Task CreateFineTuningModelAsync(string fileId);
        Task GetFineTuningJobsAsync();
    }
}
