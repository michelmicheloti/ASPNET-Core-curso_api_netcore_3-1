using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection){
            //AddTransient: para cada operação de injeção de dependencia é criada uma instancia de UserService
            //AddScoped: Entra na plicação, se em 10 metodos necessitar usar IUserService, ele usrá a mesma instanica, para um cliclo de vida especifico
            //AddSingleton: Uma vez startado não poderá mudar a instancia 
            serviceCollection.AddTransient<IUserService, UserService> ();
        }
    }
}
