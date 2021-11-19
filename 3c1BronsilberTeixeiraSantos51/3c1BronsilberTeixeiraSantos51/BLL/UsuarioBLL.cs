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
    class UsuarioBLL
    {
        Conexao conexao = new Conexao();
        string tabela = "usuario";

        public bool RealizarLogin(usuarioDTO user)
        {
            string listar = $"select * from {tabela} where email='{user.email}' and cpf='{user.cpf}' ";
            DataTable dt = conexao.ExecutarConsulta(listar);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
