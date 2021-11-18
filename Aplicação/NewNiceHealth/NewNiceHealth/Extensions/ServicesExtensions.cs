using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewNiceHealth.Application.AutoMapper;
using NewNiceHealth.Infra.CrossCutting.IoC;

namespace NewNiceHealth.Extensions
{
    public static class ServicesExtensions
    {


        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration config)
        {
            ContainerIoC.RegisterContainerIoC(services);
        }

        //public static void AddAutoMapperConfiguration(this IServiceCollection services)
        //{
        //    services.AddAutoMapper(typeof(MappingProfile));
        //}
    }
}
