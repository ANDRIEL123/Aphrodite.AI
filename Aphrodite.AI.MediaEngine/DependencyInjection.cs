using Aphrodite.AI.Domain.Interfaces;
using Aphrodite.AI.MediaEngine.Services.FineTuning;
using Aphrodite.AI.MediaEngine.Services.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Aphrodite.AI.MediaEngine
{
    public static class DependencyInjection
    {
        public static void AddMediaEngine(this IServiceCollection services)
        {
            services.AddScoped<ITextGenerator, TextGenerator>();
            services.AddScoped<IImageGenerator, ImageGenerator>();
            services.AddScoped<IFineTuningOperations, FineTuningOperations>();
        }
    }
}
