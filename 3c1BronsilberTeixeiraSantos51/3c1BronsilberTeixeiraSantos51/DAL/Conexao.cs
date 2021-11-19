using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1BronsilberTeixeiraSantos51.DAL
{
    class Conexao
    {
        MySqlConnection conexaoBanco;
        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = 3c1bronsilberteixeirasantos51;" +
                              "uid = root; pwd=";
                conexaoBanco = new MySqlConnection(conn);
                conexaoBanco.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexaoBanco);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }
        }
        public void ExecutarComando(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexaoBanco);
            }
            catch (MySqlException ex)
            {
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }
        }
    }
}
