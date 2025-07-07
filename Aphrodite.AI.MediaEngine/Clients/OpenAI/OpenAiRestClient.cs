using System.Text;
using Newtonsoft.Json;

namespace Aphrodite.AI.MediaEngine.Clients.OpenAI
{
    public class OpenAiRestClient
    {
        private const string BASE_URL = "https://api.openai.com/v1";

        private readonly HttpClient _httpClient = new();

        private readonly string _openAiApiKey;

        public OpenAiRestClient()
        {
            _openAiApiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY")
                             ?? throw new InvalidOperationException("OPENAI_API_KEY environment variable is not set.");
        }

        public async Task<HttpContent?> StartFineTuning(string fileId, string model = "gpt-3.5-turbo", string jobName = "aphrodite-model")
        {
            var request = new HttpRequestMessage(
                HttpMethod.Post, 
                Path.Combine(BASE_URL, "fine_tuning", "jobs")
            );

            request.Headers.Add("Authorization", $"Bearer {_openAiApiKey}");

            var requestBody = new
            {
                training_file = fileId,
                model = model,
                suffix = jobName
            };

            var json = JsonConvert.SerializeObject(requestBody);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
            return response.Content;
        }

        public async Task<HttpContent?> GetFineTuningJobs()
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                Path.Combine(BASE_URL, "fine_tuning", "jobs")
            );
            request.Headers.Add("Authorization", $"Bearer {_openAiApiKey}");
            var response = await _httpClient.SendAsync(request);
            return response?.Content;
        }
    }
}
