namespace ADONETCORE
{
    partial class Form14Settings
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
            btnLeerSettings = new Button();
            lblCadenaConexion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLeerSettings
            // 
            btnLeerSettings.Location = new Point(41, 36);
            btnLeerSettings.Name = "btnLeerSettings";
            btnLeerSettings.Size = new Size(163, 69);
            btnLeerSettings.TabIndex = 0;
            btnLeerSettings.Text = "Leer Setting";
            btnLeerSettings.UseVisualStyleBackColor = true;
            btnLeerSettings.Click += btnLeerSettings_Click;
            // 
            // lblCadenaConexion
            // 
            lblCadenaConexion.AutoSize = true;
            lblCadenaConexion.Location = new Point(41, 108);
            lblCadenaConexion.Name = "lblCadenaConexion";
            lblCadenaConexion.Size = new Size(138, 20);
            lblCadenaConexion.TabIndex = 1;
            lblCadenaConexion.Text = "lblCadenaConexion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 198);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(411, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(303, 198);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadenaConexion);
            Controls.Add(btnLeerSettings);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerSettings;
        private Label lblCadenaConexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}