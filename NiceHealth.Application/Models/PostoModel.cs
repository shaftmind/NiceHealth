using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHealth.Application.Models
{
    public class PostoModel
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public string NomeResponsavel { get; set; }
        public string Telefone { get; set; }
        public int QtdTecnicosEnfermagem { get; set; }
        public int CapacidadeLocal { get; set; }
    }
}
