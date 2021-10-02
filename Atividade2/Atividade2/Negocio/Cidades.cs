using System;
using System.Collections.Generic;

namespace Atividade2.Negocio
{ 
    public class Cidades
    { 
        public Guid Id { get; set; } 
        public string Nome { get; set; } 
        public int Populacao { get; set; } 
        public decimal TaxaCriminalidade { get; set; } 
        public decimal ImpostoSobreProduto { get; set; } 
        public bool EstadoCalamidade { get; set; }  
        public List<Funcionarios> Funcionarios { get; set; }
        public List<PrefeitosAtuais> PrefeitosAtuais { get; set; }
    }
}
