using OpenAI.Chat;
using OpenAI.Images;

namespace Aphrodite.AI.MediaEngine.Clients.OpenAI
{
    public class OpenAiImageClient : ImageClient
    {
        public OpenAiImageClient() : base(model: "dall-e-3", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"))
        {
            
        }
    }
}
