
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
            this.btnLog_Login = new System.Windows.Forms.Button();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.linkLabelLog_RecuperarPass = new System.Windows.Forms.LinkLabel();
            this.textBoxLog_User = new System.Windows.Forms.TextBox();
            this.textBoxLog_Password = new System.Windows.Forms.TextBox();
            this.btnLog_Registrar = new System.Windows.Forms.Button();
            this.labelLog_preguntaPass = new System.Windows.Forms.Label();
            this.btnLog_Salir = new System.Windows.Forms.Button();
            this.pictureBoxLog_Imagen = new System.Windows.Forms.PictureBox();
            this.labelLog_Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog_Login
            // 
            this.btnLog_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnLog_Login.FlatAppearance.BorderSize = 0;
            this.btnLog_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog_Login.ForeColor = System.Drawing.Color.White;
            this.btnLog_Login.Location = new System.Drawing.Point(71, 356);
            this.btnLog_Login.Name = "btnLog_Login";
            this.btnLog_Login.Size = new System.Drawing.Size(224, 42);
            this.btnLog_Login.TabIndex = 0;
            this.btnLog_Login.Text = "INICIAR SESION";
            this.btnLog_Login.UseVisualStyleBackColor = false;
            this.btnLog_Login.Click += new System.EventHandler(this.btnLog_Login_Click);
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
            // linkLabelLog_RecuperarPass
            // 
            this.linkLabelLog_RecuperarPass.AutoSize = true;
            this.linkLabelLog_RecuperarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLog_RecuperarPass.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabelLog_RecuperarPass.Location = new System.Drawing.Point(227, 462);
            this.linkLabelLog_RecuperarPass.Name = "linkLabelLog_RecuperarPass";
            this.linkLabelLog_RecuperarPass.Size = new System.Drawing.Size(67, 13);
            this.linkLabelLog_RecuperarPass.TabIndex = 4;
            this.linkLabelLog_RecuperarPass.TabStop = true;
            this.linkLabelLog_RecuperarPass.Text = "Entra aquí";
            // 
            // textBoxLog_User
            // 
            this.textBoxLog_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxLog_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog_User.ForeColor = System.Drawing.Color.White;
            this.textBoxLog_User.Location = new System.Drawing.Point(72, 237);
            this.textBoxLog_User.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxLog_User.Name = "textBoxLog_User";
            this.textBoxLog_User.Size = new System.Drawing.Size(224, 22);
            this.textBoxLog_User.TabIndex = 5;
            this.textBoxLog_User.TextChanged += new System.EventHandler(this.textBox_User_TextChanged);
            // 
            // textBoxLog_Password
            // 
            this.textBoxLog_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxLog_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog_Password.ForeColor = System.Drawing.Color.White;
            this.textBoxLog_Password.Location = new System.Drawing.Point(71, 288);
            this.textBoxLog_Password.Name = "textBoxLog_Password";
            this.textBoxLog_Password.Size = new System.Drawing.Size(224, 22);
            this.textBoxLog_Password.TabIndex = 6;
            this.textBoxLog_Password.UseSystemPasswordChar = true;
            this.textBoxLog_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // btnLog_Registrar
            // 
            this.btnLog_Registrar.Location = new System.Drawing.Point(71, 404);
            this.btnLog_Registrar.Name = "btnLog_Registrar";
            this.btnLog_Registrar.Size = new System.Drawing.Size(224, 42);
            this.btnLog_Registrar.TabIndex = 7;
            this.btnLog_Registrar.Text = "REGISTRARSE";
            this.btnLog_Registrar.UseVisualStyleBackColor = true;
            this.btnLog_Registrar.Click += new System.EventHandler(this.btnLog_Registrar_Click);
            // 
            // labelLog_preguntaPass
            // 
            this.labelLog_preguntaPass.AutoSize = true;
            this.labelLog_preguntaPass.ForeColor = System.Drawing.Color.White;
            this.labelLog_preguntaPass.Location = new System.Drawing.Point(71, 462);
            this.labelLog_preguntaPass.Name = "labelLog_preguntaPass";
            this.labelLog_preguntaPass.Size = new System.Drawing.Size(154, 13);
            this.labelLog_preguntaPass.TabIndex = 8;
            this.labelLog_preguntaPass.Text = "¿ Has olvidado la contraseña ?";
            this.labelLog_preguntaPass.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnLog_Salir
            // 
            this.btnLog_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnLog_Salir.FlatAppearance.BorderSize = 0;
            this.btnLog_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog_Salir.ForeColor = System.Drawing.Color.White;
            this.btnLog_Salir.Location = new System.Drawing.Point(141, 525);
            this.btnLog_Salir.Name = "btnLog_Salir";
            this.btnLog_Salir.Size = new System.Drawing.Size(75, 23);
            this.btnLog_Salir.TabIndex = 9;
            this.btnLog_Salir.Text = "SALIR";
            this.btnLog_Salir.UseVisualStyleBackColor = false;
            this.btnLog_Salir.Click += new System.EventHandler(this.btnLog_Salir_Click);
            // 
            // pictureBoxLog_Imagen
            // 
            this.pictureBoxLog_Imagen.Image = global::InterfazUsuario.Properties.Resources.CandadoCerrado;
            this.pictureBoxLog_Imagen.Location = new System.Drawing.Point(123, 66);
            this.pictureBoxLog_Imagen.Name = "pictureBoxLog_Imagen";
            this.pictureBoxLog_Imagen.Size = new System.Drawing.Size(124, 120);
            this.pictureBoxLog_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLog_Imagen.TabIndex = 1;
            this.pictureBoxLog_Imagen.TabStop = false;
            // 
            // labelLog_Message
            // 
            this.labelLog_Message.AutoSize = true;
            this.labelLog_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog_Message.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLog_Message.Location = new System.Drawing.Point(48, 326);
            this.labelLog_Message.Name = "labelLog_Message";
            this.labelLog_Message.Size = new System.Drawing.Size(268, 15);
            this.labelLog_Message.TabIndex = 10;
            this.labelLog_Message.Text = "PRUEBE:  usuario  \"admin\"   contraseña: \"1234\"";
            this.labelLog_Message.Visible = false;
            this.labelLog_Message.Click += new System.EventHandler(this.labelLog_Message_Click);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 572);
            this.Controls.Add(this.labelLog_Message);
            this.Controls.Add(this.btnLog_Salir);
            this.Controls.Add(this.labelLog_preguntaPass);
            this.Controls.Add(this.btnLog_Registrar);
            this.Controls.Add(this.textBoxLog_Password);
            this.Controls.Add(this.textBoxLog_User);
            this.Controls.Add(this.linkLabelLog_RecuperarPass);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.pictureBoxLog_Imagen);
            this.Controls.Add(this.btnLog_Login);
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog_Login;
        private System.Windows.Forms.PictureBox pictureBoxLog_Imagen;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.LinkLabel linkLabelLog_RecuperarPass;
        private System.Windows.Forms.Button btnLog_Registrar;
        private System.Windows.Forms.Label labelLog_preguntaPass;
        private System.Windows.Forms.TextBox textBoxLog_User;
        private System.Windows.Forms.Button btnLog_Salir;
        private System.Windows.Forms.TextBox textBoxLog_Password;
        private System.Windows.Forms.Label labelLog_Message;
    }
}

