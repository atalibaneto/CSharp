namespace ValidaCampos
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
            label1 = new Label();
            mkdCPF = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 104);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "CPF:";
            // 
            // mkdCPF
            // 
            mkdCPF.Location = new Point(154, 101);
            mkdCPF.Mask = "000,000,000-00";
            mkdCPF.Name = "mkdCPF";
            mkdCPF.Size = new Size(90, 23);
            mkdCPF.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 134);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 4;
            label2.Text = "Data de Nascimento:";
            label2.Click += label2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(154, 130);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(61, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 314);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(mkdCPF);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Validação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaskedTextBox mkdCPF;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
    }
}