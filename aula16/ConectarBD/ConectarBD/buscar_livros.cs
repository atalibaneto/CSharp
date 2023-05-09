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
    public partial class buscar_livros : Form
    {
        public buscar_livros()
        {
            InitializeComponent();
            //mensagem do Status Strip
            toolStripStatusLabel1.Text = " ";
            statusStrip1.Refresh();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //mensagem do Status Strip
            toolStripStatusLabel1.Text = "Conectando...";
            statusStrip1.Refresh();
            //try - tentando abrir o banco
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sqlQuery = "SELECT * FROM tbl_Livro WHERE Nome_Livro LIKE '%" + textBox1.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            //fill extrai os dados e joga dentro do dt
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
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



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(0);
            frm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            Form3 frm = new Form3(id);
            frm.ShowDialog();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            Form3 frm = new Form3(id, true);
            frm.ShowDialog();
        }
    }
}