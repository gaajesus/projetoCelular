namespace Celular72B
{
    partial class frmProduto
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
            this.tabPesquisa = new System.Windows.Forms.TabControl();
            this.tabPesq = new System.Windows.Forms.TabPage();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numEspessura = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numLargura = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkExcluido = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_Produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabPesquisa.SuspendLayout();
            this.tabPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.tabPesq);
            this.tabPesquisa.Controls.Add(this.tabDados);
            this.tabPesquisa.Location = new System.Drawing.Point(12, 12);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.SelectedIndex = 0;
            this.tabPesquisa.Size = new System.Drawing.Size(577, 313);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPesquisa_Selected);
            // 
            // tabPesq
            // 
            this.tabPesq.Controls.Add(this.dtgPesquisa);
            this.tabPesq.Location = new System.Drawing.Point(4, 22);
            this.tabPesq.Name = "tabPesq";
            this.tabPesq.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesq.Size = new System.Drawing.Size(569, 287);
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
            this.dtgPesquisa.ReadOnly = true;
            this.dtgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisa.Size = new System.Drawing.Size(534, 266);
            this.dtgPesquisa.TabIndex = 0;
            this.dtgPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisa_CellDoubleClick);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.btnSair);
            this.tabDados.Controls.Add(this.cmbFabricante);
            this.tabDados.Controls.Add(this.label10);
            this.tabDados.Controls.Add(this.numPeso);
            this.tabDados.Controls.Add(this.label9);
            this.tabDados.Controls.Add(this.numDesconto);
            this.tabDados.Controls.Add(this.label6);
            this.tabDados.Controls.Add(this.numQuantidade);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.numPreco);
            this.tabDados.Controls.Add(this.label8);
            this.tabDados.Controls.Add(this.numEspessura);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.numLargura);
            this.tabDados.Controls.Add(this.label4);
            this.tabDados.Controls.Add(this.numAltura);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Controls.Add(this.chkExcluido);
            this.tabDados.Controls.Add(this.btnExcluir);
            this.tabDados.Controls.Add(this.btnCancelar);
            this.tabDados.Controls.Add(this.btnSalvar);
            this.tabDados.Controls.Add(this.btnNovo);
            this.tabDados.Controls.Add(this.txtModelo);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Controls.Add(this.txtId_Produto);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(569, 287);
            this.tabDados.TabIndex = 1;
            this.tabDados.Text = "Dados Produto";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(300, 18);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(140, 21);
            this.cmbFabricante.TabIndex = 37;
            this.cmbFabricante.TextChanged += new System.EventHandler(this.cmbFabricante_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Fabricante:";
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 1;
            this.numPeso.Location = new System.Drawing.Point(460, 121);
            this.numPeso.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(84, 20);
            this.numPeso.TabIndex = 35;
            this.numPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Peso:";
            // 
            // numDesconto
            // 
            this.numDesconto.DecimalPlaces = 1;
            this.numDesconto.Location = new System.Drawing.Point(316, 177);
            this.numDesconto.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(84, 20);
            this.numDesconto.TabIndex = 33;
            this.numDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Desconto (%):";
            // 
            // numQuantidade
            // 
            this.numQuantidade.DecimalPlaces = 1;
            this.numQuantidade.Location = new System.Drawing.Point(168, 177);
            this.numQuantidade.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(84, 20);
            this.numQuantidade.TabIndex = 31;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Qtde. Estoque:";
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 1;
            this.numPreco.Location = new System.Drawing.Point(24, 177);
            this.numPreco.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(84, 20);
            this.numPreco.TabIndex = 29;
            this.numPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Preço:";
            // 
            // numEspessura
            // 
            this.numEspessura.DecimalPlaces = 1;
            this.numEspessura.Location = new System.Drawing.Point(316, 121);
            this.numEspessura.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numEspessura.Name = "numEspessura";
            this.numEspessura.Size = new System.Drawing.Size(84, 20);
            this.numEspessura.TabIndex = 27;
            this.numEspessura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Espessura:";
            // 
            // numLargura
            // 
            this.numLargura.DecimalPlaces = 1;
            this.numLargura.Location = new System.Drawing.Point(168, 121);
            this.numLargura.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numLargura.Name = "numLargura";
            this.numLargura.Size = new System.Drawing.Size(84, 20);
            this.numLargura.TabIndex = 25;
            this.numLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLargura.ValueChanged += new System.EventHandler(this.numLargura_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Largura:";
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 1;
            this.numAltura.Location = new System.Drawing.Point(24, 121);
            this.numAltura.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(84, 20);
            this.numAltura.TabIndex = 23;
            this.numAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAltura.ValueChanged += new System.EventHandler(this.numAltura_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Altura:";
            // 
            // chkExcluido
            // 
            this.chkExcluido.AutoSize = true;
            this.chkExcluido.Location = new System.Drawing.Point(470, 20);
            this.chkExcluido.Name = "chkExcluido";
            this.chkExcluido.Size = new System.Drawing.Size(74, 17);
            this.chkExcluido.TabIndex = 21;
            this.chkExcluido.Text = "E&xcluído?";
            this.chkExcluido.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(362, 246);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(146, 246);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(27, 246);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 23);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(105, 56);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(439, 20);
            this.txtModelo.TabIndex = 14;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Modelo: ";
            // 
            // txtId_Produto
            // 
            this.txtId_Produto.Location = new System.Drawing.Point(105, 21);
            this.txtId_Produto.Name = "txtId_Produto";
            this.txtId_Produto.Size = new System.Drawing.Size(97, 20);
            this.txtId_Produto.TabIndex = 12;
            this.txtId_Produto.Validated += new System.EventHandler(this.txtId_Produto_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id. Produto:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(470, 246);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(65, 23);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 340);
            this.Controls.Add(this.tabPesquisa);
            this.Name = "frmProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPesquisa;
        private System.Windows.Forms.TabPage tabPesq;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.CheckBox chkExcluido;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numEspessura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLargura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSair;
    }
}