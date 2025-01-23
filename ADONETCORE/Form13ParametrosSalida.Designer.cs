namespace ADONETCORE
{
    partial class Form13ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            btnMostrar = new Button();
            label2 = new Label();
            txtSumaSalarial = new TextBox();
            txtMediaSalarial = new TextBox();
            label3 = new Label();
            txtPersonas = new TextBox();
            label4 = new Label();
            lstEmpleados = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 46);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(81, 69);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(81, 103);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(139, 74);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 207);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Suma salarial";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(84, 230);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(125, 27);
            txtSumaSalarial.TabIndex = 4;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(81, 290);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(125, 27);
            txtMediaSalarial.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 267);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "Media salarial";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(81, 343);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(125, 27);
            txtPersonas.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 320);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 7;
            label4.Text = "Personas";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(404, 69);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(280, 304);
            lstEmpleados.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 46);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 10;
            label5.Text = "Empleados";
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(lstEmpleados);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMediaSalarial);
            Controls.Add(label3);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtSumaSalarial;
        private TextBox txtMediaSalarial;
        private Label label3;
        private TextBox txtPersonas;
        private Label label4;
        private ListBox lstEmpleados;
        private Label label5;
    }
}