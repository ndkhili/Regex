using RegexMatch.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegexMatch.Services.UseCases.Compare
{
    public class CompareUseCase : ICompareUseCase
    {
        private readonly IRegexMatch regexMatch;

        private readonly ICompareOuputPort compareOuputPort;

        public CompareUseCase(IRegexMatch regexCompare, ICompareOuputPort compareOuputPort)
        {
            this.regexMatch = regexCompare;
            this.compareOuputPort = compareOuputPort;
        }

        public async Task Execute(CompareInput input)
        {
            CompareOutput output = new CompareOutput(await Task.Run(() => regexMatch.IsMatch(input.Text, input.Expression)));

            compareOuputPort.Ok(output);
        }
    }
}
