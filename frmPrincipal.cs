using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Arvore
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private string PathArquivo { get; set; }
        private List<Pessoa> _Pessoas;
        public List<Pessoa> Pessoas
        {
            get
            {
                if (this._Pessoas == null)
                {
                    this._Pessoas = new List<Pessoa>();
                }
                return this._Pessoas;
            }
        }
        private ArvoreData _Datas;
        public ArvoreData Datas
        {
            get
            {
                if (this._Datas == null)
                {
                    this._Datas = new ArvoreData();
                }
                return this._Datas;
            }
        }
        private ArvoreCpf _CPFs;
        public ArvoreCpf CPFs
        {
            get
            {
                if (this._CPFs == null)
                {
                    this._CPFs = new ArvoreCpf();
                }
                return this._CPFs;
            }
        }
        private ArvoreNome _Nomes;
        public ArvoreNome Nomes
        {
            get
            {
                if (this._Nomes == null)
                {
                    this._Nomes = new ArvoreNome();
                }
                return this._Nomes;
            }
        }
        private void ui_btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.PathArquivo = openFileDialog1.FileName;
                this.ui_pnlProcessando.Visible = true;
                this.ui_btnAbrirArquivo.Enabled = false;
                Thread thread = new Thread(AbrirArquivo);
                thread.IsBackground = true;
                thread.Start();
                while (thread.IsAlive)
                {
                    try
                    {
                        Thread.Sleep(300);
                        Application.DoEvents();
                    }
                    catch
                    {

                    }
                }
                this.ui_grdPessoas.DataSource = this.Pessoas;
                this.ui_pnlProcessando.Visible = false;
                this.ui_btnAbrirArquivo.Enabled = true;
            }
        }
        private void AbrirArquivo()
        {
            this.Pessoas.Clear();
            List<string> erros = new List<string>();
            if (File.Exists(this.PathArquivo))
            {
                using (StreamReader sr = new StreamReader(this.PathArquivo))
                {
                    int numeroLinha = 0;
                    while (!sr.EndOfStream)
                    {
                        numeroLinha++;
                        string linha = sr.ReadLine();
                        string[] partes = linha.Split(new char[] { ';' });
                        if (partes.Length == 5)
                        {
                            try
                            {
                                Pessoa pessoa = new Pessoa(

                                        Convert.ToInt64(partes[0]),
                                        Convert.ToInt32(partes[1]),
                                        partes[2],
                                        Convert.ToDateTime(partes[3]),
                                        partes[4]
                                            );
                                this.Pessoas.Add(pessoa);
                                this.Datas.Inserir(pessoa);
                                this.CPFs.Inserir(pessoa);
                                this.Nomes.Inserir(pessoa);

                            }
                            catch (Exception erro)
                            {
                                erros.Add(string.Format("Erro ao ler a linha: {0} - Erro: {1}", numeroLinha, erro.Message));
                            }
                        }

                    }
                    sr.Close();
                }

            }
        }

        private void ui_btnFiltrar_Click(object sender, EventArgs e)
        {

             /*ArvoreCpf ArvCpf = new ArvoreCpf();
             ArvoreData ArvData = new ArvoreData();
             ArvoreNome ArvNome = new ArvoreNome();
             foreach (Pessoa pessoa in this.Pessoas)
             {
                 ArvCpf.Inserir(pessoa);
                 ArvData.Inserir(pessoa);
                 ArvNome.Inserir(pessoa);
             }*/
             if (this.ui_rdbCPF.Checked)
             {
                 string CPF = this.ui_txtCPF.Text;
                 if (string.IsNullOrEmpty(CPF))
                 {
                     MessageBox.Show(this, "Informe um CPF Válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }

                 try
                 {
                     Pessoa pessoa = CPFs.Buscar(Convert.ToInt64(CPF));
                     this.ui_grdPessoas.DataSource = new List<Pessoa>() { pessoa };
                 }
                 catch (Exception erro)
                 {
                     MessageBox.Show(this, string.Format("Erro ao consultar o CPF!\nErro: {0}", erro.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             else
                 if (this.ui_rdbNome.Checked)
                 {
                     string Nome = this.ui_txtNome.Text;
                     if (string.IsNullOrEmpty(Nome))
                     {
                         MessageBox.Show(this, "Informe um Nome Válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         return;
                     }

                     try
                     {
                         List<Pessoa> pessoas = this.Nomes.Buscar(Nome);
                         this.ui_grdPessoas.DataSource = pessoas;
                     }
                     catch (Exception erro)
                     {
                         MessageBox.Show(this, string.Format("Erro ao consultar o Nome!\nErro: {0}", erro.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
                 else
                 {
                     if (this.ui_rdbData.Checked)
                     {
                         DateTime dataNascimento = ui_dttDataNascimento.Value.Date;

                         try
                         {
                             List<Pessoa> pessoas = this.Datas.Buscar(dataNascimento);
                             this.ui_grdPessoas.DataSource = pessoas;

                         }
                         catch (Exception erro)
                         {
                             MessageBox.Show(this, string.Format("Erro ao consultar Data!\nErro: {0}", erro.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }

                     }
                 }
        }

        private void ui_txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }
    }
}
