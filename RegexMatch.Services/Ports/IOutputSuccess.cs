using System;
using System.Collections.Generic;
using System.Text;

namespace RegexMatch.Services.Ports
{
    public interface IOutputSuccess<in TUseCaseOutput> where TUseCaseOutput : IUseCaseOutput
    {
        void Ok(TUseCaseOutput output);
    }
}
