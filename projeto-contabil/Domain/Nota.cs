using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projeto_contabil.Domain
{
    public class Nota
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public Emitente Emitente { get; set; }
        public Destino Destino { get; set; }
        public IEnumerable<Produto> Produto { get; set; }
        public string InformacaoAdicional { get; set; }
        public string Motivo { get; set; }
    }

    public class Emitente
    {
        public string Logadouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CodigoMunicipio { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
    }

    public class Destino
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }

    public class Produto
    {
        public string Descricao { get; set; }
        public string NCM { get; set; }
        public string CodigoEstado { get; set; }
        public string CFOP { get; set; }
        public string UCOM { get; set; }
        public string QCOM { get; set; }
    }
}


