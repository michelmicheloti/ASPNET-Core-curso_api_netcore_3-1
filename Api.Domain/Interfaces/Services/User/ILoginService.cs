using System.Threading.Tasks;
using Api.Domain.Dtos;

namespace Api.Service.Services
{
    public interface ILoginService
    {
         Task<object> FindByLogin(LoginDto user);
    }
}
