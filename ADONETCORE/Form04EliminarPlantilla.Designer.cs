namespace ADONETCORE
{
    partial class Form04EliminarPlantilla
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
            txtPlantilla = new TextBox();
            lstPlantilla = new ListBox();
            label2 = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 82);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Plantilla";
            // 
            // txtPlantilla
            // 
            txtPlantilla.Location = new Point(102, 113);
            txtPlantilla.Name = "txtPlantilla";
            txtPlantilla.Size = new Size(125, 27);
            txtPlantilla.TabIndex = 1;
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(414, 162);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(150, 104);
            lstPlantilla.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 116);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Plantillas";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(102, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(lstPlantilla);
            Controls.Add(txtPlantilla);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlantilla;
        private ListBox lstPlantilla;
        private Label label2;
        private Button btnEliminar;
    }
}