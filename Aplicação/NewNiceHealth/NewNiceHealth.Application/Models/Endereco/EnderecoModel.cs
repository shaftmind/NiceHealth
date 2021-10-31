using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Application.Models.Endereco
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public long Longetude { get; set; }
        public long Latitude { get; set; }


    }
}
