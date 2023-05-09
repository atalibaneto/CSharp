namespace HelloWorldForms
{
    partial class frmMensagem
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
            btmMostrar = new Button();
            SuspendLayout();
            // 
            // btmMostrar
            // 
            btmMostrar.Location = new Point(289, 107);
            btmMostrar.Name = "btmMostrar";
            btmMostrar.Size = new Size(202, 127);
            btmMostrar.TabIndex = 0;
            btmMostrar.Text = "Mostrar Mensagem";
            btmMostrar.UseVisualStyleBackColor = true;
            btmMostrar.Click += btmMostrar_Click;
            // 
            // frmMensagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btmMostrar);
            Name = "frmMensagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensagem";
            ResumeLayout(false);
        }

        #endregion

        private Button btmMostrar;
    }
}