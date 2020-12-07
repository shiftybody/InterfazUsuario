
namespace InterfazUsuario
{
    partial class MensajeAlerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeAlerta));
            this.buttonAlert_Acept = new System.Windows.Forms.Button();
            this.textBoxAlert_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAlert_Acept
            // 
            this.buttonAlert_Acept.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAlert_Acept.FlatAppearance.BorderSize = 0;
            this.buttonAlert_Acept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAlert_Acept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlert_Acept.ForeColor = System.Drawing.Color.Black;
            this.buttonAlert_Acept.Location = new System.Drawing.Point(268, 182);
            this.buttonAlert_Acept.Name = "buttonAlert_Acept";
            this.buttonAlert_Acept.Size = new System.Drawing.Size(224, 42);
            this.buttonAlert_Acept.TabIndex = 0;
            this.buttonAlert_Acept.Text = "ACEPTAR";
            this.buttonAlert_Acept.UseVisualStyleBackColor = false;
            this.buttonAlert_Acept.Click += new System.EventHandler(this.buttonAlert_Acept_Click);
            // 
            // textBoxAlert_Message
            // 
            this.textBoxAlert_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBoxAlert_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlert_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlert_Message.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxAlert_Message.Location = new System.Drawing.Point(34, 67);
            this.textBoxAlert_Message.Multiline = true;
            this.textBoxAlert_Message.Name = "textBoxAlert_Message";
            this.textBoxAlert_Message.ReadOnly = true;
            this.textBoxAlert_Message.Size = new System.Drawing.Size(458, 83);
            this.textBoxAlert_Message.TabIndex = 1;
            this.textBoxAlert_Message.Text = "MENSAJE";
            this.textBoxAlert_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MensajeAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(514, 249);
            this.Controls.Add(this.textBoxAlert_Message);
            this.Controls.Add(this.buttonAlert_Acept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensajeAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxAlert_Message;
        public System.Windows.Forms.Button buttonAlert_Acept;
    }
}