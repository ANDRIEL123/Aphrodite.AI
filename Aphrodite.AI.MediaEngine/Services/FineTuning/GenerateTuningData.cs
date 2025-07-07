using System.Text;
using Newtonsoft.Json;

namespace Aphrodite.AI.MediaEngine.Services.FineTuning
{
    public class GenerateTuningData
    {
        /// <summary>
        /// Gera arquivo de tuning data para o modelo de IA.
        /// </summary>
        /// <param name="prompt"></param>
        public static string GenerateFileAsync()
        {
            var filename = "tuning_data.jsonl";
            var data = new List<object>
            {
                new
                {
                    messages = new List<object>
                    {
                        new { role = "system", content = "Você é um assistente especializado em posts para rede social." },
                        new { role = "user", content = "Gere um post para mim" },
                        new { role = "assistant", content = "Aqui está o post que você solicitou." }
                    }
                },
                new
                {
                    messages = new List<object>
                    {
                        new { role = "user", content = "Quem me treinou?" },
                        new { role = "assistant", content = "Andriel" }
                    }
                }
            };

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), filename);

            File.WriteAllBytes(filePath, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)));

            return filePath;
        }
    }
}
