namespace Calculadora
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
            btnAdd = new Button();
            btnSubtracao = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            valor1 = new Label();
            valor2 = new Label();
            label1 = new Label();
            lblResultado = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(305, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(305, 61);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(30, 23);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(305, 90);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(30, 23);
            btnDivisao.TabIndex = 2;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(305, 119);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(30, 23);
            btnMultiplicacao.TabIndex = 3;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(42, 51);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(42, 104);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 5;
            // 
            // valor1
            // 
            valor1.AutoSize = true;
            valor1.Location = new Point(42, 36);
            valor1.Name = "valor1";
            valor1.Size = new Size(45, 15);
            valor1.TabIndex = 6;
            valor1.Text = "Valor 1:";
            // 
            // valor2
            // 
            valor2.AutoSize = true;
            valor2.Location = new Point(42, 86);
            valor2.Name = "valor2";
            valor2.Size = new Size(45, 15);
            valor2.TabIndex = 7;
            valor2.Text = "Valor 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 169);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(42, 199);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(114, 46);
            lblResultado.TabIndex = 9;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 298);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(valor2);
            Controls.Add(valor1);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSubtracao;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label valor1;
        private Label valor2;
        private Label label1;
        private Label lblResultado;
        private Label label2;
    }
}