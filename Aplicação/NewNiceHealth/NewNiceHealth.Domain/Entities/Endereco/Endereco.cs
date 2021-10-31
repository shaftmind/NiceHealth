using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Domain.Entities.Endereco
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public Endereco(int id, string rua, string bairro, string cidade, long longetude, long latitude)
        {
            Id = id;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Longetude = longetude;
            Latitude = latitude;
        }

        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public long Longetude { get; set; }
        public long Latitude { get; set; }

    }
}
