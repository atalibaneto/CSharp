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
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        private void frmGridView_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            statusStrip1.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT * FROM tbl_livro";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                    toolStripStatusLabel1.Text = "Pronto";
                    statusStrip1.Refresh();
                    MessageBox.Show("Conectado ao DB");
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar\n\n" +  ex.Message);
            }
        }
    }
}
