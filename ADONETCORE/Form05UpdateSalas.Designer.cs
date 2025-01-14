namespace ADONETCORE
{
    partial class Form05UpdateSalas
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
            btnModificar = new Button();
            label2 = new Label();
            lstSalas = new ListBox();
            txtPlantilla = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(336, 208);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(125, 42);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar salas";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 96);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(26, 124);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(233, 244);
            lstSalas.TabIndex = 7;
            // 
            // txtPlantilla
            // 
            txtPlantilla.Location = new Point(336, 158);
            txtPlantilla.Name = "txtPlantilla";
            txtPlantilla.Size = new Size(125, 27);
            txtPlantilla.TabIndex = 6;
            txtPlantilla.Text = "txtSala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 133);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 5;
            label1.Text = "Nueva sala";
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 456);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(txtPlantilla);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Label label2;
        private ListBox lstSalas;
        private TextBox txtPlantilla;
        private Label label1;
    }
}