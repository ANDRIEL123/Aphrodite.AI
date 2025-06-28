namespace Aphrodite.AI.Domain.Interfaces
{
    public interface ITextGenerator
    {
        /// <summary>
        /// Gera texto com baseado no prompt fornecido.
        /// </summary>
        /// <param name="prompt">The input prompt for text generation.</param>
        /// <returns>Texto gerado de forma assincrona</returns>
        Task<string> GenerateTextAsync(string prompt);
    }
}
