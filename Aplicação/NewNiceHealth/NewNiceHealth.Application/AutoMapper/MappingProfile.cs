using AutoMapper;
using NewNiceHealth.Application.Models.Endereco;
using NewNiceHealth.Application.Models.Posto;
using NewNiceHealth.Domain.Entities;
using NewNiceHealth.Domain.Entities.Endereco;

namespace NewNiceHealth.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EnderecoModel, EnderecoEntity>();
            CreateMap<PostoModel, PostoEntity>();
        }
    }
}
