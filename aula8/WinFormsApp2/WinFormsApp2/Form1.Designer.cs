namespace WinFormsApp2
{
    partial class Form1
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
            brnFornecedores = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(136, 95);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(95, 53);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Cadastro de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(294, 95);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(95, 53);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Cadastro de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            // 
            // brnFornecedores
            // 
            brnFornecedores.Location = new Point(446, 95);
            brnFornecedores.Name = "brnFornecedores";
            brnFornecedores.Size = new Size(95, 53);
            brnFornecedores.TabIndex = 2;
            brnFornecedores.Text = "Cadastro de Fornecedores";
            brnFornecedores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(brnFornecedores);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProdutos;
        private Button brnFornecedores;
    }
}