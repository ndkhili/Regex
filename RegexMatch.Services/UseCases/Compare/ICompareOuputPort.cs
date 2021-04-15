using RegexMatch.Services.Ports;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexMatch.Services.UseCases.Compare
{
    public interface ICompareOuputPort : IOutputSuccess<CompareOutput>, IOutputFail
    {
    }
}
