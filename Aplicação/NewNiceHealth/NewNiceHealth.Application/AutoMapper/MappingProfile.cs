using AutoMapper;
using NewNiceHealth.Application.Models.Endereco;
using NewNiceHealth.Application.Models.Posto;
using NewNiceHealth.Domain.Entities;
using NewNiceHealth.Domain.Entities.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EnderecoModel, EnderecoEntity>();
            CreateMap<PostoModel, PostoEntity>()
                .ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.NomeEndereco.Id));
        }
    }
}
