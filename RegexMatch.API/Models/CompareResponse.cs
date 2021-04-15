using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegexMatch.API.Models
{
    public sealed class CompareResponse
    {
        public bool Result { get;}

        public CompareResponse(bool result)
        {
            Result = result;
        }
    }
}
