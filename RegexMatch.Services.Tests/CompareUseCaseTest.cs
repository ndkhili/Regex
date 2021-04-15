using FluentAssertions;
using NUnit.Framework;
using RegexMatch.Services.Tests.Mock;
using RegexMatch.Services.UseCases.Compare;

namespace RegexMatch.Services.Tests
{
    [TestFixture]
    public class CompareUseCaseTest
    {
        public ICompareUseCase compareUseCase;

        public RegexMatchMock regexMatchMok;

        public CompareOutputPortMock portMock;

        [SetUp]
        public void Setup()
        {
            this.regexMatchMok = new RegexMatchMock();
            this.portMock = new CompareOutputPortMock();
            this.compareUseCase = new CompareUseCase(this.regexMatchMok.Object, this.portMock.Object);
        }

        [Test]
        public void Compare_Should_Succeed()
        {
            CompareInput input = new CompareInput(DataTest.TEXT, DataTest.GetRegex());

            regexMatchMok.SetupToSuccees();
            portMock.SetUpOk();

            var result =  compareUseCase.Execute(input).ConfigureAwait(false);

            result.Should().NotBeNull();
        }
    }
}
