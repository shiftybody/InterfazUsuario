
namespace InterfazUsuario
{
    partial class form_Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_PasswordRegister = new System.Windows.Forms.TextBox();
            this.textBox_UserRegister = new System.Windows.Forms.TextBox();
            this.label_ContraseñaRegistro = new System.Windows.Forms.Label();
            this.label_UsuarioRegistro = new System.Windows.Forms.Label();
            this.textBox_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.label_ContraseñaConfirmada = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_regresarLogin = new System.Windows.Forms.Button();
            this.labelResgistro_Message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 266);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazUsuario.Properties.Resources.verificar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(34, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_PasswordRegister
            // 
            this.textBox_PasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_PasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordRegister.ForeColor = System.Drawing.Color.White;
            this.textBox_PasswordRegister.Location = new System.Drawing.Point(372, 84);
            this.textBox_PasswordRegister.Name = "textBox_PasswordRegister";
            this.textBox_PasswordRegister.Size = new System.Drawing.Size(224, 22);
            this.textBox_PasswordRegister.TabIndex = 10;
            this.textBox_PasswordRegister.Leave += new System.EventHandler(this.textBox_PasswordRegister_Leave);
            // 
            // textBox_UserRegister
            // 
            this.textBox_UserRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UserRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_UserRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserRegister.ForeColor = System.Drawing.Color.White;
            this.textBox_UserRegister.Location = new System.Drawing.Point(372, 34);
            this.textBox_UserRegister.Name = "textBox_UserRegister";
            this.textBox_UserRegister.Size = new System.Drawing.Size(224, 22);
            this.textBox_UserRegister.TabIndex = 9;
            this.textBox_UserRegister.TextChanged += new System.EventHandler(this.textBox_UserRegister_TextChanged);
            this.textBox_UserRegister.Leave += new System.EventHandler(this.textBox_UserRegister_Leave);
            // 
            // label_ContraseñaRegistro
            // 
            this.label_ContraseñaRegistro.AutoSize = true;
            this.label_ContraseñaRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ContraseñaRegistro.Location = new System.Drawing.Point(305, 88);
            this.label_ContraseñaRegistro.Name = "label_ContraseñaRegistro";
            this.label_ContraseñaRegistro.Size = new System.Drawing.Size(61, 13);
            this.label_ContraseñaRegistro.TabIndex = 8;
            this.label_ContraseñaRegistro.Text = "Contraseña";
            // 
            // label_UsuarioRegistro
            // 
            this.label_UsuarioRegistro.AutoSize = true;
            this.label_UsuarioRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_UsuarioRegistro.Location = new System.Drawing.Point(323, 38);
            this.label_UsuarioRegistro.Name = "label_UsuarioRegistro";
            this.label_UsuarioRegistro.Size = new System.Drawing.Size(43, 13);
            this.label_UsuarioRegistro.TabIndex = 7;
            this.label_UsuarioRegistro.Text = "Usuario";
            // 
            // textBox_PasswordConfirm
            // 
            this.textBox_PasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_PasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.textBox_PasswordConfirm.Location = new System.Drawing.Point(372, 133);
            this.textBox_PasswordConfirm.Name = "textBox_PasswordConfirm";
            this.textBox_PasswordConfirm.Size = new System.Drawing.Size(224, 22);
            this.textBox_PasswordConfirm.TabIndex = 11;
            // 
            // label_ContraseñaConfirmada
            // 
            this.label_ContraseñaConfirmada.AutoSize = true;
            this.label_ContraseñaConfirmada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ContraseñaConfirmada.Location = new System.Drawing.Point(259, 137);
            this.label_ContraseñaConfirmada.Name = "label_ContraseñaConfirmada";
            this.label_ContraseñaConfirmada.Size = new System.Drawing.Size(107, 13);
            this.label_ContraseñaConfirmada.TabIndex = 12;
            this.label_ContraseñaConfirmada.Text = "Confirmar contraseña";
            this.label_ContraseñaConfirmada.Click += new System.EventHandler(this.label_ContraseñaConfirmada_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Enabled = false;
            this.btn_Registrar.Location = new System.Drawing.Point(507, 206);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(189, 37);
            this.btn_Registrar.TabIndex = 13;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_regresarLogin
            // 
            this.btn_regresarLogin.FlatAppearance.BorderSize = 0;
            this.btn_regresarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresarLogin.ForeColor = System.Drawing.Color.White;
            this.btn_regresarLogin.Location = new System.Drawing.Point(211, 206);
            this.btn_regresarLogin.Name = "btn_regresarLogin";
            this.btn_regresarLogin.Size = new System.Drawing.Size(67, 37);
            this.btn_regresarLogin.TabIndex = 15;
            this.btn_regresarLogin.Text = "Volver";
            this.btn_regresarLogin.UseVisualStyleBackColor = true;
            this.btn_regresarLogin.Click += new System.EventHandler(this.btn_regresarLogin_Click);
            // 
            // labelResgistro_Message
            // 
            this.labelResgistro_Message.AutoSize = true;
            this.labelResgistro_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResgistro_Message.ForeColor = System.Drawing.Color.White;
            this.labelResgistro_Message.Location = new System.Drawing.Point(437, 173);
            this.labelResgistro_Message.Name = "labelResgistro_Message";
            this.labelResgistro_Message.Size = new System.Drawing.Size(76, 18);
            this.labelResgistro_Message.TabIndex = 16;
            this.labelResgistro_Message.Text = "Mensaje ";
            this.labelResgistro_Message.Visible = false;
            // 
            // form_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(724, 266);
            this.Controls.Add(this.labelResgistro_Message);
            this.Controls.Add(this.btn_regresarLogin);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label_ContraseñaConfirmada);
            this.Controls.Add(this.textBox_PasswordConfirm);
            this.Controls.Add(this.textBox_PasswordRegister);
            this.Controls.Add(this.textBox_UserRegister);
            this.Controls.Add(this.label_ContraseñaRegistro);
            this.Controls.Add(this.label_UsuarioRegistro);
            this.Controls.Add(this.panel1);
            this.Name = "form_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_PasswordRegister;
        private System.Windows.Forms.TextBox textBox_UserRegister;
        private System.Windows.Forms.Label label_ContraseñaRegistro;
        private System.Windows.Forms.Label label_UsuarioRegistro;
        private System.Windows.Forms.TextBox textBox_PasswordConfirm;
        private System.Windows.Forms.Label label_ContraseñaConfirmada;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_regresarLogin;
        private System.Windows.Forms.Label labelResgistro_Message;
    }
}