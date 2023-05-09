using System.Data.SqlClient;

namespace ConectarBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    toolStripStatusLabel1.Text = "Conectado";
                    statusStrip1.Refresh();
                    MessageBox.Show("Conectado ao DB", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao conectar\n\n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            statusStrip1.Refresh();

        }
    }
}