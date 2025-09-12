namespace pryFerreyraGUI
{
    partial class frmGUI
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
            btnBonotera = new Button();
            SuspendLayout();
            // 
            // btnBonotera
            // 
            btnBonotera.BackColor = Color.OliveDrab;
            btnBonotera.ForeColor = SystemColors.Desktop;
            btnBonotera.Location = new Point(12, 12);
            btnBonotera.Name = "btnBonotera";
            btnBonotera.Size = new Size(95, 26);
            btnBonotera.TabIndex = 13;
            btnBonotera.Text = "Abrir Botonera";
            btnBonotera.UseVisualStyleBackColor = false;
            btnBonotera.Click += btnBonotera_Click;
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(484, 461);
            Controls.Add(btnBonotera);
            Name = "frmGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGUI";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBonotera;
    }
}