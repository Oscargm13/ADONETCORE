namespace ADONETCORE
{
    partial class Form12MensajesServidor
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
            label3 = new Label();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            lstDepartamentos = new ListBox();
            label4 = new Label();
            lblMensaje = new Label();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 117);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Localidad";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(51, 77);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(51, 212);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(125, 27);
            txtLocalidad.TabIndex = 5;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(324, 77);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(359, 304);
            lstDepartamentos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 54);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 7;
            label4.Text = "Departamentos";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(51, 331);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 8;
            lblMensaje.Text = "lblMensaje";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(51, 258);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 53);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsertar);
            Controls.Add(lblMensaje);
            Controls.Add(label4);
            Controls.Add(lstDepartamentos);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private ListBox lstDepartamentos;
        private Label label4;
        private Label lblMensaje;
        private Button btnInsertar;
    }
}