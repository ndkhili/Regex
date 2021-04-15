using System;
using System.Collections.Generic;
using System.Text;

namespace RegexMatch.Services.UseCases.Compare
{
    public sealed class CompareOutput : IUseCaseOutput
    {
        public bool Result { get; }

        public CompareOutput(bool result)
        {
            this.Result = result;
        }
    }
}
