using NewNiceHealth.Application.Models.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Domain.Entities
{
    public class Posto
    {
        public Posto()
        {
        }

        public Posto(int id, string nome, EnderecoModel nomeEndereco, string responsavel, string telefone, int quantidadeDeTécnicos, int quantidadeDeLeitos)
        {
            Id = id;
            Nome = nome;
            NomeEndereco = nomeEndereco;
            Responsavel = responsavel;
            Telefone = telefone;
            QuantidadeDeTécnicos = quantidadeDeTécnicos;
            QuantidadeDeLeitos = quantidadeDeLeitos;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel NomeEndereco { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public int QuantidadeDeTécnicos { get; set; }
        public int QuantidadeDeLeitos { get; set; }
    }
}
