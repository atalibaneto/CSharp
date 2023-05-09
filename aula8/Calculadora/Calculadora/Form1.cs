namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);

            resultado = valor1 - valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);

            resultado = valor1 / valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString();
        }
    }
}