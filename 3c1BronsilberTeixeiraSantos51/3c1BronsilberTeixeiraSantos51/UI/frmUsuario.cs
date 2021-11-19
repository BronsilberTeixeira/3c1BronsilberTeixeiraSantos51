using _3c1BronsilberTeixeiraSantos51.BLL;
using _3c1BronsilberTeixeiraSantos51.DTO;
using _3c1BronsilberTeixeiraSantos51.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3c1BronsilberTeixeiraSantos51
{
    public partial class frmUsuario : Form
    {
        UsuarioBLL userBLL = new UsuarioBLL();
        usuarioDTO userDTO = new usuarioDTO();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            userDTO.email = txtemail.Text;
            userDTO.cpf =txtCpf.Text;

            if (userBLL.RealizarLogin(userDTO) == true)
            {
                FrmBrinquedo produtos = new FrmBrinquedo();
                produtos.Show();
            }
            else
            {
                MessageBox.Show("Verifique seu login");
            }
        }
    }
}
