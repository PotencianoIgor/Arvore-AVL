using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class Pessoa
    {
        public long CPF { get; set; }
        public long RG { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }


        public Pessoa(long cpf, long rg, string nome, DateTime nascimento, string naturalidade)
        {
            this.CPF = cpf;
            this.RG = rg;
            this.Nome = nome;
            this.DataNascimento = nascimento;
            this.Naturalidade = naturalidade;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.CPF, this.Nome ?? string.Empty);
        }
    }
}
