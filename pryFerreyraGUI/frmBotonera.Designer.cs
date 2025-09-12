namespace pryFerreyraGUI
{
    partial class frmBotonera
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
            gbNombres = new GroupBox();
            btnAdeltante = new Button();
            lblDatos = new Label();
            btnAtras = new Button();
            comboBoxNombres = new ComboBox();
            gbNombres.SuspendLayout();
            SuspendLayout();
            // 
            // gbNombres
            // 
            gbNombres.BackColor = Color.Snow;
            gbNombres.Controls.Add(btnAdeltante);
            gbNombres.Controls.Add(lblDatos);
            gbNombres.Controls.Add(btnAtras);
            gbNombres.ForeColor = Color.Transparent;
            gbNombres.Location = new Point(73, 43);
            gbNombres.Name = "gbNombres";
            gbNombres.Size = new Size(325, 129);
            gbNombres.TabIndex = 8;
            gbNombres.TabStop = false;
            // 
            // btnAdeltante
            // 
            btnAdeltante.BackColor = Color.OliveDrab;
            btnAdeltante.ForeColor = SystemColors.Desktop;
            btnAdeltante.Location = new Point(209, 46);
            btnAdeltante.Name = "btnAdeltante";
            btnAdeltante.Size = new Size(67, 37);
            btnAdeltante.TabIndex = 12;
            btnAdeltante.Text = ">>";
            btnAdeltante.UseVisualStyleBackColor = false;
            btnAdeltante.Click += btnAdeltante_Click;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.ForeColor = Color.Black;
            lblDatos.Location = new Point(131, 56);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(0, 20);
            lblDatos.TabIndex = 11;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.OliveDrab;
            btnAtras.ForeColor = SystemColors.Desktop;
            btnAtras.Location = new Point(48, 46);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(67, 37);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "<<";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // comboBoxNombres
            // 
            comboBoxNombres.FormattingEnabled = true;
            comboBoxNombres.Location = new Point(73, 12);
            comboBoxNombres.Name = "comboBoxNombres";
            comboBoxNombres.Size = new Size(121, 23);
            comboBoxNombres.TabIndex = 9;
            comboBoxNombres.SelectedIndexChanged += comboBoxNombres_SelectedIndexChanged;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(484, 222);
            Controls.Add(comboBoxNombres);
            Controls.Add(gbNombres);
            ForeColor = SystemColors.HighlightText;
            Name = "frmBotonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBotonera";
            Load += frmBotonera_Load;
            gbNombres.ResumeLayout(false);
            gbNombres.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbNombres;
        private Button btnAdeltante;
        private Label lblDatos;
        private Button btnAtras;
        private ComboBox comboBoxNombres;
    }
}