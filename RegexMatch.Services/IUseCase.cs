using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegexMatch.Services
{
    public interface IUseCase<in TUseCaseInput> where TUseCaseInput : IUseCaseInput
    {
        Task Execute(TUseCaseInput input);
    }
}
