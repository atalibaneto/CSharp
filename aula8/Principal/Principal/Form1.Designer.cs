namespace Principal
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnProdutos = new Button();
            btnFornecedores = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(55, 52);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(85, 43);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Cadastro de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(283, 52);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(85, 43);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Cadastro de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnFornecedores
            // 
            btnFornecedores.Location = new Point(519, 52);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Size = new Size(91, 43);
            btnFornecedores.TabIndex = 3;
            btnFornecedores.Text = "Cadastro de Fornecedores";
            btnFornecedores.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 381);
            Controls.Add(btnFornecedores);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnClientes;
        private Button btnProdutos;
        private Button btnFornecedores;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
    }
}