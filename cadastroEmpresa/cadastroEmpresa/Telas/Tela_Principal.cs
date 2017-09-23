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
    }
}
