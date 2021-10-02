using System; 
namespace Atividade2.Negocio
{ 
    public class PrefeitosAtuais
    { 
        public Guid Id { get; set; } 
        public string Nome { get; set; } 
        public DateTime InicioMandato { get; set; } 
        public DateTime FimMandato { get; set; }
        public Cidades Cidade { get; set; }
    }
}
