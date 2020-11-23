
namespace InterfazUsuario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.linkLabel_RecoverPass = new System.Windows.Forms.LinkLabel();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(71, 356);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(224, 42);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "INICIAR SESION";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazUsuario.Properties.Resources.CandadoCerrado;
            this.pictureBox1.Location = new System.Drawing.Point(123, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Usuario.Location = new System.Drawing.Point(69, 221);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label_Usuario.TabIndex = 2;
            this.label_Usuario.Text = "Usuario";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Contraseña.Location = new System.Drawing.Point(68, 284);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.label_Contraseña.TabIndex = 3;
            this.label_Contraseña.Text = "Contraseña";
            // 
            // linkLabel_RecoverPass
            // 
            this.linkLabel_RecoverPass.AutoSize = true;
            this.linkLabel_RecoverPass.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel_RecoverPass.Location = new System.Drawing.Point(228, 462);
            this.linkLabel_RecoverPass.Name = "linkLabel_RecoverPass";
            this.linkLabel_RecoverPass.Size = new System.Drawing.Size(57, 13);
            this.linkLabel_RecoverPass.TabIndex = 4;
            this.linkLabel_RecoverPass.TabStop = true;
            this.linkLabel_RecoverPass.Text = "Entra aquí";
            // 
            // textBox_User
            // 
            this.textBox_User.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_User.Location = new System.Drawing.Point(72, 237);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(224, 20);
            this.textBox_User.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(71, 300);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(224, 20);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(71, 404);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(224, 42);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "REGISTRARSE";
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿ Has olvidado la contraseña ? ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.linkLabel_RecoverPass);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.LinkLabel linkLabel_RecoverPass;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label3;
    }
}

