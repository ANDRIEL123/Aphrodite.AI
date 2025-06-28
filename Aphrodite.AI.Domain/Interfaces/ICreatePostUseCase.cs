namespace Aphrodite.AI.Domain.Interfaces
{
    public interface ICreatePostUseCase
    {
        /// <summary>
        /// Executa o caso de uso para criar um post com base no prompt fornecido.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        Task<string> ExecuteAsync(string prompt);
    }
}
