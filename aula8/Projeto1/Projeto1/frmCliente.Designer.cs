namespace Projeto1
{
    partial class frmCliente
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
            btnClique = new Button();
            SuspendLayout();
            // 
            // btnClique
            // 
            btnClique.Location = new Point(348, 198);
            btnClique.Name = "btnClique";
            btnClique.Size = new Size(95, 33);
            btnClique.TabIndex = 0;
            btnClique.Text = "Clique Aqui!";
            btnClique.UseVisualStyleBackColor = true;
            btnClique.Click += btnClique_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClique);
            Name = "frmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCliente";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClique;
    }
}