namespace ADONETCORE
{
    partial class Form15AdoNetCorePractica
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
            label5 = new Label();
            lstEmpleados = new ListBox();
            txtPersonas = new TextBox();
            label4 = new Label();
            txtMediaSalarial = new TextBox();
            label3 = new Label();
            txtSumaSalarial = new TextBox();
            label2 = new Label();
            btnMostrar = new Button();
            cmbHospital = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 76);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 21;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(289, 100);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(342, 444);
            lstEmpleados.TabIndex = 20;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(27, 409);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(125, 27);
            txtPersonas.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 387);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 18;
            label4.Text = "Personas";
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(27, 337);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(125, 27);
            txtMediaSalarial.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 315);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 16;
            label3.Text = "Media salarial";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(27, 268);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(125, 27);
            txtSumaSalarial.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 245);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 14;
            label2.Text = "Suma salarial";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(27, 136);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(139, 75);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // cmbHospital
            // 
            cmbHospital.FormattingEnabled = true;
            cmbHospital.Location = new Point(27, 100);
            cmbHospital.Name = "cmbHospital";
            cmbHospital.Size = new Size(151, 28);
            cmbHospital.TabIndex = 12;
            cmbHospital.SelectedIndexChanged += cmbHospital_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 76);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // Form15AdoNetCorePractica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 637);
            Controls.Add(label5);
            Controls.Add(lstEmpleados);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMediaSalarial);
            Controls.Add(label3);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(cmbHospital);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form15AdoNetCorePractica";
            Text = "Form15AdoNetCorePractica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ListBox lstEmpleados;
        private TextBox txtPersonas;
        private Label label4;
        private TextBox txtMediaSalarial;
        private Label label3;
        private TextBox txtSumaSalarial;
        private Label label2;
        private Button btnMostrar;
        private ComboBox cmbHospital;
        private Label label1;
    }
}