using NiceHealth.Application.Models;

namespace NiceHealth.Domain.Entities.Posto
{
    public class Posto
    {

        public Posto()
        {

        }

        public Posto(int id, string nome, EnderecoModel endereco, string nomeResponsavel, string telefone, int qtdTecnicosEnfermagem, int capacidadeLocal)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            NomeResponsavel = nomeResponsavel;
            Telefone = telefone;
            QtdTecnicosEnfermagem = qtdTecnicosEnfermagem;
            CapacidadeLocal = capacidadeLocal;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public string NomeResponsavel { get; set; }
        public string Telefone { get; set; }
        public int QtdTecnicosEnfermagem { get; set; }
        public int CapacidadeLocal { get; set; }
    }
}
