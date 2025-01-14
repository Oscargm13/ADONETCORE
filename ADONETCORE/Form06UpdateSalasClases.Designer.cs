namespace ADONETCORE
{
    partial class Form06UpdateSalasClases
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
            lstSalas = new ListBox();
            txtPlantilla = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(397, 184);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(125, 43);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar salas";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(77, 97);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(233, 244);
            lstSalas.TabIndex = 12;
            // 
            // txtPlantilla
            // 
            txtPlantilla.Location = new Point(397, 133);
            txtPlantilla.Name = "txtPlantilla";
            txtPlantilla.Size = new Size(125, 27);
            txtPlantilla.TabIndex = 11;
            txtPlantilla.Text = "txtSala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 109);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 10;
            label1.Text = "Nueva sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Controls.Add(lstSalas);
            Controls.Add(txtPlantilla);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private ListBox lstSalas;
        private TextBox txtPlantilla;
        private Label label1;
        private Label label2;
    }
}