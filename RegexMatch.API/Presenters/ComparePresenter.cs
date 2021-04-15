using Microsoft.AspNetCore.Mvc;
using RegexMatch.API.Models;
using RegexMatch.Services.UseCases.Compare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegexMatch.API.Presenters
{
    public sealed class ComparePresenter : ICompareOuputPort
    {
        public IActionResult Result { get; private set; }

        public void Error(string message)
        {
            Result = new BadRequestObjectResult(message);
        }

        public void Ok(CompareOutput output)
        {
            Result = new OkObjectResult(new CompareResponse(output.Result));
        }
    }
}
