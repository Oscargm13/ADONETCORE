namespace ADONETCORE
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            lstTipoDato = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(62, 52);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(120, 56);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(62, 128);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(120, 53);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(62, 209);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(120, 47);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 52);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 52);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Tipo dato";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(275, 75);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(159, 264);
            lstApellidos.TabIndex = 6;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(451, 75);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(154, 264);
            lstColumnas.TabIndex = 7;
            // 
            // lstTipoDato
            // 
            lstTipoDato.FormattingEnabled = true;
            lstTipoDato.Location = new Point(625, 75);
            lstTipoDato.Name = "lstTipoDato";
            lstTipoDato.Size = new Size(148, 264);
            lstTipoDato.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(62, 347);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 482);
            Controls.Add(lblMensaje);
            Controls.Add(lstTipoDato);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private ListBox lstTipoDato;
        private Label lblMensaje;
    }
}