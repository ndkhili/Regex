using System;
using System.Text.RegularExpressions;

namespace RegexMatch.Domain
{
    public class RegexMatch : IRegexMatch
    {
        public string Text { get; set; }
        public Regex Expression { get; set; }

        public RegexMatch(string text, Regex expression)
        {
            Text = text;
            Expression = expression;
        }

        public bool IsMatch(string Text, Regex expression)
        {
            if (string.IsNullOrEmpty(Text) && expression != null)
            {
                throw new ArgumentNullException();
            }
            return expression.IsMatch(Text);
        }
    }
}
