
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Registro));
            this.textBox_PasswordRegister = new System.Windows.Forms.TextBox();
            this.textBox_UserRegister = new System.Windows.Forms.TextBox();
            this.label_ContraseñaRegistro = new System.Windows.Forms.Label();
            this.label_UsuarioRegistro = new System.Windows.Forms.Label();
            this.textBox_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.label_ContraseñaConfirmada = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.labelResgistro_Message = new System.Windows.Forms.Label();
            this.userLine = new System.Windows.Forms.Button();
            this.passwordLine = new System.Windows.Forms.Button();
            this.passvalidLine = new System.Windows.Forms.Button();
            this.btn_regresarLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegistrar_volver = new System.Windows.Forms.Button();
            this.pictureBoxRegistrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelRegistro_pass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_PasswordRegister
            // 
            this.textBox_PasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_PasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordRegister.ForeColor = System.Drawing.Color.Gray;
            this.textBox_PasswordRegister.Location = new System.Drawing.Point(371, 128);
            this.textBox_PasswordRegister.Name = "textBox_PasswordRegister";
            this.textBox_PasswordRegister.Size = new System.Drawing.Size(208, 15);
            this.textBox_PasswordRegister.TabIndex = 10;
            this.textBox_PasswordRegister.Text = "Ingrese una contraseña";
            this.textBox_PasswordRegister.TextChanged += new System.EventHandler(this.textBox_PasswordRegister_TextChanged);
            this.textBox_PasswordRegister.Enter += new System.EventHandler(this.textBox_PasswordRegister_Enter);
            this.textBox_PasswordRegister.Leave += new System.EventHandler(this.textBox_PasswordRegister_Leave);
            // 
            // textBox_UserRegister
            // 
            this.textBox_UserRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UserRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_UserRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UserRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserRegister.ForeColor = System.Drawing.Color.Gray;
            this.textBox_UserRegister.Location = new System.Drawing.Point(371, 48);
            this.textBox_UserRegister.Name = "textBox_UserRegister";
            this.textBox_UserRegister.Size = new System.Drawing.Size(208, 15);
            this.textBox_UserRegister.TabIndex = 9;
            this.textBox_UserRegister.Text = "Ingrese un nombre de usuario";
            this.textBox_UserRegister.TextChanged += new System.EventHandler(this.textBox_UserRegister_TextChanged);
            this.textBox_UserRegister.Enter += new System.EventHandler(this.textBox_UserRegister_Enter);
            this.textBox_UserRegister.Leave += new System.EventHandler(this.textBox_UserRegister_Leave);
            // 
            // label_ContraseñaRegistro
            // 
            this.label_ContraseñaRegistro.AutoSize = true;
            this.label_ContraseñaRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ContraseñaRegistro.Location = new System.Drawing.Point(354, 109);
            this.label_ContraseñaRegistro.Name = "label_ContraseñaRegistro";
            this.label_ContraseñaRegistro.Size = new System.Drawing.Size(61, 13);
            this.label_ContraseñaRegistro.TabIndex = 8;
            this.label_ContraseñaRegistro.Text = "Contraseña";
            // 
            // label_UsuarioRegistro
            // 
            this.label_UsuarioRegistro.AutoSize = true;
            this.label_UsuarioRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_UsuarioRegistro.Location = new System.Drawing.Point(354, 29);
            this.label_UsuarioRegistro.Name = "label_UsuarioRegistro";
            this.label_UsuarioRegistro.Size = new System.Drawing.Size(43, 13);
            this.label_UsuarioRegistro.TabIndex = 7;
            this.label_UsuarioRegistro.Text = "Usuario";
            // 
            // textBox_PasswordConfirm
            // 
            this.textBox_PasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_PasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBox_PasswordConfirm.Location = new System.Drawing.Point(371, 210);
            this.textBox_PasswordConfirm.Name = "textBox_PasswordConfirm";
            this.textBox_PasswordConfirm.Size = new System.Drawing.Size(208, 15);
            this.textBox_PasswordConfirm.TabIndex = 11;
            this.textBox_PasswordConfirm.Text = "Vuelva a ingresar la contraseña";
            this.textBox_PasswordConfirm.TextChanged += new System.EventHandler(this.textBox_PasswordConfirm_TextChanged);
            this.textBox_PasswordConfirm.Enter += new System.EventHandler(this.textBox_PasswordConfirm_Enter);
            this.textBox_PasswordConfirm.Leave += new System.EventHandler(this.textBox_PasswordConfirm_Leave);
            // 
            // label_ContraseñaConfirmada
            // 
            this.label_ContraseñaConfirmada.AutoSize = true;
            this.label_ContraseñaConfirmada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ContraseñaConfirmada.Location = new System.Drawing.Point(352, 191);
            this.label_ContraseñaConfirmada.Name = "label_ContraseñaConfirmada";
            this.label_ContraseñaConfirmada.Size = new System.Drawing.Size(107, 13);
            this.label_ContraseñaConfirmada.TabIndex = 12;
            this.label_ContraseñaConfirmada.Text = "Confirmar contraseña";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Location = new System.Drawing.Point(355, 293);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(224, 42);
            this.btn_Registrar.TabIndex = 13;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // labelResgistro_Message
            // 
            this.labelResgistro_Message.AutoSize = true;
            this.labelResgistro_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResgistro_Message.ForeColor = System.Drawing.Color.White;
            this.labelResgistro_Message.Location = new System.Drawing.Point(354, 256);
            this.labelResgistro_Message.Name = "labelResgistro_Message";
            this.labelResgistro_Message.Size = new System.Drawing.Size(58, 13);
            this.labelResgistro_Message.TabIndex = 16;
            this.labelResgistro_Message.Text = "Mensaje ";
            this.labelResgistro_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResgistro_Message.Visible = false;
            // 
            // userLine
            // 
            this.userLine.BackColor = System.Drawing.Color.Yellow;
            this.userLine.Enabled = false;
            this.userLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLine.ForeColor = System.Drawing.Color.White;
            this.userLine.Location = new System.Drawing.Point(357, 69);
            this.userLine.Name = "userLine";
            this.userLine.Size = new System.Drawing.Size(224, 2);
            this.userLine.TabIndex = 17;
            this.userLine.Text = "button1";
            this.userLine.UseVisualStyleBackColor = false;
            // 
            // passwordLine
            // 
            this.passwordLine.Enabled = false;
            this.passwordLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLine.ForeColor = System.Drawing.Color.White;
            this.passwordLine.Location = new System.Drawing.Point(355, 149);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(224, 2);
            this.passwordLine.TabIndex = 18;
            this.passwordLine.Text = "button2";
            this.passwordLine.UseVisualStyleBackColor = true;
            // 
            // passvalidLine
            // 
            this.passvalidLine.Enabled = false;
            this.passvalidLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passvalidLine.ForeColor = System.Drawing.Color.White;
            this.passvalidLine.Location = new System.Drawing.Point(355, 231);
            this.passvalidLine.Name = "passvalidLine";
            this.passvalidLine.Size = new System.Drawing.Size(224, 2);
            this.passvalidLine.TabIndex = 19;
            this.passvalidLine.Text = "button3";
            this.passvalidLine.UseVisualStyleBackColor = true;
            // 
            // btn_regresarLogin
            // 
            this.btn_regresarLogin.AutoSize = true;
            this.btn_regresarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresarLogin.LinkColor = System.Drawing.Color.Gray;
            this.btn_regresarLogin.Location = new System.Drawing.Point(387, 341);
            this.btn_regresarLogin.Name = "btn_regresarLogin";
            this.btn_regresarLogin.Size = new System.Drawing.Size(157, 15);
            this.btn_regresarLogin.TabIndex = 21;
            this.btn_regresarLogin.TabStop = true;
            this.btn_regresarLogin.Text = "¿Ya tienes una cuenta?";
            this.btn_regresarLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_regresarLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_regresarLogin_LinkClicked);
            // 
            // btnRegistrar_volver
            // 
            this.btnRegistrar_volver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar_volver.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar_volver.FlatAppearance.BorderSize = 0;
            this.btnRegistrar_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar_volver.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistrar_volver.Image = global::InterfazUsuario.Properties.Resources.flecha_correcta__1_;
            this.btnRegistrar_volver.Location = new System.Drawing.Point(173, 36);
            this.btnRegistrar_volver.Name = "btnRegistrar_volver";
            this.btnRegistrar_volver.Size = new System.Drawing.Size(40, 42);
            this.btnRegistrar_volver.TabIndex = 22;
            this.btnRegistrar_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrar_volver.UseVisualStyleBackColor = false;
            this.btnRegistrar_volver.Click += new System.EventHandler(this.btnRegistrar_volver_Click);
            // 
            // pictureBoxRegistrar
            // 
            this.pictureBoxRegistrar.Image = global::InterfazUsuario.Properties.Resources.registro;
            this.pictureBoxRegistrar.Location = new System.Drawing.Point(-121, -3);
            this.pictureBoxRegistrar.Name = "pictureBoxRegistrar";
            this.pictureBoxRegistrar.Size = new System.Drawing.Size(436, 474);
            this.pictureBoxRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRegistrar.TabIndex = 20;
            this.pictureBoxRegistrar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(423, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 3);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(452, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 3);
            this.panel2.TabIndex = 25;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(480, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 3);
            this.panel3.TabIndex = 25;
            this.panel3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(536, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 3);
            this.panel5.TabIndex = 27;
            this.panel5.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(508, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 3);
            this.panel4.TabIndex = 28;
            this.panel4.Visible = false;
            // 
            // labelRegistro_pass
            // 
            this.labelRegistro_pass.AutoSize = true;
            this.labelRegistro_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro_pass.ForeColor = System.Drawing.Color.White;
            this.labelRegistro_pass.Location = new System.Drawing.Point(367, 153);
            this.labelRegistro_pass.Name = "labelRegistro_pass";
            this.labelRegistro_pass.Size = new System.Drawing.Size(53, 13);
            this.labelRegistro_pass.TabIndex = 31;
            this.labelRegistro_pass.Text = "seguridad";
            this.labelRegistro_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRegistro_pass.Visible = false;
            // 
            // form_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(634, 390);
            this.Controls.Add(this.labelRegistro_pass);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelResgistro_Message);
            this.Controls.Add(this.btnRegistrar_volver);
            this.Controls.Add(this.btn_regresarLogin);
            this.Controls.Add(this.pictureBoxRegistrar);
            this.Controls.Add(this.passvalidLine);
            this.Controls.Add(this.passwordLine);
            this.Controls.Add(this.userLine);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label_ContraseñaConfirmada);
            this.Controls.Add(this.textBox_PasswordConfirm);
            this.Controls.Add(this.textBox_PasswordRegister);
            this.Controls.Add(this.textBox_UserRegister);
            this.Controls.Add(this.label_ContraseñaRegistro);
            this.Controls.Add(this.label_UsuarioRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_PasswordRegister;
        private System.Windows.Forms.TextBox textBox_UserRegister;
        private System.Windows.Forms.Label label_ContraseñaRegistro;
        private System.Windows.Forms.Label label_UsuarioRegistro;
        private System.Windows.Forms.TextBox textBox_PasswordConfirm;
        private System.Windows.Forms.Label label_ContraseñaConfirmada;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label labelResgistro_Message;
        private System.Windows.Forms.Button userLine;
        private System.Windows.Forms.Button passwordLine;
        private System.Windows.Forms.Button passvalidLine;
        private System.Windows.Forms.PictureBox pictureBoxRegistrar;
        private System.Windows.Forms.LinkLabel btn_regresarLogin;
        private System.Windows.Forms.Button btnRegistrar_volver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelRegistro_pass;
    }
}