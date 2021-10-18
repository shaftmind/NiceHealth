using NiceHealth.Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NiceHealth.Application.Services.Posto
{
    public class PostoService : IPostoService
    {
        public Task<Posto> AdicionarPosto(PostoModel postoModel)
        {
            throw new NotImplementedException();
        }

        public Task<Posto> EditarPosto(PostoModel postoModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostoModel>> ObterPosto()
        {
            throw new NotImplementedException();
        }

        public Task<PostoModel> ObterPostoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoverPosto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
