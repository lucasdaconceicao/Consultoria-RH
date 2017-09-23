using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroEmpresa
{
    class Funcionarios
    {
        private string _nome;
        private string _estadoCivil;
        private string _idade;
        private string _cpf;
        private DateTime _nascimento;
        private string _matricula;
        private string _funcao;
        private string _endereco;
        private string _telefone;
        private string _rg;
        private string _pis;
        private string _carteiraTrabalho;
        private char _sexo;

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

        public string EstadoCivil
        {
            get
            {
                return _estadoCivil;
            }
           
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _estadoCivil = value;
                }
                else
                {
                    throw new Exception("O estado civil não pode ser vazio.");
                }
            }
        }

        public string Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _idade = value;
                }
                else
                {
                    throw new Exception("A idade não pode ser vazio.");
                }
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _cpf = value;
                }
                else
                {
                    throw new Exception("O cpf não pode ser vazio.");
                }
            }
        }

        public DateTime Nascimento
        {
            get
            {
                return _nascimento;
            }

            set
            {
                _nascimento = value;
            }
        }

        public string Matricula
        {
            get
            {
                return _matricula;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _matricula = value;
                }
                else
                {
                    throw new Exception("A matricula não pode ser vazio.");
                }
            }
        }


        public string Funcao
        {
            get
            {
                return _funcao;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _funcao = value;
                }
                else
                {
                    throw new Exception("A função não pode ser vazio.");
                }
            }
        }

        public string Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _endereco = value;
                }
                else
                {
                    throw new Exception("O endereco não pode ser vazio.");
                }
            }
        }

        public string Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _telefone = value;
                }
                else
                {
                    throw new Exception("O telefone não pode ser vazio.");
                }
            }
        }

        public string Rg
        {
            get
            {
                return _rg;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _rg = value;
                }
                else
                {
                    throw new Exception("O Rg não pode ser vazio.");
                }
            }
        }

        public string Pis
        {
            get
            {
                return _pis;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _pis = value;

                }
                else
                {
                    throw new Exception("O Pis não pode ser vazio.");
                }
            }
        }

        public string CarteiraTrabalho
        {
            get
            {
                return _carteiraTrabalho;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _carteiraTrabalho = value;

                }
                else
                {
                    throw new Exception("A carteira de trabalho não pode ser vazio.");
                }
            }
        }

        public char Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }
    }
}
