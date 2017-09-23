using Gerenciamento_Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroEmpresa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //caminho onde sera criado a string de conexao com banco de dados
                string caminhoStringConexao = Application.StartupPath + "/stringConexao.txt";
                //string de conexao com banco de dados
                string stringConexao = "Server=localhost;Port=3306;Database=EMPRESA;Uid=administrator;Pwd=1234;";
                //criar arquivo txt com a string de conexao
                StreamWriter sw = new StreamWriter(caminhoStringConexao);
                sw.WriteLine(stringConexao);
                sw.Dispose();

                //caminho onde sera criado o login
                string caminhoLogin = Application.StartupPath + "/Login.txt";
                //Login
                string stringLogin = "admin" + "|" + "123";
                //criar arquivo txt com os dados do login
                StreamWriter login = new StreamWriter(caminhoLogin);
                login.WriteLine(stringLogin);
                login.Dispose();
                
                //Chamar o login antes de iniciar a aplicação
                Frm_Login fLogin = new Frm_Login();
                fLogin.ShowDialog();
              
                Application.Run(new Tela_Principal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

