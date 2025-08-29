namespace prj.AybarSP1
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblBienvenido = new Label();
            btnAceptar = new Button();
            pctRobot = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctRobot).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = SystemColors.Control;
            lblBienvenido.BorderStyle = BorderStyle.FixedSingle;
            lblBienvenido.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblBienvenido.Location = new Point(120, 33);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(358, 39);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido Al Sistema";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(239, 137);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 38);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // pctRobot
            // 
            pctRobot.BackColor = Color.Cyan;
            pctRobot.BorderStyle = BorderStyle.Fixed3D;
            pctRobot.ErrorImage = (Image)resources.GetObject("pctRobot.ErrorImage");
            pctRobot.Image = Properties.Resources.ROBOT;
            pctRobot.InitialImage = (Image)resources.GetObject("pctRobot.InitialImage");
            pctRobot.Location = new Point(176, 149);
            pctRobot.Name = "pctRobot";
            pctRobot.Size = new Size(229, 229);
            pctRobot.SizeMode = PictureBoxSizeMode.AutoSize;
            pctRobot.TabIndex = 2;
            pctRobot.TabStop = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(577, 330);
            Controls.Add(btnAceptar);
            Controls.Add(pctRobot);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)pctRobot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnAceptar;
        private PictureBox pctRobot;
    }
}