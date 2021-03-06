﻿using MySql.Data.MySqlClient;
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
    public partial class ConsultaFuncionario : Form
    {

        string stringConexao = "Server=localhost;Port=3306;Database=EMPRESA;Uid=administrator;Pwd=1234;";
        public ConsultaFuncionario()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            //conexao com o banco de dados
            MySqlConnection conn = new MySqlConnection(this.stringConexao);
            try
            {
                //verificando se o campo da busca nao esta vazio
                if (String.IsNullOrEmpty(txtNomeBusca.Text))
                {
                    MessageBox.Show("O campo para busca nao pode ser vazio!");
                    return;
                }

                //abrindo a conexao com o bd
                conn.Open();

                //Criando um objeto Reader;
                MySqlDataReader MysqlReader = null;

                if (conn.State == ConnectionState.Open)
                {
                    //consulta no bd
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "SELECT * FROM FUNCIONARIOS WHERE NOME_FUNCIONARIO LIKE'%" + txtNomeBusca.Text + "%'";
                    comando.CommandText = consulta;

                    //retornando os dados da query
                    MysqlReader = comando.ExecuteReader();

                    //verificando se existe registro
                    if (MysqlReader.HasRows == false)
                    {
                        MessageBox.Show("Nao existe registro!");
                        txtNomeBusca.Clear();
                        return;
                    }

                    //limpar linhas grid
                    dgvFuncionario.Rows.Clear();
                    //Percorrendo a consulta e adicionando os valores em cada linha
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        dgvFuncionario.Rows.Add(valores);
                    }
                }
                txtNomeBusca.Clear();

                btnExcluir.Enabled = true;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //conexao com o banco de dados
            MySqlConnection conn = new MySqlConnection(this.stringConexao);
            try
            {
                int codigo = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value.ToString());
                //abrindo a conexao com o bd
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "DELETE FROM FUNCIONARIOS WHERE ID_FUNCIONARIO=" + codigo + "";
                    comando.CommandText = consulta;

                    //se executo o comando com sucesso
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Funcionario excluido com sucesso!");
                        dgvFuncionario.Rows.Clear();
                        btnExcluir.Enabled = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
