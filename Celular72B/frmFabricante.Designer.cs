namespace Celular72B
{
    partial class frmFabricante
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPesquisa = new System.Windows.Forms.TabControl();
            this.tabPesq = new System.Windows.Forms.TabPage();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.chkExcluido = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_Fabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPesquisa.SuspendLayout();
            this.tabPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.tabDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.tabPesq);
            this.tabPesquisa.Controls.Add(this.tabDados);
            this.tabPesquisa.Location = new System.Drawing.Point(12, 12);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.SelectedIndex = 0;
            this.tabPesquisa.Size = new System.Drawing.Size(483, 239);
            this.tabPesquisa.TabIndex = 0;
            // 
            // tabPesq
            // 
            this.tabPesq.Controls.Add(this.dtgPesquisa);
            this.tabPesq.Location = new System.Drawing.Point(4, 22);
            this.tabPesq.Name = "tabPesq";
            this.tabPesq.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesq.Size = new System.Drawing.Size(475, 213);
            this.tabPesq.TabIndex = 0;
            this.tabPesq.Text = "Pesquisa";
            this.tabPesq.UseVisualStyleBackColor = true;
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.AllowUserToAddRows = false;
            this.dtgPesquisa.AllowUserToDeleteRows = false;
            this.dtgPesquisa.AllowUserToResizeColumns = false;
            this.dtgPesquisa.AllowUserToResizeRows = false;
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Location = new System.Drawing.Point(17, 15);
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisa.Size = new System.Drawing.Size(444, 186);
            this.dtgPesquisa.TabIndex = 0;
            this.dtgPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisa_CellDoubleClick);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.chkExcluido);
            this.tabDados.Controls.Add(this.btnExcluir);
            this.tabDados.Controls.Add(this.btnCancelar);
            this.tabDados.Controls.Add(this.btnSalvar);
            this.tabDados.Controls.Add(this.btnNovo);
            this.tabDados.Controls.Add(this.mskCNPJ);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Controls.Add(this.txtNome);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Controls.Add(this.txtId_Fabricante);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(475, 213);
            this.tabDados.TabIndex = 1;
            this.tabDados.Text = "Dados Fabricante";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // chkExcluido
            // 
            this.chkExcluido.AutoSize = true;
            this.chkExcluido.Location = new System.Drawing.Point(310, 20);
            this.chkExcluido.Name = "chkExcluido";
            this.chkExcluido.Size = new System.Drawing.Size(74, 17);
            this.chkExcluido.TabIndex = 21;
            this.chkExcluido.Text = "E&xcluído?";
            this.chkExcluido.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(280, 179);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(105, 179);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 179);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 23);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(105, 123);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(142, 20);
            this.mskCNPJ.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CNPJ.:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 20);
            this.txtNome.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // txtId_Fabricante
            // 
            this.txtId_Fabricante.Location = new System.Drawing.Point(105, 21);
            this.txtId_Fabricante.Name = "txtId_Fabricante";
            this.txtId_Fabricante.Size = new System.Drawing.Size(97, 20);
            this.txtId_Fabricante.TabIndex = 12;
            this.txtId_Fabricante.Validated += new System.EventHandler(this.txtId_Fabricante_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id. Fabricante:";
            // 
            // frmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.tabPesquisa);
            this.Name = "frmFabricante";
            this.Text = "Cadastro de Fabricantes";
            this.Load += new System.EventHandler(this.frmFabricante_Load);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPesquisa;
        private System.Windows.Forms.TabPage tabPesq;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.CheckBox chkExcluido;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Fabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPesquisa;
    }
}

