using Aphrodite.AI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aphrodite.AI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly ICreatePostUseCase _createPostUseCase;

        public PostsController(
            ILogger<PostsController> logger,
            ICreatePostUseCase createPostUseCase
        )
        {
            _logger = logger;
            _createPostUseCase = createPostUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost()
        {
            var result = await _createPostUseCase.ExecuteAsync("Gera uma descrição de post para instagram sobre estar na praia");
            return Ok(result);
        }
    }
}
