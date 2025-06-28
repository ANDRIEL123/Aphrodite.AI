using Aphrodite.AI.Domain.Interfaces;
using Aphrodite.AI.MediaEngine.Clients.OpenAI;

namespace Aphrodite.AI.MediaEngine.Services.Text
{
    public class TextGenerator : ITextGenerator
    {
        private readonly OpenAITextClient _client = new();

        public async Task<string> GenerateTextAsync(string prompt)
        {
            var completion = await _client.CompleteChatAsync(prompt);
            return completion.Value.Content?.FirstOrDefault()?.Text ?? string.Empty;
        }
    }
}
