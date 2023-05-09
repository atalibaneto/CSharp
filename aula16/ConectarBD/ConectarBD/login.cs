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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConectarBD
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btbLogin_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "")
            {
                MessageBox.Show("Digite o usuário");
            }
            else if (txbPWD.Text == "")
            {
                MessageBox.Show("Digite a senha");
            }
            else
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        var sql = "SELECT * FROM tbl_Login WHERE usuario = '" + txbUsuario.Text + "' and senha = '" + txbPWD.Text +"'";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            //cmd.Parameters.AddWithValue("@usuario", txbUsuario.Text);
                            //cmd.Parameters.AddWithValue("@senha", txbPWD.Text);
                            //cmd.ExecuteNonQuery();

                            using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    //fill extrai os dados e joga dentro do dt
                                    da.Fill(dt);
                                    //dataGridView1.DataSource = dt;
                                    if (dt.Rows.Count > 0)
                                    {
                                        buscar_livros bl = new buscar_livros();
                                        this.Hide();
                                        bl.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Usuário e/ou senha incorretos!");
                                    }


                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
