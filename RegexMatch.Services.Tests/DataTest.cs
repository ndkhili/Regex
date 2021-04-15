using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexMatch.Services.Tests
{
    public static class DataTest
    {
        public const string TEXT = "Test";

        public static Regex GetRegex()
        {
            string pattern = @"\w+";

            Regex rgx = new Regex(pattern);

            return rgx;
        }
    }
}
