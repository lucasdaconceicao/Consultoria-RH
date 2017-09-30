using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroEmpresa
{
    class Usuarios
    {
        private string _login;
        private string _senha;

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _login = value;
                }
                else
                {
                    throw new Exception("O login não pode ser vazio.");
                }
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _senha = value;
                }
                else
                {
                    throw new Exception("A senha não pode ser vazia.");
                }
            }
        }
    }
}
