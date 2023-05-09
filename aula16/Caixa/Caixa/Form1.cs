namespace Caixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);

            resultado = valor1 - valor2;
            textBox3.Text = resultado.ToString();



        }


    }
}