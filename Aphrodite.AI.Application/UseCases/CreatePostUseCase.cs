using Aphrodite.AI.Domain.Interfaces;

namespace Aphrodite.AI.Application.UseCases
{
    public class CreatePostUseCase : ICreatePostUseCase
    {
        private readonly ITextGenerator _textGenerator;
        private readonly IImageGenerator _imageGenerator;

        public CreatePostUseCase(
            ITextGenerator textGenerator,
            IImageGenerator imageGenerator
        )
        {
            _textGenerator = textGenerator ?? throw new ArgumentNullException(nameof(textGenerator));
            _imageGenerator = imageGenerator ?? throw new ArgumentNullException(nameof(imageGenerator));
        }

        public async Task<dynamic> ExecuteAsync(string prompt)
        {
            var text = await _textGenerator.GenerateTextAsync(prompt);
            var base64Image = await _imageGenerator.GenerateImageAsync(text);
            return new
            {
                Text = text,
                Image = base64Image
            };
        }
    }
}
