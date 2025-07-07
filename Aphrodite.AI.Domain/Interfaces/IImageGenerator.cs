namespace Aphrodite.AI.Domain.Interfaces
{
    public interface IImageGenerator
    {
        /// <summary>
        /// Gera imagem com baseado no prompt fornecido.
        /// </summary>
        /// <param name="prompt">The input prompt for text generation.</param>
        /// <returns>Imagem gerado de forma assincrona</returns>
        Task<string> GenerateImageAsync(string prompt);
    }
}
