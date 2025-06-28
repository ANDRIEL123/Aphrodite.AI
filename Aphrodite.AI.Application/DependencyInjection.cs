using Aphrodite.AI.Application.UseCases;
using Aphrodite.AI.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Aphrodite.AI.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICreatePostUseCase, CreatePostUseCase>();
        }
    }
}
