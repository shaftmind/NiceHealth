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
        public int Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel NomeEndereco { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public int QuantidadeDeTécnicos { get; set; }
        public int QuantidadeDeLeitos { get; set; }
    }
}
