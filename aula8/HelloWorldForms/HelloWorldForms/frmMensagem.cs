using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForms
{
    public partial class frmMensagem : Form
    {
        public frmMensagem()
        {
            InitializeComponent();
        }

        private void btmMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!!");
        }
    }
}
