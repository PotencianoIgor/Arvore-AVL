using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class ArvoreData
    {
        private No NoRaiz { get; set; }

        private bool Verificar { get; set; }

        public void Inserir(Pessoa dadosPessoa)
        {
            if (this.NoRaiz == null)
            {
                this.NoRaiz = new No(dadosPessoa);
            }
            else
            {
                No novaRaiz = null;
                Inserir(this.NoRaiz, dadosPessoa, out novaRaiz);
                if (novaRaiz != null)
                {
                    this.NoRaiz = novaRaiz;
                }
            }
        }
        private void Inserir(No raiz, Pessoa dadosPessoa, out No novaRaiz)
        {
            novaRaiz = null;
            if (raiz != null)
            {
                if (DateTime.Compare(dadosPessoa.DataNascimento,raiz.DadosPessoa.DataNascimento) < 0)
                {
                    if (raiz.NoEsquerda != null)
                    {
                        Inserir(raiz.NoEsquerda, dadosPessoa, out novaRaiz);
                        if (novaRaiz != null)
                        {
                            raiz.NoEsquerda = novaRaiz;
                        }
                    }
                    else
                    {
                        raiz.NoEsquerda = new No(dadosPessoa);
                        Verificar = true;
                    }
                    if (this.Verificar)
                    {
                        BalancearEsquerda(raiz,out novaRaiz);
                        if (novaRaiz != null)
                        {
                            raiz = novaRaiz;
                        }
                    }
                }
                else
                {
                    if (raiz.NoDireita != null)
                    {
                        Inserir(raiz.NoDireita, dadosPessoa, out novaRaiz);
                        if (novaRaiz != null)
                        {
                            raiz.NoDireita = novaRaiz;
                        }
                    }
                    else
                    {
                        raiz.NoDireita = new No(dadosPessoa);
                        Verificar = true;
                    }
                    if (this.Verificar)
                    {
                        BalancearDireita(raiz, out novaRaiz);
                        if (novaRaiz != null)
                        {
                            raiz = novaRaiz;
                        }
                    }
                }
            }
        }
        //testado**************
        private void BalancearEsquerda(No raiz, out No novaRaiz)
        {
            // se necessario faz o balanceamento
            novaRaiz = null;
            switch (raiz.FatorBalanceamento)
            {
                case 1:
                    raiz.FatorBalanceamento = 0;
                    Verificar = false;
                    break;
                case 0:
                    raiz.FatorBalanceamento = -1;
                    break;
                case -1:
                    //necessita balancear
                    switch (raiz.NoEsquerda.FatorBalanceamento)
                    {
                        case -1:
                            novaRaiz = RotacaoLL(raiz);
                            novaRaiz.FatorBalanceamento = 0;
                            novaRaiz.NoDireita.FatorBalanceamento = 0;
                            break;
                        case 1:
                            raiz.NoEsquerda = RotacaoRR(raiz.NoEsquerda);
                            novaRaiz = RotacaoLL(raiz);
                            if (novaRaiz.FatorBalanceamento == 1)
                            {
                                novaRaiz.NoEsquerda.FatorBalanceamento = -1;
                                novaRaiz.NoDireita.FatorBalanceamento = 0;
                            }
                            else
                            {
                                if (novaRaiz.FatorBalanceamento == -1)
                                {
                                    novaRaiz.NoEsquerda.FatorBalanceamento = 0;
                                    novaRaiz.NoDireita.FatorBalanceamento = 1;
                                }
                                else
                                {
                                    novaRaiz.NoEsquerda.FatorBalanceamento = 0;
                                    novaRaiz.NoDireita.FatorBalanceamento = 0;
                                }
                            }
                            novaRaiz.FatorBalanceamento = 0;
                            break;
                    }
                    break;
            }
        }

        private void BalancearDireita(No raiz, out No novaRaiz)
        {
            novaRaiz = null;
            // se necessario faz o balanceamento
            switch (raiz.FatorBalanceamento)
            {
                case 1:
                    //necessita balancear
                    switch (raiz.NoDireita.FatorBalanceamento)
                    {
                        case 1:
                            novaRaiz = RotacaoRR(raiz);
                            novaRaiz.FatorBalanceamento = 0;
                            novaRaiz.NoEsquerda.FatorBalanceamento = 0;
                            break;
                        case -1:
                            raiz.NoDireita = RotacaoLL(raiz.NoDireita);
                            novaRaiz = RotacaoRR(raiz);
                            if (novaRaiz.FatorBalanceamento == 1)
                            {
                                novaRaiz.NoEsquerda.FatorBalanceamento = -1;
                                novaRaiz.NoDireita.FatorBalanceamento = 0;
                            }
                            else
                            {
                                if (novaRaiz.FatorBalanceamento == -1)
                                {
                                    novaRaiz.NoEsquerda.FatorBalanceamento = 0;
                                    novaRaiz.NoDireita.FatorBalanceamento = 1;
                                }
                                else
                                {
                                    novaRaiz.NoEsquerda.FatorBalanceamento = 0;
                                    novaRaiz.NoDireita.FatorBalanceamento = 0;
                                }
                            }
                            novaRaiz.FatorBalanceamento = 0;
                            break;
                    }
                    break;
                case 0:
                    raiz.FatorBalanceamento = 1;
                    break;
                case -1:
                    raiz.FatorBalanceamento = 0;
                    Verificar = false;
                    break;
            }
        }
        private No RotacaoLL(No raiz)
        {
            No aux = raiz.NoEsquerda;
            No aux2 = aux.NoDireita;
            aux.NoDireita = raiz;
            aux.NoDireita.NoEsquerda = aux2;
            return aux;
        }
        private No RotacaoRR(No raiz)
        {
            No aux = raiz.NoDireita;
            No aux2 = aux.NoEsquerda;
            aux.NoEsquerda = raiz;
            aux.NoEsquerda.NoDireita = aux2;
            return aux;
        }
        private void Buscar(DateTime dataNascimento, No raiz, ref List<Pessoa> pessoas)
        {
            if (raiz != null)
            {
                if (dataNascimento.CompareTo(raiz.DadosPessoa.DataNascimento) < 0)
                {
                    Buscar(dataNascimento,raiz.NoEsquerda,ref pessoas);
                }
                else
                {
                    if (dataNascimento.CompareTo(raiz.DadosPessoa.DataNascimento) > 0)
                    {
                        Buscar(dataNascimento, raiz.NoDireita, ref pessoas);
                    }
                    else
                    {
                        pessoas.Add(raiz.DadosPessoa);
                        Buscar(dataNascimento, raiz.NoDireita, ref pessoas);
                        Buscar(dataNascimento, raiz.NoEsquerda, ref pessoas);
                    }
                }
            }
        }
        public List<Pessoa> Buscar(DateTime dataNascimento)
        {
            if (NoRaiz != null)
            {
                List<Pessoa> pessoas = new List<Pessoa>();
                Buscar(dataNascimento, NoRaiz, ref pessoas);
                if (pessoas.Count == 0)
                {
                    throw new Exception("Pessoa inexistente.");
                }
                return pessoas;
            }
            throw new Exception("Lista Vazia.");
        }
    }
}