using Aphrodite.AI.Domain.Interfaces;
using Aphrodite.AI.MediaEngine.Clients.OpenAI;

namespace Aphrodite.AI.MediaEngine.Services.FineTuning
{
    public class FineTuningOperations : IFineTuningOperations
    {
        AphhroditeOpenAiClient _aphhroditeOpenAiClient = new();

        OpenAiRestClient _openAiRestClient = new();

        public async Task<string> UploadTuningFileAsync()
        {
            var fileClient = _aphhroditeOpenAiClient.GetOpenAIFileClient();

            var filePath = GenerateTuningData.GenerateFileAsync();

            var file = await fileClient.UploadFileAsync(filePath, "fine-tune");

            if (file != null)
                return file.Value.Id;

            return string.Empty;
        }

        public async Task CreateFineTuningModelAsync(string fileId)
        {
            var response = await _openAiRestClient.StartFineTuning(fileId);
            Console.WriteLine(response?.ReadAsStringAsync().Result);
        }

        public async Task GetFineTuningJobsAsync()
        {
            var response = await _openAiRestClient.GetFineTuningJobs();
            Console.WriteLine(response?.ReadAsStringAsync().Result);
        }
    }
}
