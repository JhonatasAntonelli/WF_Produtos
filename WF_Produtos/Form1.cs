using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Net.Mime.MediaTypeNames;

namespace WF_Produtos
{
    public partial class Frm_adicionarProdutos : Form
    {
        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=123456;database=db_lojaProdutos";
        public Frm_adicionarProdutos()
        {
            InitializeComponent();

            list_buscarProduto.View = View.Details;
            list_buscarProduto.LabelEdit = true;
            list_buscarProduto.AllowColumnReorder = true;
            list_buscarProduto.FullRowSelect = true;
            list_buscarProduto.GridLines = true;

            list_buscarProduto.Columns.Add("ID", 30, HorizontalAlignment.Left);
            list_buscarProduto.Columns.Add("codigo", 150, HorizontalAlignment.Left);
            list_buscarProduto.Columns.Add("nome", 150, HorizontalAlignment.Left);
            list_buscarProduto.Columns.Add("descricao", 150, HorizontalAlignment.Left);
            list_buscarProduto.Columns.Add("quantidade", 50, HorizontalAlignment.Left);
            list_buscarProduto.Columns.Add("preco", 50, HorizontalAlignment.Left);

            
        }

        private void Frm_adicionarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {    
                Conexao = new MySqlConnection(data_source);

                if (ValidarForm() == true)
                {

                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    String sql = "INSERT INTO produtos(codigo, nome, descricao, quantidade, preco)" +
                        "VALUES " +
                        "('" + txt_codigoProduto.Text + "','" + txt_nomeProduto.Text + "', '" + txt_descricaoProduto.Text +
                        "', '" + Convert.ToInt32(txt_quantidadeProduto.Text) + "', '" + Convert.ToDouble(txt_precoProduto.Text) + "') ";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);


                    comando.ExecuteReader();

                    MessageBox.Show("Produto inserido com sucesso!");

                    LimpaForm();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured: " + ex.Message, 
                                "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            finally
            {
                Conexao.Close();
            }
        }
        private void LimpaForm()
        {
            txt_codigoProduto.Clear();
            txt_nomeProduto.Clear();
            txt_descricaoProduto.Clear();
            txt_quantidadeProduto.Clear();
            txt_precoProduto.Clear();
        }

        private void Btn_buscarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + Txt_buscarProduto.Text + "%'";
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " + "FROM produtos " +
                             "WHERE codigo LIKE " + q + "OR nome LIKE " + q;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
               

                MySqlDataReader reader = comando.ExecuteReader();

                list_buscarProduto.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                    };
                
                var linha_listview = new ListViewItem(row);
                list_buscarProduto.Items.Add(linha_listview);

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();               
            }
        }     

        private void btn_removerID_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Open();            

            string sql = "DELETE FROM produtos WHERE ID = " + Convert.ToInt32(txt_RemoverID.Text);

            MySqlCommand comando = new MySqlCommand(sql, Conexao);

            comando.ExecuteReader();

            MessageBox.Show("Produto Removido com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Conexao.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao.Open();

                String sql = "UPDATE produtos SET codigo = " + txt_codigoEditar.Text +
                            ", nome = "+ txt_nomeEditar.Text +
                            ", descricao = " + txt_descricaoEditar.Text +
                            ", quantidade = " + txt_quantidadeEditar.Text +
                            ", preco = " + txt_precoEditar.Text +
                            " WHERE ID = " + Convert.ToInt32(txt_idEditar.Text);



                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.ExecuteReader();

                MessageBox.Show("Produto Editado com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Conexao.Close();
            }
        }
        private bool ValidarForm()
        {
            var result = true;
            
                if (string.IsNullOrEmpty(txt_codigoProduto.Text))
                {
                    MessageBox.Show("O código do produto é obrigatório");
                    txt_codigoProduto.Focus();
                    result = false;
                }
                if (string.IsNullOrEmpty(txt_nomeProduto.Text))
                {
                    MessageBox.Show("O nome do produto é obrigatório");
                    txt_nomeProduto.Focus();
                    result = false;
                }
                if (string.IsNullOrEmpty(txt_descricaoProduto.Text))
                {
                    MessageBox.Show("A descrição do produto é obrigatória");
                    txt_descricaoProduto.Focus();
                    result = false;
                }
               
            return result;
        }

        private void txt_quantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_precoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_idEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_quantidadeEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_precoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
