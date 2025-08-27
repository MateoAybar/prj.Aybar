namespace prj.Aybar
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            brnCancelar = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtConstraseña = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(345, 104);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(77, 22);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // brnCancelar
            // 
            brnCancelar.Location = new Point(345, 141);
            brnCancelar.Name = "brnCancelar";
            brnCancelar.Size = new Size(77, 23);
            brnCancelar.TabIndex = 1;
            brnCancelar.Text = "CANCELAR";
            brnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.Location = new Point(94, 103);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(94, 141);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(172, 103);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtConstraseña
            // 
            txtConstraseña.Location = new Point(172, 138);
            txtConstraseña.Name = "txtConstraseña";
            txtConstraseña.PasswordChar = '*';
            txtConstraseña.Size = new Size(158, 23);
            txtConstraseña.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 295);
            ControlBox = false;
            Controls.Add(txtConstraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(brnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmLogin";
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button brnCancelar;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtConstraseña;
    }
}
