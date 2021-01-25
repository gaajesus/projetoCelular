using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Celular72B
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void txtId_Produto_Validated(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtId_Produto.Text))
                {
                    sql = "select * from aparelho where id_aparelho = @1";

                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(txtId_Produto.Text));

                    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                    if (dr.Read())
                    {
                        txtModelo.Text = dr["modelo"].ToString();
                        numAltura.Value = (decimal)dr["altura"];
                        numEspessura.Value = (decimal)dr["espessura"];
                        numLargura.Value = (decimal)dr["largura"];
                        numPeso.Value = (decimal)dr["peso"];
                        numPreco.Value = (decimal)dr["preco"];
                        numDesconto.Value = (decimal)dr["desconto"];
                        numQuantidade.Value = (int)dr["quantidade"];
                        cmbFabricante.SelectedValue = (Int64)dr["id_fabricante"];
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado !!!",
                                "Celular 72B",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        LimpaForm();
                        txtId_Produto.Focus();
                    }
                    dr.Close();
                    HabilitaBotoes(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            CarregarAparelho();
            CarregarFabricante();
        }

        private void CarregarAparelho()
        {
            try
            {
                string sql;

                sql = "select aparelho.id_aparelho, aparelho.modelo, " +
                                "fabricante.nome as Fabricante, " +
                                "aparelho.quantidade as Qtde_Estoque, " +
                                "aparelho.preco " +
                      "from aparelho inner join fabricante " +
                                "on aparelho.id_fabricante = fabricante.id_fabricante " +
                      "order by aparelho.modelo";
                DataTable dt = new DataTable();
                dt = ConexaoBanco.selecionarDataTable(sql);
                dtgPesquisa.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }
        private void CarregarFabricante()
        {
            try
            {
                string sql;

                sql = "select id_fabricante, nome  from fabricante " +
                           "order by nome";
                DataTable dt = new DataTable();
                dt = ConexaoBanco.selecionarDataTable(sql);

                cmbFabricante.DataSource = dt;
                cmbFabricante.DisplayMember = "nome";
                cmbFabricante.ValueMember = "id_fabricante";
                cmbFabricante.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql;

            try
            {
                //  Testes de consistências ...
                if (String.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    MessageBox.Show("informe o modelo do Produto !!!",
                                        "Celular 72B",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    txtModelo.Focus();
                    return;
                }
                if (cmbFabricante.SelectedIndex == -1)
                {
                    MessageBox.Show("Escolha o fabricante do Produto !!!",
                                        "Celular 72B",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    cmbFabricante.Focus();
                    return;
                }

                List<object> param = new List<object>();
                // Obtem o ID do fabricante selecionado no combo Fabricante
                param.Add((Int64)cmbFabricante.SelectedValue);
                param.Add((string)txtModelo.Text);
                param.Add((decimal)numAltura.Value);
                param.Add((decimal)numLargura.Value);
                param.Add((decimal)numEspessura.Value);
                param.Add((decimal)numPeso.Value);
                param.Add((decimal)numPreco.Value);
                param.Add((int)numQuantidade.Value);
                param.Add((decimal)numDesconto.Value);
                if (!txtId_Produto.Enabled)
                    sql = "insert into aparelho (" +
                                "id_fabricante, " +
                                "modelo, " +
                                "altura, " +
                                "largura, " +
                                "espessura, " +
                                "peso, " +
                                "preco, " +
                                "quantidade, " +
                                "desconto) " +
                          "values (@1, @2, @3, @4, @5, @6, @7, @8, @9)";
                else
                {
                    sql = "update aparelho set " +
                                "id_fabricante = @1, " +
                                "modelo = @2, " +
                                "altura = @3, " +
                                "largura = @4, " +
                                "espessura = @5, " +
                                "peso = @6, " +
                                "preco = @7, " +
                                "quantidade = @8, " +
                                "desconto = @9 " +
                           "where id_aparelho = @10";
                     param.Add(Convert.ToInt64(txtId_Produto.Text));
                }
                ConexaoBanco.executar(sql, param);
                MessageBox.Show("Aparelho salvo com sucesso !!!",
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                LimpaForm();
                HabilitaBotoes(false);
                txtId_Produto.Enabled = true;
                txtId_Produto.Focus();               
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

        private void dtgPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 id = (long)dtgPesquisa.Rows[e.RowIndex].Cells[0].Value;
            tabPesquisa.SelectTab("tabDados");
            txtId_Produto.Text = id.ToString();
            txtId_Produto_Validated(txtId_Produto, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            HabilitaBotoes(true);
            txtId_Produto.Enabled = false;
            txtModelo.Focus();
        }

        private void LimpaForm()
        {
            txtId_Produto.Clear();
            txtModelo.Clear();
            cmbFabricante.SelectedIndex = -1;
            numAltura.Value = 0;
            numLargura.Value = 0;
            numEspessura.Value = 0;
            numPeso.Value = 0;
            numPreco.Value = 0;
            numDesconto.Value = 0;
            numQuantidade.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaForm();
            HabilitaBotoes(false);
            txtId_Produto.Enabled = true;
            txtId_Produto.Focus();
        }

        private void tabPesquisa_Selected(object sender, TabControlEventArgs e)
        {
            if (tabPesquisa.SelectedIndex == 0)
            {
                CarregarAparelho();
            }
        }

        private void HabilitaBotoes(bool edicao = true)
        {
            btnNovo.Enabled = !edicao;
            btnSalvar.Enabled = edicao;
            btnCancelar.Enabled = edicao;
            btnExcluir.Enabled = !edicao;
            btnSair.Enabled = !edicao;
        }


        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotoes(true);
        }

        private void cmbFabricante_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotoes(true);
        }

        private void numAltura_ValueChanged(object sender, EventArgs e)
        {
            HabilitaBotoes(true);
        }

        private void numLargura_ValueChanged(object sender, EventArgs e)
        {
            HabilitaBotoes(true);
        }
    }
}
