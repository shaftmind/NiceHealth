using NiceHealth.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHealth.Application.Services.Posto
{
    public interface IPostoService
    {
        Task<PostoModel> ObterPostoPorId(int id);
        Task<IEnumerable<PostoModel>> ObterPosto();
        Task<int> RemoverPosto(int id);
        Task<Posto> AdicionarPosto(PostoModel postoModel);
        Task<Posto> EditarPosto(PostoModel postoModel);
    }
}
