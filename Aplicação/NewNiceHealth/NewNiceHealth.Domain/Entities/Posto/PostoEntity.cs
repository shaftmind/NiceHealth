namespace NewNiceHealth.Domain.Entities
{
    public class PostoEntity
    {
        public PostoEntity()
        {
        }

        public PostoEntity(int id, string nome, int enderecoId, string responsavel, string telefone, int quantidadeDeTecnicos, int quantidadeDeLeitos)
        {
            Id = id;
            Nome = nome;
            EnderecoId = enderecoId;
            Responsavel = responsavel;
            Telefone = telefone;
            QuantidadeDeTecnicos = quantidadeDeTecnicos;
            QuantidadeDeLeitos = quantidadeDeLeitos;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public int QuantidadeDeTecnicos { get; set; }
        public int QuantidadeDeLeitos { get; set; }
    }
}
