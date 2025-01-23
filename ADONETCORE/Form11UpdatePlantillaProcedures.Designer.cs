namespace ADONETCORE
{
    partial class Form11UpdatePlantillaProcedures
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
            label1 = new Label();
            btnModificarSalarios = new Button();
            label2 = new Label();
            lbl = new Label();
            lstPlantilla = new ListBox();
            cmbHospitales = new ComboBox();
            txtIncremento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(354, 148);
            btnModificarSalarios.Margin = new Padding(3, 4, 3, 4);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(149, 67);
            btnModificarSalarios.TabIndex = 2;
            btnModificarSalarios.Text = "ModificarSalarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 49);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(129, 263);
            lbl.Name = "lbl";
            lbl.Size = new Size(62, 20);
            lbl.TabIndex = 5;
            lbl.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(129, 287);
            lstPlantilla.Margin = new Padding(3, 4, 3, 4);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(577, 264);
            lstPlantilla.TabIndex = 6;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(129, 73);
            cmbHospitales.Margin = new Padding(3, 4, 3, 4);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(261, 28);
            cmbHospitales.TabIndex = 7;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(478, 74);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(228, 27);
            txtIncremento.TabIndex = 9;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtIncremento);
            Controls.Add(cmbHospitales);
            Controls.Add(lstPlantilla);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(btnModificarSalarios);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            Load += Form11UpdatePlantillaProcedures_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnModificarSalarios;
        private Label label2;
        private TextBox textBox2;
        private Label lbl;
        private ListBox lstPlantilla;
        private ComboBox cmbHospitales;
        private TextBox txtIncremento;
    }
}