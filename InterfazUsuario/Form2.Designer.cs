
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_menuContenedor = new System.Windows.Forms.Panel();
            this.btn_creditos = new System.Windows.Forms.Button();
            this.btn_modElim = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.panel_UsuarioContenedor = new System.Windows.Forms.Panel();
            this.textBox_userlog = new System.Windows.Forms.TextBox();
            this.label_userLog = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.panel_menuContenedor.SuspendLayout();
            this.panel_UsuarioContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel_menuContenedor
            // 
            this.panel_menuContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel_menuContenedor.Controls.Add(this.btn_creditos);
            this.panel_menuContenedor.Controls.Add(this.btn_modElim);
            this.panel_menuContenedor.Controls.Add(this.btn_Crear);
            this.panel_menuContenedor.Controls.Add(this.panel_UsuarioContenedor);
            this.panel_menuContenedor.Controls.Add(this.btn_logout);
            this.panel_menuContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menuContenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_menuContenedor.Name = "panel_menuContenedor";
            this.panel_menuContenedor.Size = new System.Drawing.Size(197, 461);
            this.panel_menuContenedor.TabIndex = 1;
            // 
            // btn_creditos
            // 
            this.btn_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_creditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_creditos.FlatAppearance.BorderSize = 0;
            this.btn_creditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creditos.ForeColor = System.Drawing.Color.White;
            this.btn_creditos.Location = new System.Drawing.Point(0, 162);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_creditos.Size = new System.Drawing.Size(197, 50);
            this.btn_creditos.TabIndex = 7;
            this.btn_creditos.Text = "Creditos";
            this.btn_creditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_creditos.UseMnemonic = false;
            this.btn_creditos.UseVisualStyleBackColor = false;
            // 
            // btn_modElim
            // 
            this.btn_modElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_modElim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_modElim.FlatAppearance.BorderSize = 0;
            this.btn_modElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_modElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modElim.ForeColor = System.Drawing.Color.White;
            this.btn_modElim.Location = new System.Drawing.Point(0, 112);
            this.btn_modElim.Name = "btn_modElim";
            this.btn_modElim.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_modElim.Size = new System.Drawing.Size(197, 50);
            this.btn_modElim.TabIndex = 6;
            this.btn_modElim.Text = "Modificar / Eliminar ";
            this.btn_modElim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modElim.UseMnemonic = false;
            this.btn_modElim.UseVisualStyleBackColor = false;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Crear.FlatAppearance.BorderSize = 0;
            this.btn_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.ForeColor = System.Drawing.Color.White;
            this.btn_Crear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Crear.Location = new System.Drawing.Point(0, 62);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Crear.Size = new System.Drawing.Size(197, 50);
            this.btn_Crear.TabIndex = 5;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // panel_UsuarioContenedor
            // 
            this.panel_UsuarioContenedor.Controls.Add(this.textBox_userlog);
            this.panel_UsuarioContenedor.Controls.Add(this.label_userLog);
            this.panel_UsuarioContenedor.Controls.Add(this.pictureBox_User);
            this.panel_UsuarioContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UsuarioContenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_UsuarioContenedor.Name = "panel_UsuarioContenedor";
            this.panel_UsuarioContenedor.Size = new System.Drawing.Size(197, 62);
            this.panel_UsuarioContenedor.TabIndex = 4;
            // 
            // textBox_userlog
            // 
            this.textBox_userlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_userlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_userlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userlog.ForeColor = System.Drawing.Color.White;
            this.textBox_userlog.Location = new System.Drawing.Point(103, 26);
            this.textBox_userlog.Name = "textBox_userlog";
            this.textBox_userlog.Size = new System.Drawing.Size(90, 13);
            this.textBox_userlog.TabIndex = 2;
            this.textBox_userlog.Text = "Admin";
            // 
            // label_userLog
            // 
            this.label_userLog.AutoSize = true;
            this.label_userLog.ForeColor = System.Drawing.Color.White;
            this.label_userLog.Location = new System.Drawing.Point(55, 26);
            this.label_userLog.Name = "label_userLog";
            this.label_userLog.Size = new System.Drawing.Size(46, 13);
            this.label_userLog.TabIndex = 1;
            this.label_userLog.Text = "Usuario:";
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
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 411);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(197, 50);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Cerrar Sesión";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(197, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(760, 461);
            this.panel_Contenedor.TabIndex = 2;
            this.panel_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Contenedor_Paint);
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(957, 461);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_menuContenedor);
            this.Name = "form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.panel_menuContenedor.ResumeLayout(false);
            this.panel_UsuarioContenedor.ResumeLayout(false);
            this.panel_UsuarioContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_menuContenedor;
        private System.Windows.Forms.Button btn_creditos;
        private System.Windows.Forms.Button btn_modElim;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Panel panel_UsuarioContenedor;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.TextBox textBox_userlog;
        private System.Windows.Forms.Label label_userLog;
        private System.Windows.Forms.Panel panel_Contenedor;
    }
}