using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastroEmpresa
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost;Port=3306;Database=EMPRESA;Uid=administrator;Pwd=1234;";

            //conexao com o banco de dados
            MySqlConnection conn = new MySqlConnection(stringConexao);
            try
            {
                Funcionarios funcionario = new Funcionarios();
                funcionario.Nome = txtNome.Text;
                funcionario.EstadoCivil = txtEstadoCivil.Text;
                funcionario.Idade = txtIdade.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Nascimento = Convert.ToDateTime(dtpNascimento.Text);
                funcionario.Matricula = txtMatricula.Text;
                funcionario.Funcao = txtFuncao.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Rg = txtRg.Text;
                funcionario.Pis = txtPis.Text;
                funcionario.CarteiraTrabalho = txtCarteiraTrabalho.Text;

                if (rbM.Checked || rbF.Checked)
                {
                    funcionario.Sexo = rbM.Checked ? 'M' : 'F';
                }
                else
                {
                    MessageBox.Show("Selecione um sexo!");
                    return;
                }

                //abrindo a conexão com banco de dados
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
                    //comando para insercao no banco de dados
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "INSERT INTO FUNCIONARIOS (NOME_FUNCIONARIO,IDADE_FUNCIONARIO,ESTADO_CIVIL_FUNCIONARIO,CPF_FUNCIONARIO,NASCIMENTO_FUNCIONARIO,MATRICULA_FUNCIONARIO,FUNCAO_FUNCIONARIO,ENDERECO_FUNCIONARIO,TELEFONE_FUNCIONARIO,PIS_FUNCIONARIO,CARTEIRA_TRABALHO_FUNCIONARIO,RG_FUNCIONARIO,SEXO_FUNCIONARIO) VALUES (?NOME,?IDADE,?ESTADO_CIVIL,?CPF,?NASCIMENTO,?MATRICULA,?FUNCAO,?ENDERECO,?TELEFONE,?PIS,?CARTEIRA_TRABALHO,?RG,?SEXO)";
                    comando.CommandText = consulta;
                    comando.Parameters.AddWithValue("?NOME", funcionario.Nome);
                    comando.Parameters.AddWithValue("?IDADE", funcionario.Idade);
                    comando.Parameters.AddWithValue("?ESTADO_CIVIL", funcionario.EstadoCivil);
                    comando.Parameters.AddWithValue("?CPF", funcionario.Cpf);
                    comando.Parameters.AddWithValue("?NASCIMENTO", funcionario.Nascimento);
                    comando.Parameters.AddWithValue("?MATRICULA", funcionario.Matricula);
                    comando.Parameters.AddWithValue("?FUNCAO", funcionario.Funcao);
                    comando.Parameters.AddWithValue("?ENDERECO", funcionario.Endereco);
                    comando.Parameters.AddWithValue("?TELEFONE", funcionario.Telefone);
                    comando.Parameters.AddWithValue("?PIS", funcionario.Pis);
                    comando.Parameters.AddWithValue("?CARTEIRA_TRABALHO", funcionario.CarteiraTrabalho);
                    comando.Parameters.AddWithValue("?RG", funcionario.Rg);
                    comando.Parameters.AddWithValue("?SEXO", funcionario.Sexo);

                    //se executo o comando com sucesso
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Funcionario cadastrado com sucesso!");
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
            txtNome.Clear();
            txtEstadoCivil.Clear();
            txtIdade.Clear();
            txtCpf.Clear();
            txtMatricula.Clear();
            txtFuncao.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtRg.Clear();
            txtPis.Clear();
            txtCarteiraTrabalho.Clear();
            rbM.Checked = false;
            rbF.Checked = false;
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtRg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCarteiraTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
