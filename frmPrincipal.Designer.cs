namespace Arvore
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ui_btnAbrirArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ui_grdPessoas = new System.Windows.Forms.DataGridView();
            this.coluna_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_Naturalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_pnlProcessando = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_rdbCPF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ui_btnFiltrar = new System.Windows.Forms.Button();
            this.ui_dttDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.ui_txtNome = new System.Windows.Forms.TextBox();
            this.ui_txtCPF = new System.Windows.Forms.TextBox();
            this.ui_rdbData = new System.Windows.Forms.RadioButton();
            this.ui_rdbNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ui_grdPessoas)).BeginInit();
            this.ui_pnlProcessando.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_btnAbrirArquivo
            // 
            this.ui_btnAbrirArquivo.Location = new System.Drawing.Point(12, 12);
            this.ui_btnAbrirArquivo.Name = "ui_btnAbrirArquivo";
            this.ui_btnAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.ui_btnAbrirArquivo.TabIndex = 0;
            this.ui_btnAbrirArquivo.Text = "Abrir Arquivo";
            this.ui_btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.ui_btnAbrirArquivo.Click += new System.EventHandler(this.ui_btnAbrirArquivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Arquivo Texto|*.txt";
            // 
            // ui_grdPessoas
            // 
            this.ui_grdPessoas.AllowUserToOrderColumns = true;
            this.ui_grdPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ui_grdPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ui_grdPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna_CPF,
            this.coluna_RG,
            this.coluna_Nome,
            this.coluna_DataNascimento,
            this.coluna_Naturalidade});
            this.ui_grdPessoas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ui_grdPessoas.Location = new System.Drawing.Point(10, 41);
            this.ui_grdPessoas.Name = "ui_grdPessoas";
            this.ui_grdPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ui_grdPessoas.Size = new System.Drawing.Size(737, 305);
            this.ui_grdPessoas.TabIndex = 1;
            this.ui_grdPessoas.VirtualMode = true;
            // 
            // coluna_CPF
            // 
            this.coluna_CPF.DataPropertyName = "CPF";
            this.coluna_CPF.FillWeight = 80F;
            this.coluna_CPF.HeaderText = "CPF";
            this.coluna_CPF.Name = "coluna_CPF";
            this.coluna_CPF.ReadOnly = true;
            this.coluna_CPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // coluna_RG
            // 
            this.coluna_RG.DataPropertyName = "RG";
            this.coluna_RG.FillWeight = 50F;
            this.coluna_RG.HeaderText = "RG";
            this.coluna_RG.Name = "coluna_RG";
            this.coluna_RG.ReadOnly = true;
            // 
            // coluna_Nome
            // 
            this.coluna_Nome.DataPropertyName = "Nome";
            this.coluna_Nome.FillWeight = 220F;
            this.coluna_Nome.HeaderText = "Nome";
            this.coluna_Nome.Name = "coluna_Nome";
            this.coluna_Nome.ReadOnly = true;
            // 
            // coluna_DataNascimento
            // 
            this.coluna_DataNascimento.DataPropertyName = "DataNascimento";
            this.coluna_DataNascimento.FillWeight = 70F;
            this.coluna_DataNascimento.HeaderText = "Nascimento";
            this.coluna_DataNascimento.Name = "coluna_DataNascimento";
            this.coluna_DataNascimento.ReadOnly = true;
            // 
            // coluna_Naturalidade
            // 
            this.coluna_Naturalidade.DataPropertyName = "Naturalidade";
            this.coluna_Naturalidade.FillWeight = 130F;
            this.coluna_Naturalidade.HeaderText = "Naturalidade";
            this.coluna_Naturalidade.Name = "coluna_Naturalidade";
            this.coluna_Naturalidade.ReadOnly = true;
            // 
            // ui_pnlProcessando
            // 
            this.ui_pnlProcessando.Controls.Add(this.label1);
            this.ui_pnlProcessando.Location = new System.Drawing.Point(209, 182);
            this.ui_pnlProcessando.Name = "ui_pnlProcessando";
            this.ui_pnlProcessando.Size = new System.Drawing.Size(338, 100);
            this.ui_pnlProcessando.TabIndex = 2;
            this.ui_pnlProcessando.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carregando...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ui_rdbCPF
            // 
            this.ui_rdbCPF.AutoSize = true;
            this.ui_rdbCPF.Checked = true;
            this.ui_rdbCPF.Location = new System.Drawing.Point(6, 19);
            this.ui_rdbCPF.Name = "ui_rdbCPF";
            this.ui_rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.ui_rdbCPF.TabIndex = 2;
            this.ui_rdbCPF.TabStop = true;
            this.ui_rdbCPF.Text = "CPF";
            this.ui_rdbCPF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ui_btnFiltrar);
            this.groupBox1.Controls.Add(this.ui_dttDataNascimento);
            this.groupBox1.Controls.Add(this.ui_txtNome);
            this.groupBox1.Controls.Add(this.ui_txtCPF);
            this.groupBox1.Controls.Add(this.ui_rdbData);
            this.groupBox1.Controls.Add(this.ui_rdbNome);
            this.groupBox1.Controls.Add(this.ui_rdbCPF);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // ui_btnFiltrar
            // 
            this.ui_btnFiltrar.Location = new System.Drawing.Point(639, 42);
            this.ui_btnFiltrar.Name = "ui_btnFiltrar";
            this.ui_btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.ui_btnFiltrar.TabIndex = 8;
            this.ui_btnFiltrar.Text = "Filtrar";
            this.ui_btnFiltrar.UseVisualStyleBackColor = true;
            this.ui_btnFiltrar.Click += new System.EventHandler(this.ui_btnFiltrar_Click);
            // 
            // ui_dttDataNascimento
            // 
            this.ui_dttDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ui_dttDataNascimento.Location = new System.Drawing.Point(57, 68);
            this.ui_dttDataNascimento.Name = "ui_dttDataNascimento";
            this.ui_dttDataNascimento.Size = new System.Drawing.Size(115, 20);
            this.ui_dttDataNascimento.TabIndex = 7;
            this.ui_dttDataNascimento.Value = new System.DateTime(2015, 5, 18, 0, 0, 0, 0);
            // 
            // ui_txtNome
            // 
            this.ui_txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ui_txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_txtNome.Location = new System.Drawing.Point(57, 42);
            this.ui_txtNome.Name = "ui_txtNome";
            this.ui_txtNome.Size = new System.Drawing.Size(245, 19);
            this.ui_txtNome.TabIndex = 5;
            // 
            // ui_txtCPF
            // 
            this.ui_txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_txtCPF.Location = new System.Drawing.Point(57, 16);
            this.ui_txtCPF.MaxLength = 11;
            this.ui_txtCPF.Name = "ui_txtCPF";
            this.ui_txtCPF.Size = new System.Drawing.Size(115, 19);
            this.ui_txtCPF.TabIndex = 3;
            this.ui_txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ui_txtCPF_KeyPress);
            // 
            // ui_rdbData
            // 
            this.ui_rdbData.AutoSize = true;
            this.ui_rdbData.Location = new System.Drawing.Point(6, 71);
            this.ui_rdbData.Name = "ui_rdbData";
            this.ui_rdbData.Size = new System.Drawing.Size(48, 17);
            this.ui_rdbData.TabIndex = 6;
            this.ui_rdbData.Text = "Data";
            this.ui_rdbData.UseVisualStyleBackColor = true;
            // 
            // ui_rdbNome
            // 
            this.ui_rdbNome.AutoSize = true;
            this.ui_rdbNome.Location = new System.Drawing.Point(6, 42);
            this.ui_rdbNome.Name = "ui_rdbNome";
            this.ui_rdbNome.Size = new System.Drawing.Size(53, 17);
            this.ui_rdbNome.TabIndex = 4;
            this.ui_rdbNome.Text = "Nome";
            this.ui_rdbNome.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ui_pnlProcessando);
            this.Controls.Add(this.ui_grdPessoas);
            this.Controls.Add(this.ui_btnAbrirArquivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            ((System.ComponentModel.ISupportInitialize)(this.ui_grdPessoas)).EndInit();
            this.ui_pnlProcessando.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ui_btnAbrirArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView ui_grdPessoas;
        private System.Windows.Forms.Panel ui_pnlProcessando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ui_rdbCPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ui_btnFiltrar;
        private System.Windows.Forms.DateTimePicker ui_dttDataNascimento;
        private System.Windows.Forms.TextBox ui_txtNome;
        private System.Windows.Forms.TextBox ui_txtCPF;
        private System.Windows.Forms.RadioButton ui_rdbData;
        private System.Windows.Forms.RadioButton ui_rdbNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Naturalidade;
    }
}

