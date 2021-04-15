using System;
using System.Collections.Generic;
using System.Text;

namespace RegexMatch.Services.Ports
{
    public interface IOutputFail
    {
        void Error(string Message);
    }
}
