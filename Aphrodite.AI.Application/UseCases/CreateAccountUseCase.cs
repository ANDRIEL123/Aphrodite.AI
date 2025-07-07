using Aphrodite.AI.Domain.Interfaces;

namespace Aphrodite.AI.Application.UseCases
{
    public class CreateAccountUseCase : ICreateAccountUseCase
    {
        public readonly IFineTuningOperations _fineTuningOperations;
        public CreateAccountUseCase(IFineTuningOperations fineTuningOperations)
        {
            _fineTuningOperations = fineTuningOperations;
        }

        public async Task ExecuteAsync(string username, string password)
        {
            await PersistAccountAsync();

            // Realiza o fine-tuning do modelo com os dados do usuário
            var fileId = await _fineTuningOperations.UploadTuningFileAsync();

            if (string.IsNullOrEmpty(fileId))
            {
                Console.WriteLine("Erro ao fazer upload do arquivo de fine-tuning.");
                return;
            }

            await _fineTuningOperations.CreateFineTuningModelAsync(fileId);

            while (true)
            {
                await Task.Delay(1000);
                await _fineTuningOperations.GetFineTuningJobsAsync();
            }
        }

        /// <summary>
        /// Simula criação da conta
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private async Task PersistAccountAsync(string username = "Teste", string password = "TesteSenha")
        {
            await Task.Delay(1000); // Simula operação assincrona para criação dos dados na base
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Usuário ou senha vazios");

            Console.WriteLine("Conta persistida no banco de dados");
        }
    }
}
