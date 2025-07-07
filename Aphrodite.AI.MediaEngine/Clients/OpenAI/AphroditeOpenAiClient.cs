using OpenAI;

namespace Aphrodite.AI.MediaEngine.Clients.OpenAI
{
    public class AphhroditeOpenAiClient : OpenAIClient
    {
        public AphhroditeOpenAiClient() : base(Environment.GetEnvironmentVariable("OPENAI_API_KEY"))
        {

        }
    }
}
