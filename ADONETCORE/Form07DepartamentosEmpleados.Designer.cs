namespace ADONETCORE
{
    partial class Form07DepartamentosEmpleados
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
            lstDepartamentos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(90, 143);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(195, 264);
            lstDepartamentos.TabIndex = 0;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 120);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 120);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(331, 143);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(212, 264);
            lstEmpleados.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(620, 166);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 63);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(label1);
            Controls.Add(lstDepartamentos);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDepartamentos;
        private Label label1;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnEliminar;
    }
}