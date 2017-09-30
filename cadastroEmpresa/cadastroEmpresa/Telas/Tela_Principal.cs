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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario tela = new CadastroFuncionario();
            tela.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario tela = new ConsultaFuncionario();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroUsuario tela = new CadastroUsuario();
            tela.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuario tela = new ConsultaUsuario();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastro_Departamento tela = new Cadastro_Departamento();
            tela.ShowDialog();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Departamento tela = new Consulta_Departamento();
            tela.ShowDialog();
        }
    }
}
