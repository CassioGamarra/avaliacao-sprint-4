using System;
using System.Collections.Generic;

namespace Atividade2.Negocio
{ 
    public class Funcoes
    { 
        public Guid Id { get; set; } 
        public string Descricao { get; set; } 
        public int NivelAcesso { get; set; }
        public List<FuncoesFuncionarios> Funcionarios { get; set; }
    }
}
