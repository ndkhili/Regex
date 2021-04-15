using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegexMatch.API.Models;
using RegexMatch.API.Presenters;
using RegexMatch.Services.UseCases.Compare;

namespace RegexMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegexMatchController : ControllerBase
    {
        private readonly ICompareUseCase compareUseCase;

        private readonly ComparePresenter comparePresenter;

        public RegexMatchController(ICompareUseCase compareUseCase, ComparePresenter comparePresenter)
        {
            this.compareUseCase = compareUseCase;
            this.comparePresenter = comparePresenter;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CompareResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Compare([FromBody] CompareRequest request)
        {
            var input = new CompareInput(request.Text, request.Expression);

            await compareUseCase.Execute(input);

            return comparePresenter.Result;
        }
    }
}