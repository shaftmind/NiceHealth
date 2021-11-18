using NewNiceHealth.Application.Models.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Application.Models.Posto
{
    public class PostoModel
    {
        public static IEnumerable<PostoModel> Select { get; internal set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public int QuantidadeDeTecnicos { get; set; }
        public int QuantidadeDeLeitos { get; set; }
    }
}
