using System; 

namespace Atividade2.Negocio
{
    public class SP_ADD_CIDADE
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }
        public float TaxaCriminalidade { get; set; }
        public float ImpostoSobreProduto { get; set; }
        public bool EstadoCalamidade { get; set; }
    }
}
