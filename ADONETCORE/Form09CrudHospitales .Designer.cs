namespace ADONETCORE
{
    partial class Form09CrudHospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtLocalidad = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lstHospitales = new ListBox();
            label1 = new Label();
            txtNumeroCamas = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(426, 369);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 29);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(426, 335);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 29);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(426, 303);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(109, 28);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(425, 148);
            txtLocalidad.Margin = new Padding(3, 2, 3, 2);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(110, 23);
            txtLocalidad.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(425, 106);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Location = new Point(425, 64);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 131);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "Localidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 89);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 14;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 47);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 13;
            label2.Text = "Id";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(51, 64);
            lstHospitales.Margin = new Padding(3, 2, 3, 2);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(339, 334);
            lstHospitales.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // txtNumeroCamas
            // 
            txtNumeroCamas.Location = new Point(426, 234);
            txtNumeroCamas.Margin = new Padding(3, 2, 3, 2);
            txtNumeroCamas.Name = "txtNumeroCamas";
            txtNumeroCamas.Size = new Size(110, 23);
            txtNumeroCamas.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(426, 192);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 23);
            txtTelefono.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 217);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 23;
            label5.Text = "Numero de camas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 175);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 22;
            label6.Text = "Telefono";
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 544);
            Controls.Add(txtNumeroCamas);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtLocalidad;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox lstHospitales;
        private Label label1;
        private TextBox txtNumeroCamas;
        private TextBox txtTelefono;
        private Label label5;
        private Label label6;
    }
}