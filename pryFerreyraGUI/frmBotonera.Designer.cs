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
            btnUltimo = new Button();
            btnPrimero = new Button();
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
            gbNombres.Controls.Add(btnUltimo);
            gbNombres.Controls.Add(btnPrimero);
            gbNombres.ForeColor = Color.Transparent;
            gbNombres.Location = new Point(31, 43);
            gbNombres.Name = "gbNombres";
            gbNombres.Size = new Size(421, 129);
            gbNombres.TabIndex = 8;
            gbNombres.TabStop = false;
            // 
            // btnAdeltante
            // 
            btnAdeltante.BackColor = Color.OliveDrab;
            btnAdeltante.ForeColor = SystemColors.ControlLightLight;
            btnAdeltante.Location = new Point(257, 46);
            btnAdeltante.Name = "btnAdeltante";
            btnAdeltante.Size = new Size(67, 37);
            btnAdeltante.TabIndex = 17;
            btnAdeltante.Text = ">>";
            btnAdeltante.UseVisualStyleBackColor = false;
            btnAdeltante.Click += btnAdeltante_Click_1;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.ForeColor = Color.Black;
            lblDatos.Location = new Point(179, 56);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(0, 20);
            lblDatos.TabIndex = 16;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.OliveDrab;
            btnAtras.ForeColor = SystemColors.ControlLightLight;
            btnAtras.Location = new Point(96, 46);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(67, 37);
            btnAtras.TabIndex = 15;
            btnAtras.Text = "<<";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.OliveDrab;
            btnUltimo.ForeColor = SystemColors.ControlLightLight;
            btnUltimo.Location = new Point(330, 52);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(67, 26);
            btnUltimo.TabIndex = 14;
            btnUltimo.Text = "Último";
            btnUltimo.UseVisualStyleBackColor = false;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.BackColor = Color.OliveDrab;
            btnPrimero.ForeColor = SystemColors.ControlLightLight;
            btnPrimero.Location = new Point(23, 51);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(67, 26);
            btnPrimero.TabIndex = 13;
            btnPrimero.Text = "Primero";
            btnPrimero.UseVisualStyleBackColor = false;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // comboBoxNombres
            // 
            comboBoxNombres.FormattingEnabled = true;
            comboBoxNombres.Location = new Point(31, 12);
            comboBoxNombres.Name = "comboBoxNombres";
            comboBoxNombres.Size = new Size(121, 23);
            comboBoxNombres.TabIndex = 9;
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
        private ComboBox comboBoxNombres;
        private Button btnUltimo;
        private Button btnPrimero;
        private Button btnAdeltante;
        private Label lblDatos;
        private Button btnAtras;
    }
}