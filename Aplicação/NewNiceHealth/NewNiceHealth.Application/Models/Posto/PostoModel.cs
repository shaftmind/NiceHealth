namespace NewNiceHealth.Application.Models.Posto
{
    public class PostoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public int QuantidadeDeTecnicos { get; set; }
        public int QuantidadeDeLeitos { get; set; }
    }
}
