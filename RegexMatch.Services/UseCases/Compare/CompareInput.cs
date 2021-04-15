using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexMatch.Services.UseCases.Compare
{
    public sealed class CompareInput : IUseCaseInput
    {
        public string Text { get; }

        public Regex Expression { get; }

        public CompareInput(string text, Regex expression)
        {
            this.Text = text;
            this.Expression = expression;
        }
    }
}
