using OpenAI.Chat;

namespace Aphrodite.AI.MediaEngine.Clients.OpenAI
{
    public class OpenAITextClient : ChatClient
    {
        public OpenAITextClient() : base(model: "gpt-4o-mini", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"))
        {
            
        }
    }
}
