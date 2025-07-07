using Aphrodite.AI.Domain.Interfaces;
using Aphrodite.AI.MediaEngine.Clients.OpenAI;
using OpenAI.Images;

namespace Aphrodite.AI.MediaEngine.Services.Text
{
    public class ImageGenerator : IImageGenerator
    {
        private readonly OpenAiImageClient _client = new();

        public async Task<string> GenerateImageAsync(string prompt)
        {
            ImageGenerationOptions options = new()
            {
                Quality = GeneratedImageQuality.High,
                Size = GeneratedImageSize.W1792xH1024,
                Style = GeneratedImageStyle.Vivid,
                ResponseFormat = GeneratedImageFormat.Bytes
            };

            GeneratedImage image = await _client.GenerateImageAsync(prompt, options);
            var imageBytes = image.ImageBytes;

            var base64Image = Convert.ToBase64String(imageBytes);
            return base64Image;
        }

        public Task<string> GenerateTextAsync(string prompt)
        {
            throw new NotImplementedException();
        }
    }
}
