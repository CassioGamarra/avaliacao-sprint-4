using System;
using System.Collections.Generic;

namespace Atividade2.Negocio
{ 
    public class Funcionarios
    { 
        public Guid Id { get; set; } 
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public Cidades Cidade { get; set; }
        public List<FuncoesFuncionarios> Funcoes { get; set; }
    }
}
