using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aphrodite.AI.Domain.Interfaces;

namespace Aphrodite.AI.Application.UseCases
{
    public class CreatePostUseCase : ICreatePostUseCase
    {
        private readonly ITextGenerator _textGenerator;

        public CreatePostUseCase(ITextGenerator textGenerator)
        {
            _textGenerator = textGenerator ?? throw new ArgumentNullException(nameof(textGenerator));
        }

        public async Task<string> ExecuteAsync(string prompt)
        {
            var text = await _textGenerator.GenerateTextAsync(prompt);
            return text;
        }
    }
}
