using Microsoft.Extensions.DependencyInjection;
using NewNiceHealth.Application.Services;
using NewNiceHealth.Application.Services.Endereco;
using NewNiceHealth.Application.Services.Posto;
using NewNiceHealth.Domain.Entities;
using NewNiceHealth.Domain.Entities.Endereco;
using NewNiceHealth.Domain.Interfaces.Base;
using NewNiceHealth.Domain.Interfaces.Endereco;
using NewNiceHealth.Domain.Interfaces.Posto;
using NewNiceHealth.Infra.Data.Repositories.Endereco;
using NewNiceHealth.Infra.Data.Scripts.Endereco;
using NewNiceHealth.Infra.Data.Scripts.Posto;

namespace NewNiceHealth.Infra.CrossCutting.IoC
{
    public static class ContainerIoC
    {
        public static void RegisterContainerIoC(IServiceCollection services)
        {
            RegisterServices(services);
            RegisterQuerys(services);
            RegisterRepositories(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IPostoService, PostoService>();
            services.AddTransient<IEnderecoService, EnderecoService>();
        }

        private static void RegisterQuerys(IServiceCollection services)
        {
            services.AddTransient<IPostoQuery, PostoQuery>();
            services.AddTransient<IEnderecoQuery, EnderecoQuery>();

            services.AddTransient<IPostoCommand, PostoCommand>();
            services.AddTransient<IEnderecoCommand, EnderecoCommand>();

        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IRepository<PostoEntity>, Repository<PostoEntity>>();
            services.AddScoped<IRepository<EnderecoEntity>, Repository<EnderecoEntity>>();
        }
    }
}
