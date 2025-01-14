namespace ADONETCORE
{
    partial class Form02_2
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
            btnBuscarOficio = new Button();
            txtOficio = new TextBox();
            label3 = new Label();
            txtSalario = new TextBox();
            btnBuscarSalario = new Button();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(449, 95);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(125, 53);
            btnBuscarOficio.TabIndex = 15;
            btnBuscarOficio.Text = "Buscar por oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(449, 62);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(125, 27);
            txtOficio.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 39);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 13;
            label3.Text = "Introduzaca Oficio";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(80, 79);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 27);
            txtSalario.TabIndex = 12;
            // 
            // btnBuscarSalario
            // 
            btnBuscarSalario.Location = new Point(80, 112);
            btnBuscarSalario.Name = "btnBuscarSalario";
            btnBuscarSalario.Size = new Size(125, 68);
            btnBuscarSalario.TabIndex = 11;
            btnBuscarSalario.Text = "Buscar por salario";
            btnBuscarSalario.UseVisualStyleBackColor = true;
            btnBuscarSalario.Click += btnBuscarSalario_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(80, 206);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(150, 104);
            lstEmpleados.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 183);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 9;
            label2.Text = "lista de empleados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 56);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 8;
            label1.Text = "Introduzca su salario";
            // 
            // Form02_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(txtSalario);
            Controls.Add(btnBuscarSalario);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02_2";
            Text = "Form02_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarOficio;
        private TextBox txtOficio;
        private Label label3;
        private TextBox txtSalario;
        private Button btnBuscarSalario;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label1;
    }
}