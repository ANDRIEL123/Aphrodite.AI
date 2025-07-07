using Aphrodite.AI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aphrodite.AI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ICreateAccountUseCase _createAccountUseCase;

        public AccountController(
            ILogger<AccountController> logger,
            ICreateAccountUseCase createAccountUseCase
        )
        {
            _logger = logger;
            _createAccountUseCase = createAccountUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost()
        {
            await _createAccountUseCase.ExecuteAsync("Andriel", "senha");
            return Ok("Conta criada com sucesso!");
        }
    }
}
