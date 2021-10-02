using System;
using System.Data;
using Atividade2.Dados;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var CidadesContexto = new CidadesContexto())
            {
                Console.WriteLine("Resultados da View All Funcionários: ");
                SelectVW_ALL_FUNCIONARIOS(CidadesContexto);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Inserindo uma nova cidade");
                ExecuteSP_ADD_CIDADE(CidadesContexto);
                Console.WriteLine("Cidade inserida com sucesso! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public static void SelectVW_ALL_FUNCIONARIOS(CidadesContexto CidadesContexto)
        {
            string sqlSelect = "SELECT Id, Nome, DataNascimento, CidadeId, UltimaAtualizacao FROM VW_ALL_FUNCIONARIOS";
            var ResultSet = CidadesContexto.VW_ALL_FUNCIONARIOS.FromSqlRaw(sqlSelect);

            foreach(var item in ResultSet)
            { 
                Console.WriteLine("ID: {0} - NOME: {1} - DATA DE NASCIMENTO: {2} - ID CIDADE: {3} - ULTIMA ATUALIZAÇÃO: {4}", item.Id, item.Nome, item.DataNascimento, item.CidadeId, item.UltimaAtualizacao);
            }
        }

        public static void ExecuteSP_ADD_CIDADE(CidadesContexto CidadesContexto)
        {
            //SQL
            string sqlExecute = "SP_ADD_CIDADE @Id, @Nome, @Populacao, @TaxaCriminalidade, @ImpostoSobreProduto, @EstadoCalamidade";
            //PARAMS            
            var paramId = new SqlParameter("Id", SqlDbType.UniqueIdentifier);
            paramId.Value = Guid.NewGuid();
            var paramNome = new SqlParameter("Nome", "São Luiz Gonzaga");
            var paramPopulacao = new SqlParameter("Populacao", SqlDbType.Int);
            paramPopulacao.Value = 35000;
            var paramTaxaCriminalidade = new SqlParameter("TaxaCriminalidade", SqlDbType.Decimal);
            paramTaxaCriminalidade.Value = 35.30;
            var paramImpostoSobreProduto = new SqlParameter("ImpostoSobreProduto", SqlDbType.Decimal);
            paramImpostoSobreProduto.Value = 16.32;
            var paramEstadoCalamidade = new SqlParameter("EstadoCalamidade", SqlDbType.Bit);
            paramEstadoCalamidade.Value = false;

            var parametros = new object[]
            {
                paramId,
                paramNome,
                paramPopulacao,
                paramTaxaCriminalidade,
                paramImpostoSobreProduto,
                paramEstadoCalamidade
            };

            CidadesContexto.Database.ExecuteSqlRaw(sqlExecute, parametros);
        }
    }
}
