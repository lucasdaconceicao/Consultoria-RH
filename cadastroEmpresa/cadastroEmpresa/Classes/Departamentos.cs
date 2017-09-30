using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroEmpresa
{
    class Departamentos
    {
      private string  _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O nome não pode ser vazio.");
                }
            }
        }
    }
}
