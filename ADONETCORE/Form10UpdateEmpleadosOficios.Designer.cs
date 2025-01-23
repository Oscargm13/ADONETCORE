namespace ADONETCORE
{
    partial class Form10UpdateEmpleadosOficios
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
            lbl = new Label();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalarial = new Label();
            txtIncremento = new TextBox();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            btnIncrementarSalarios = new Button();
            label3 = new Label();
            txtOficio = new TextBox();
            btnOficio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 68);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(593, 204);
            lbl.Name = "lbl";
            lbl.Size = new Size(84, 20);
            lbl.TabIndex = 2;
            lbl.Text = "incremento";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(31, 255);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(50, 20);
            lblSumaSalarial.TabIndex = 3;
            lblSumaSalarial.Text = "label4";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(31, 291);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(50, 20);
            lblMediaSalarial.TabIndex = 4;
            lblMediaSalarial.Text = "label5";
            // 
            // lblMaximoSalarial
            // 
            lblMaximoSalarial.AutoSize = true;
            lblMaximoSalarial.Location = new Point(31, 320);
            lblMaximoSalarial.Name = "lblMaximoSalarial";
            lblMaximoSalarial.Size = new Size(50, 20);
            lblMaximoSalarial.TabIndex = 5;
            lblMaximoSalarial.Text = "label6";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(593, 227);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(125, 27);
            txtIncremento.TabIndex = 6;
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(151, 95);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(167, 264);
            lstOficios.TabIndex = 7;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(362, 95);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(177, 264);
            lstEmpleados.TabIndex = 8;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(593, 276);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(128, 74);
            btnIncrementarSalarios.TabIndex = 9;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(593, 68);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(593, 91);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(125, 27);
            txtOficio.TabIndex = 11;
            // 
            // btnOficio
            // 
            btnOficio.Location = new Point(593, 124);
            btnOficio.Name = "btnOficio";
            btnOficio.Size = new Size(125, 50);
            btnOficio.TabIndex = 12;
            btnOficio.Text = "Cambiar oficio";
            btnOficio.UseVisualStyleBackColor = true;
            btnOficio.Click += btnOficio_Click;
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(txtIncremento);
            Controls.Add(lblMaximoSalarial);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalarial;
        private TextBox txtIncremento;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Button btnIncrementarSalarios;
        private Label label3;
        private TextBox txtOficio;
        private Button btnOficio;
    }
}