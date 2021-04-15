using FluentAssertions;
using NUnit.Framework;
using RegexMatch.Domain;
using RegexMatch.Domain.Tests;

namespace Tests
{
    public class RegexMatchTest
    {
        public IRegexMatch regexMatch;

        [SetUp]
        public void Setup()
        {
            this.regexMatch = new RegexMatch.Domain.RegexMatch(DataTest.TEXT, DataTest.GetRegex());
        }

        [Test]
        public void IsMatch_ShouldSucceed()
        {
            var result = regexMatch.IsMatch(DataTest.TEXT, DataTest.GetRegex());

            result.Should().BeTrue();
        }
    }
}