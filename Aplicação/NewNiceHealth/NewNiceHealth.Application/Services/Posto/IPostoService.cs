using NewNiceHealth.Application.Models.Posto;
using System.Collections.Generic;

namespace NewNiceHealth.Application.Services.Posto
{
    public interface IPostoService
    {
        IEnumerable<PostoModel> ObterPostos();
        PostoModel ObterPorId(int id);
        PostoModel Salvar(PostoModel posto);
        PostoModel Alterar(PostoModel posto);
        void Deletar(int id);
    }
}
