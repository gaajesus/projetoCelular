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
    public partial class frmFabricante : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringSQl = "Server=localhost;Port=5432;Database=celular72B;" +
                                    "User Id=postgres; Password=postgres;";

        public frmFabricante()
        {
            InitializeComponent();
            cn.ConnectionString = stringSQl;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql;
            //  Testes de consistências ...
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("informe o nome do fabricante !!!",
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cnpj", mskCNPJ.Text);
                if (!txtId_Fabricante.Enabled)
                    sql = "insert into fabricante (nome, cnpj) " +
                                "values (@nome, @cnpj)";
                else
                {
                    sql = "update fabricante set " +
                                "nome = @nome," +
                                "cnpj = @cnpj " +
                           "where id_fabricante = @id_fabricante";
                    cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtId_Fabricante.Text));
                }
                cn.Open();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fabricante salvo com sucesso !!!",
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                LimpaForm();
                txtId_Fabricante.Enabled = true;
                txtId_Fabricante.Focus();
                cn.Close();
                CarregarPesquisa();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                    "\nMais detalhes: Este CNPJ já está cadastrado !!! Verifiqe.",
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                cn.Close();
            }
        } 
        private void txtId_Fabricante_Validated(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtId_Fabricante.Text))
                    {
                    sql = "select * from fabricante " +
                                "where id_fabricante = @id_fabricante";
                    cn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtId_Fabricante.Text));
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtNome.Text = (string)dr["nome"];
                        mskCNPJ.Text = (string)dr["cnpj"];
                    }
                    else
                    {
                        MessageBox.Show("Fabricante não encontrado !!!",
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        txtId_Fabricante.Focus();
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                cn.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            txtId_Fabricante.Enabled = false;
            txtNome.Focus();
        }

        private void LimpaForm()
        {
            txtId_Fabricante.Clear();
            txtNome.Clear();
            mskCNPJ.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            LimpaForm();
            txtId_Fabricante.Enabled = true;
            txtId_Fabricante.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql;
            DialogResult resposta;
            try
            {
                resposta = MessageBox.Show("Deseja realmente excluir o fabricante " +
                                            txtNome.Text + " ?",
                                    "Celular 72B",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    sql = "delete from fabricante " +
                                "where id_fabricante = @id_fabricante";
                    cn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtId_Fabricante.Text));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Fabricante excluido com sucesso!!!",
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    LimpaForm();
                    txtId_Fabricante.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a execução do processo !!!" +
                                        "\nMais detalhes: " + ex.Message,
                                    "Celular 72B",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                cn.Close();
            }
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            CarregarPesquisa();
        }

        private void CarregarPesquisa()
        {
            string sql = "select * from fabricante order by nome";


            cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            ds.Clear();

            da.Fill(ds);

            dtgPesquisa.DataSource = ds.Tables[0];

            cn.Close();

        }

        private void dtgPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 id = (long)dtgPesquisa.Rows[e.RowIndex].Cells[0].Value;
            tabPesquisa.SelectTab("tabDados");
            txtId_Fabricante.Text = id.ToString();
            txtId_Fabricante_Validated(txtId_Fabricante, e);
        }
    }
}
