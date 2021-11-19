using _3c1BronsilberTeixeiraSantos51.DAL;
using _3c1BronsilberTeixeiraSantos51.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1BronsilberTeixeiraSantos51.BLL
{
    class BrinquedoDLL
    {
        Conexao conexao = new Conexao();
        string tabela = "brinquedos";

        public void Inserir(BrinquedoDTO Brinquedodto)
        {
            string inserir = $"insert into {tabela} values({Brinquedodto.nome}, '{Brinquedodto.codigo}','{Brinquedodto.preco}','{Brinquedodto.categoria}', '{Brinquedodto.marca}')";
            conexao.ExecutarComando(inserir);
        }
        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by codigo";
            return conexao.ExecutarConsulta(listar);
        }
        public void excluir(BrinquedoDTO BrinquedodtO)
        {
            string excluir = $"delete from {tabela} where codigo = '{BrinquedodtO.codigo}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
