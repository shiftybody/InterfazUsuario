
namespace InterfazUsuario
{
    partial class form_Creditos
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
            this.labelContact_Nombre = new System.Windows.Forms.Label();
            this.labelContact_Exp = new System.Windows.Forms.Label();
            this.labelContact_ExpNum = new System.Windows.Forms.Label();
            this.labelContact_Correo = new System.Windows.Forms.Label();
            this.labelContact_Correo1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox_Contact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Contact)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContact_Nombre
            // 
            this.labelContact_Nombre.AutoSize = true;
            this.labelContact_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact_Nombre.Location = new System.Drawing.Point(139, 130);
            this.labelContact_Nombre.Name = "labelContact_Nombre";
            this.labelContact_Nombre.Size = new System.Drawing.Size(244, 18);
            this.labelContact_Nombre.TabIndex = 1;
            this.labelContact_Nombre.Text = "David Emmanuel Cano Cabrera";
            // 
            // labelContact_Exp
            // 
            this.labelContact_Exp.AutoSize = true;
            this.labelContact_Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact_Exp.Location = new System.Drawing.Point(213, 186);
            this.labelContact_Exp.Name = "labelContact_Exp";
            this.labelContact_Exp.Size = new System.Drawing.Size(95, 18);
            this.labelContact_Exp.TabIndex = 2;
            this.labelContact_Exp.Text = "Expediente:";
            // 
            // labelContact_ExpNum
            // 
            this.labelContact_ExpNum.AutoSize = true;
            this.labelContact_ExpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact_ExpNum.Location = new System.Drawing.Point(230, 210);
            this.labelContact_ExpNum.Name = "labelContact_ExpNum";
            this.labelContact_ExpNum.Size = new System.Drawing.Size(56, 18);
            this.labelContact_ExpNum.TabIndex = 3;
            this.labelContact_ExpNum.Text = "297140";
            // 
            // labelContact_Correo
            // 
            this.labelContact_Correo.AutoSize = true;
            this.labelContact_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact_Correo.Location = new System.Drawing.Point(151, 265);
            this.labelContact_Correo.Name = "labelContact_Correo";
            this.labelContact_Correo.Size = new System.Drawing.Size(82, 18);
            this.labelContact_Correo.TabIndex = 4;
            this.labelContact_Correo.Text = "Contacto:";
            // 
            // labelContact_Correo1
            // 
            this.labelContact_Correo1.AutoSize = true;
            this.labelContact_Correo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact_Correo1.LinkColor = System.Drawing.Color.DarkRed;
            this.labelContact_Correo1.Location = new System.Drawing.Point(225, 265);
            this.labelContact_Correo1.Name = "labelContact_Correo1";
            this.labelContact_Correo1.Size = new System.Drawing.Size(158, 18);
            this.labelContact_Correo1.TabIndex = 5;
            this.labelContact_Correo1.TabStop = true;
            this.labelContact_Correo1.Text = "shiftybody@gmail.com";
            // 
            // pictureBox_Contact
            // 
            this.pictureBox_Contact.Image = global::InterfazUsuario.Properties.Resources._2020_09_25;
            this.pictureBox_Contact.Location = new System.Drawing.Point(436, 130);
            this.pictureBox_Contact.Name = "pictureBox_Contact";
            this.pictureBox_Contact.Size = new System.Drawing.Size(170, 170);
            this.pictureBox_Contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Contact.TabIndex = 0;
            this.pictureBox_Contact.TabStop = false;
            // 
            // form_Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.labelContact_Correo1);
            this.Controls.Add(this.labelContact_Correo);
            this.Controls.Add(this.labelContact_ExpNum);
            this.Controls.Add(this.labelContact_Exp);
            this.Controls.Add(this.labelContact_Nombre);
            this.Controls.Add(this.pictureBox_Contact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Creditos";
            this.Text = "Creditos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Contact;
        private System.Windows.Forms.Label labelContact_Nombre;
        private System.Windows.Forms.Label labelContact_Exp;
        private System.Windows.Forms.Label labelContact_ExpNum;
        private System.Windows.Forms.Label labelContact_Correo;
        private System.Windows.Forms.LinkLabel labelContact_Correo1;
    }
}