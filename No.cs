using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class No
    {
        public Pessoa DadosPessoa { get; set; }
        public No NoDireita { get; set; }
        public No NoEsquerda { get; set; }
        public short FatorBalanceamento { get; set; }
        public No(Pessoa dadosPessoa)
        {
            this.DadosPessoa = dadosPessoa;
        }
        public override string ToString()
        {
            if (this.DadosPessoa != null)
            {
                return this.DadosPessoa.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
