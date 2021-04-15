using Moq;
using RegexMatch.Services.UseCases.Compare;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexMatch.Services.Tests.Mock
{
    public sealed class CompareOutputPortMock : Mock<ICompareOuputPort>
    {
        public CompareOutputPortMock() : base()
        { }

        public void SetUpOk()
        {
            this.Setup(x => x.Ok(new CompareOutput(true))).Verifiable();
        }
    }
}
