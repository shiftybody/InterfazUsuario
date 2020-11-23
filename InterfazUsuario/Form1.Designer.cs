
namespace InterfazUsuario
{
    partial class form_Login
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
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.linkLabel_RecuperarPass = new System.Windows.Forms.LinkLabel();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label_preguntaPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
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
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Usuario.Location = new System.Drawing.Point(81, 221);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label_Usuario.TabIndex = 2;
            this.label_Usuario.Text = "Usuario";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Contraseña.Location = new System.Drawing.Point(80, 272);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.label_Contraseña.TabIndex = 3;
            this.label_Contraseña.Text = "Contraseña";
            // 
            // linkLabel_RecuperarPass
            // 
            this.linkLabel_RecuperarPass.AutoSize = true;
            this.linkLabel_RecuperarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_RecuperarPass.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel_RecuperarPass.Location = new System.Drawing.Point(227, 462);
            this.linkLabel_RecuperarPass.Name = "linkLabel_RecuperarPass";
            this.linkLabel_RecuperarPass.Size = new System.Drawing.Size(67, 13);
            this.linkLabel_RecuperarPass.TabIndex = 4;
            this.linkLabel_RecuperarPass.TabStop = true;
            this.linkLabel_RecuperarPass.Text = "Entra aquí";
            // 
            // textBox_User
            // 
            this.textBox_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_User.ForeColor = System.Drawing.Color.White;
            this.textBox_User.Location = new System.Drawing.Point(72, 237);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(224, 22);
            this.textBox_User.TabIndex = 5;
            this.textBox_User.TextChanged += new System.EventHandler(this.textBox_User_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(71, 288);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(224, 22);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(71, 404);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(224, 42);
            this.btn_Registrar.TabIndex = 7;
            this.btn_Registrar.Text = "REGISTRARSE";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // label_preguntaPass
            // 
            this.label_preguntaPass.AutoSize = true;
            this.label_preguntaPass.ForeColor = System.Drawing.Color.White;
            this.label_preguntaPass.Location = new System.Drawing.Point(71, 462);
            this.label_preguntaPass.Name = "label_preguntaPass";
            this.label_preguntaPass.Size = new System.Drawing.Size(154, 13);
            this.label_preguntaPass.TabIndex = 8;
            this.label_preguntaPass.Text = "¿ Has olvidado la contraseña ?";
            this.label_preguntaPass.Click += new System.EventHandler(this.label3_Click);
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
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(141, 525);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 572);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label_preguntaPass);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.linkLabel_RecuperarPass);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Name = "form_Login";
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
        private System.Windows.Forms.LinkLabel linkLabel_RecuperarPass;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label_preguntaPass;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}

