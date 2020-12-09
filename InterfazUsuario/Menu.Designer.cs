
namespace InterfazUsuario
{
    partial class form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Menu));
            this.panel_menuContenedor = new System.Windows.Forms.Panel();
            this.btnMenu_creditos = new System.Windows.Forms.Button();
            this.btnMenu_modElim = new System.Windows.Forms.Button();
            this.btnMenu_Crear = new System.Windows.Forms.Button();
            this.panel_UsuarioContenedor = new System.Windows.Forms.Panel();
            this.textBoxMenu_userlog = new System.Windows.Forms.TextBox();
            this.labelMenu_userLog = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.btnMenu_logout = new System.Windows.Forms.Button();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.panel_menuContenedor.SuspendLayout();
            this.panel_UsuarioContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menuContenedor
            // 
            this.panel_menuContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel_menuContenedor.Controls.Add(this.btnMenu_creditos);
            this.panel_menuContenedor.Controls.Add(this.btnMenu_modElim);
            this.panel_menuContenedor.Controls.Add(this.btnMenu_Crear);
            this.panel_menuContenedor.Controls.Add(this.panel_UsuarioContenedor);
            this.panel_menuContenedor.Controls.Add(this.btnMenu_logout);
            this.panel_menuContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menuContenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_menuContenedor.Name = "panel_menuContenedor";
            this.panel_menuContenedor.Size = new System.Drawing.Size(197, 461);
            this.panel_menuContenedor.TabIndex = 1;
            // 
            // btnMenu_creditos
            // 
            this.btnMenu_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnMenu_creditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_creditos.FlatAppearance.BorderSize = 0;
            this.btnMenu_creditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_creditos.ForeColor = System.Drawing.Color.White;
            this.btnMenu_creditos.Location = new System.Drawing.Point(0, 162);
            this.btnMenu_creditos.Name = "btnMenu_creditos";
            this.btnMenu_creditos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMenu_creditos.Size = new System.Drawing.Size(197, 50);
            this.btnMenu_creditos.TabIndex = 7;
            this.btnMenu_creditos.Text = "Creditos";
            this.btnMenu_creditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_creditos.UseMnemonic = false;
            this.btnMenu_creditos.UseVisualStyleBackColor = false;
            this.btnMenu_creditos.Click += new System.EventHandler(this.btnMenu_creditos_Click);
            // 
            // btnMenu_modElim
            // 
            this.btnMenu_modElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnMenu_modElim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_modElim.FlatAppearance.BorderSize = 0;
            this.btnMenu_modElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu_modElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_modElim.ForeColor = System.Drawing.Color.White;
            this.btnMenu_modElim.Location = new System.Drawing.Point(0, 112);
            this.btnMenu_modElim.Name = "btnMenu_modElim";
            this.btnMenu_modElim.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMenu_modElim.Size = new System.Drawing.Size(197, 50);
            this.btnMenu_modElim.TabIndex = 6;
            this.btnMenu_modElim.Text = "Modificar / Eliminar ";
            this.btnMenu_modElim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_modElim.UseMnemonic = false;
            this.btnMenu_modElim.UseVisualStyleBackColor = false;
            this.btnMenu_modElim.Click += new System.EventHandler(this.btnMenu_modElim_Click);
            // 
            // btnMenu_Crear
            // 
            this.btnMenu_Crear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_Crear.FlatAppearance.BorderSize = 0;
            this.btnMenu_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_Crear.ForeColor = System.Drawing.Color.White;
            this.btnMenu_Crear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu_Crear.Location = new System.Drawing.Point(0, 62);
            this.btnMenu_Crear.Name = "btnMenu_Crear";
            this.btnMenu_Crear.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMenu_Crear.Size = new System.Drawing.Size(197, 50);
            this.btnMenu_Crear.TabIndex = 5;
            this.btnMenu_Crear.Text = "Crear";
            this.btnMenu_Crear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_Crear.UseVisualStyleBackColor = false;
            this.btnMenu_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // panel_UsuarioContenedor
            // 
            this.panel_UsuarioContenedor.Controls.Add(this.textBoxMenu_userlog);
            this.panel_UsuarioContenedor.Controls.Add(this.labelMenu_userLog);
            this.panel_UsuarioContenedor.Controls.Add(this.pictureBox_User);
            this.panel_UsuarioContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UsuarioContenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_UsuarioContenedor.Name = "panel_UsuarioContenedor";
            this.panel_UsuarioContenedor.Size = new System.Drawing.Size(197, 62);
            this.panel_UsuarioContenedor.TabIndex = 4;
            // 
            // textBoxMenu_userlog
            // 
            this.textBoxMenu_userlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxMenu_userlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMenu_userlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenu_userlog.ForeColor = System.Drawing.Color.White;
            this.textBoxMenu_userlog.Location = new System.Drawing.Point(103, 26);
            this.textBoxMenu_userlog.Name = "textBoxMenu_userlog";
            this.textBoxMenu_userlog.ReadOnly = true;
            this.textBoxMenu_userlog.Size = new System.Drawing.Size(90, 13);
            this.textBoxMenu_userlog.TabIndex = 2;
            this.textBoxMenu_userlog.Text = "Admin";
            // 
            // labelMenu_userLog
            // 
            this.labelMenu_userLog.AutoSize = true;
            this.labelMenu_userLog.ForeColor = System.Drawing.Color.White;
            this.labelMenu_userLog.Location = new System.Drawing.Point(55, 26);
            this.labelMenu_userLog.Name = "labelMenu_userLog";
            this.labelMenu_userLog.Size = new System.Drawing.Size(46, 13);
            this.labelMenu_userLog.TabIndex = 1;
            this.labelMenu_userLog.Text = "Usuario:";
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Image = global::InterfazUsuario.Properties.Resources.usuario;
            this.pictureBox_User.Location = new System.Drawing.Point(25, 21);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(23, 21);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User.TabIndex = 0;
            this.pictureBox_User.TabStop = false;
            // 
            // btnMenu_logout
            // 
            this.btnMenu_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMenu_logout.FlatAppearance.BorderSize = 0;
            this.btnMenu_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_logout.ForeColor = System.Drawing.Color.White;
            this.btnMenu_logout.Location = new System.Drawing.Point(0, 411);
            this.btnMenu_logout.Name = "btnMenu_logout";
            this.btnMenu_logout.Size = new System.Drawing.Size(197, 50);
            this.btnMenu_logout.TabIndex = 3;
            this.btnMenu_logout.Text = "Cerrar Sesión";
            this.btnMenu_logout.UseVisualStyleBackColor = false;
            this.btnMenu_logout.Click += new System.EventHandler(this.btnMenu_logout_Click);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(197, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(760, 461);
            this.panel_Contenedor.TabIndex = 2;
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(957, 461);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_menuContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.form_Menu_Load);
            this.panel_menuContenedor.ResumeLayout(false);
            this.panel_UsuarioContenedor.ResumeLayout(false);
            this.panel_UsuarioContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menuContenedor;
        private System.Windows.Forms.Button btnMenu_creditos;
        private System.Windows.Forms.Button btnMenu_modElim;
        private System.Windows.Forms.Button btnMenu_Crear;
        private System.Windows.Forms.Panel panel_UsuarioContenedor;
        private System.Windows.Forms.Button btnMenu_logout;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Label labelMenu_userLog;
        private System.Windows.Forms.Panel panel_Contenedor;
        public System.Windows.Forms.TextBox textBoxMenu_userlog;
    }
}