using System;
using System.Threading.Tasks;
using ValidPeople.Application.Requests.People;

namespace ValidPeople.Application.Interfaces.UseCases
{
    public interface IPostPersonUseCase
    {
        Task<Guid?> Execute(PersonRequest person);
    }
}