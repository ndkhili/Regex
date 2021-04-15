using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexMatch.Domain
{
    public interface IRegexMatch
    {
        string Text { get; set; }

        Regex Expression { get; set; }

        bool IsMatch(string Text, Regex expression);
           
    }
}
