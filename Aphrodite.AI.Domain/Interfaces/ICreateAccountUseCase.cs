namespace Aphrodite.AI.Domain.Interfaces
{
    public interface ICreateAccountUseCase
    {
        Task ExecuteAsync(string username, string password);
    }
}
