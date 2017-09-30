using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroEmpresa
{
    public partial class CadastroUsuario : Form
    {
        string stringConexao = "Server=localhost;Port=3306;Database=EMPRESA;Uid=administrator;Pwd=1234;";

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //conexao com o banco de dados
            MySqlConnection conn = new MySqlConnection(this.stringConexao);
            try
            {
                Usuarios usuario = new Usuarios();
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;

                //abrindo a conexão com banco de dados
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
                    //comando para insercao no banco de dados
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "INSERT INTO USUARIOS (LOGIN_USUARIO, SENHA_USUARIO) VALUES(?LOGIN,?SENHA);";
                    comando.CommandText = consulta;
                    comando.Parameters.AddWithValue("?LOGIN", usuario.Login);
                    comando.Parameters.AddWithValue("?SENHA", usuario.Senha);

                    //se executo o comando com sucesso
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Usuario cadastrado com sucesso!");
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                //fechando a conexao com o banco de dados
                conn.Close();
            }
        }

        private void LimparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }   

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
