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

namespace ConectarBD
{
    public partial class Form3 : Form
    {
        int ID_Livro = 0;
        public Form3(int ID_Livro)
        {
            InitializeComponent();
            this.ID_Livro = ID_Livro;

            //Botão Alterar
            if (this.ID_Livro > 0)
                GetLivro(ID_Livro);
            toolStripStatusLabel1.Text = " ";
            statusStrip1.Refresh();
        }
        public Form3(int ID_Livro, bool excluir)
        {
            InitializeComponent();
            this.ID_Livro = ID_Livro;

            //Botão Excluir
            if (excluir)
                if (this.ID_Livro > 0)
                {
                    GetLivro(ID_Livro);
                    TravarControles();
                    btnAddLivro.Visible = false;
                    btnExcluir.Visible = true;
                    toolStripStatusLabel1.Text = " ";
                    statusStrip1.Refresh();
                }
                else
                    this.Close();
        }
        private void TravarControles()
        {
            txbNomeLivro.Enabled = false;
            txbISBN.Enabled = false;
            textBox1.Enabled = false;
            txbDataPub.Enabled = false;
            txbPreco.Enabled = false;
            textBox2.Enabled = false;
        }
        private void GetLivro(int id)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT * FROM tbl_Livro WHERE ID_Livro = " + ID_Livro;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        toolStripStatusLabel1.Text = "Buscando veículo";
                        statusStrip1.Refresh();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txbNomeLivro.Text = dr["Nome_Livro"].ToString();
                                    txbISBN.Text = dr["ISBN"].ToString();
                                    textBox1.Text = dr["ID_Autor"].ToString();
                                    txbDataPub.Text = dr["Data_Pub"].ToString();
                                    txbPreco.Text = dr["Preco_Livro"].ToString();
                                    textBox2.Text = dr["ID_Editora"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }

        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            adicionarLivro();
        }

        private void adicionarLivro()
        {
            toolStripStatusLabel1.Text = "Connectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sql = " ";

                    if (this.ID_Livro == 0)

                        sql = @"INSERT INTO tbl_Livro (Nome_Livro, ISBN, ID_Autor, Data_Pub, Preco_Livro, ID_Editora) VALUES (@Nome_Livro, @ISBN, @ID_Autor, @Data_Pub, @Preco_Livro, @ID_Editora)";
                    else
                        sql = "UPDATE tbl_Livro SET Nome_Livro=@Nome_Livro, ISBN=@ISBN, ID_Autor=@ID_Autor, Data_Pub=@Data_Pub, Preco_Livro=@Preco_Livro, ID_Editora=@ID_Editora WHERE ID_Livro =" + this.ID_Livro;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        toolStripStatusLabel1.Text = "Salvando";
                        statusStrip1.Refresh();

                        cmd.Parameters.AddWithValue("@Nome_Livro", txbNomeLivro.Text);
                        cmd.Parameters.AddWithValue("@ISBN", txbISBN.Text);
                        cmd.Parameters.AddWithValue("@ID_Autor", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Data_Pub", txbDataPub.Text);
                        cmd.Parameters.AddWithValue("@Preco_Livro", txbPreco.Text.Replace(",", "."));
                        cmd.Parameters.AddWithValue("@ID_Editora", textBox2.Text);
                        cmd.ExecuteNonQuery();
                    }
                    toolStripStatusLabel1.Text = "Pronto";
                    statusStrip1.Refresh();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir:", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                ExcluirVeiculo();
                this.Close();
            }
        }
        private void ExcluirVeiculo()
        {
            toolStripStatusLabel1.Text = "Connectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "DELETE FROM tbl_Livro WHERE ID_Livro =" + ID_Livro;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        toolStripStatusLabel1.Text = "Excluindo Veículo";
                        statusStrip1.Refresh();

                        cmd.ExecuteNonQuery();
                    }

                    toolStripStatusLabel1.Text = "Pronto";
                    statusStrip1.Refresh();

                }

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }

        }
    }
}
