namespace ConectarBD
{
    partial class frmLogin
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
            btbLogin = new Button();
            txbPWD = new TextBox();
            txbUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // btbLogin
            // 
            btbLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btbLogin.Location = new Point(162, 196);
            btbLogin.Name = "btbLogin";
            btbLogin.Size = new Size(81, 30);
            btbLogin.TabIndex = 0;
            btbLogin.Text = "Login";
            btbLogin.UseVisualStyleBackColor = true;
            btbLogin.Click += btbLogin_Click;
            // 
            // txbPWD
            // 
            txbPWD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbPWD.Location = new Point(162, 144);
            txbPWD.MaxLength = 50;
            txbPWD.Name = "txbPWD";
            txbPWD.PasswordChar = '*';
            txbPWD.Size = new Size(130, 27);
            txbPWD.TabIndex = 1;
            txbPWD.UseSystemPasswordChar = true;
            // 
            // txbUsuario
            // 
            txbUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsuario.Location = new Point(162, 104);
            txbUsuario.MaxLength = 50;
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(130, 27);
            txbUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 107);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 147);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(142, 41);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 5;
            label3.Text = "Autenticação";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(192, 0, 0);
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = SystemColors.ControlLightLight;
            btnFechar.Location = new Point(395, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(36, 30);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 282);
            Controls.Add(btnFechar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbUsuario);
            Controls.Add(txbPWD);
            Controls.Add(btbLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbLogin;
        private TextBox txbPWD;
        private TextBox txbUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnFechar;
    }
}