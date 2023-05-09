namespace ConectarBD
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPagina = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbNomeLivro = new TextBox();
            txbISBN = new TextBox();
            textBox1 = new TextBox();
            txbDataPub = new TextBox();
            txbPreco = new TextBox();
            textBox2 = new TextBox();
            btnAddLivro = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnExcluir = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagina.Location = new Point(110, 38);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(150, 20);
            lblPagina.TabIndex = 0;
            lblPagina.Text = "Alterar/Excluir Livro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 91);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do Livro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 129);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 167);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "ID do autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 205);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 4;
            label4.Text = "Data da Publicação:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(87, 243);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 5;
            label5.Text = "Preço do Livro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(115, 281);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 6;
            label6.Text = "ID Editora:";
            // 
            // txbNomeLivro
            // 
            txbNomeLivro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeLivro.Location = new Point(200, 88);
            txbNomeLivro.MaxLength = 50;
            txbNomeLivro.Name = "txbNomeLivro";
            txbNomeLivro.Size = new Size(359, 27);
            txbNomeLivro.TabIndex = 7;
            // 
            // txbISBN
            // 
            txbISBN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbISBN.Location = new Point(200, 122);
            txbISBN.MaxLength = 30;
            txbISBN.Name = "txbISBN";
            txbISBN.Size = new Size(100, 27);
            txbISBN.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(200, 160);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 27);
            textBox1.TabIndex = 9;
            // 
            // txbDataPub
            // 
            txbDataPub.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbDataPub.Location = new Point(200, 202);
            txbDataPub.Name = "txbDataPub";
            txbDataPub.Size = new Size(100, 27);
            txbDataPub.TabIndex = 10;
            // 
            // txbPreco
            // 
            txbPreco.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbPreco.Location = new Point(200, 243);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(72, 27);
            txbPreco.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(200, 278);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(45, 27);
            textBox2.TabIndex = 12;
            // 
            // btnAddLivro
            // 
            btnAddLivro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLivro.Location = new Point(200, 354);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Size = new Size(100, 42);
            btnAddLivro.TabIndex = 13;
            btnAddLivro.Text = "Alterar";
            btnAddLivro.UseVisualStyleBackColor = true;
            btnAddLivro.Click += btnAddLivro_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(395, 354);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 42);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(statusStrip1);
            Controls.Add(btnAddLivro);
            Controls.Add(textBox2);
            Controls.Add(txbPreco);
            Controls.Add(txbDataPub);
            Controls.Add(textBox1);
            Controls.Add(txbISBN);
            Controls.Add(txbNomeLivro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPagina);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Livro";
            Load += Form3_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagina;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbNomeLivro;
        private TextBox txbISBN;
        private TextBox textBox1;
        private TextBox txbDataPub;
        private TextBox txbPreco;
        private TextBox textBox2;
        private Button btnAddLivro;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnExcluir;
    }
}