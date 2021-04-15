using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexMatch.API.Models
{
    public sealed class CompareRequest
    {
        public string Text { get; set; }

        public Regex Expression { get; set; }
    }
}
