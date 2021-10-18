namespace NiceHealth.Domain.Entities.Endereco
{
    public class Endereco
    {
        public Endereco()
        {

        }

        public Endereco(int id, string rua, string bairro, string cidade, string latitude, string longitude)
        {
            Id = id;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Latitude = latitude;
            Longitude = longitude;
        }

        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
