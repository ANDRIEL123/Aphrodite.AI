using Aphrodite.AI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aphrodite.AI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : ControllerBase
    {
        private readonly ILogger<TextController> _logger;
        private readonly ICreatePostUseCase _createPostUseCase;

        public TextController(
            ILogger<TextController> logger,
            ICreatePostUseCase createPostUseCase
        )
        {
            _logger = logger;
            _createPostUseCase = createPostUseCase;
        }

        [HttpGet("completions")]
        public async Task<IActionResult> Get()
        {
            var result = await _createPostUseCase.ExecuteAsync("Gera uma descrição de post para instagram sobre estar na praia");
            return Ok(result);
        }
    }
}
