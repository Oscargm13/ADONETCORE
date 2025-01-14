namespace ADONETCORE
{
    partial class Form02BuscadorEmpleados
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
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnBuscar = new Button();
            txtSalario = new TextBox();
            label3 = new Label();
            txtOficio = new TextBox();
            btnBuscarOficio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 64);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca su salario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 191);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(87, 214);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(150, 104);
            lstEmpleados.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(87, 120);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 68);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar empleados";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(87, 87);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 27);
            txtSalario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 47);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 5;
            label3.Text = "Introduzaca Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(456, 70);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(125, 27);
            txtOficio.TabIndex = 6;
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(456, 103);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(94, 29);
            btnBuscarOficio.TabIndex = 7;
            btnBuscarOficio.Text = "Buscar oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            btnBuscarOficio.Click += btnBuscarOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(txtSalario);
            Controls.Add(btnBuscar);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnBuscar;
        private TextBox txtSalario;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarOficio;
    }
}