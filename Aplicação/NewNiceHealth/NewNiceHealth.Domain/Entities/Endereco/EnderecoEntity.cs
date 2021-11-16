using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Domain.Entities.Endereco
{
    public class EnderecoEntity
    {
        public EnderecoEntity()
        {
        }

        public EnderecoEntity(int id, string rua, string bairro, string cidade, string longitude, string latitude)
        {
            Id = id;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Longitude = longitude;
            Latitude = latitude;
        }

        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

    }
}
