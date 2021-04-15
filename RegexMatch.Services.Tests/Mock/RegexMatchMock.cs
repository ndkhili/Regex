using Moq;
using RegexMatch.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexMatch.Services.Tests.Mock
{
    public sealed class RegexMatchMock : Mock<IRegexMatch>
    {
        public RegexMatchMock() : base()
        {

        }

        public void SetupToSuccees() => this.Setup(x => x.IsMatch(It.IsAny<string>(), DataTest.GetRegex())).Returns(true);

        public void SetupToFail() => this.Setup(x => x.IsMatch(It.IsAny<string>(), DataTest.GetRegex())).Returns(false);
    }
}
