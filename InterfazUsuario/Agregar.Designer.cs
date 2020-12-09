
namespace InterfazUsuario
{
    partial class form_Altas
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
            this.layerAltas_Id = new System.Windows.Forms.Label();
            this.textBoxAltas_ID = new System.Windows.Forms.TextBox();
            this.labelAltas_Preci = new System.Windows.Forms.Label();
            this.labelAltas_Evap = new System.Windows.Forms.Label();
            this.labelAltas_Tmax = new System.Windows.Forms.Label();
            this.labelAltas_Tmin = new System.Windows.Forms.Label();
            this.labelAltas_Date = new System.Windows.Forms.Label();
            this.btnAltas_Agregar = new System.Windows.Forms.Button();
            this.labelAltas_Message = new System.Windows.Forms.Label();
            this.textBoxAltas_Date = new System.Windows.Forms.TextBox();
            this.textBoxAltas_Preci = new System.Windows.Forms.TextBox();
            this.textBoxAltas_Evap = new System.Windows.Forms.TextBox();
            this.textBoxAltas_Tmax = new System.Windows.Forms.TextBox();
            this.textBoxAltas_Tmin = new System.Windows.Forms.TextBox();
            this.checkBoxAltas_Nulo = new System.Windows.Forms.CheckBox();
            this.monthCalendarAltas_Date = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // layerAltas_Id
            // 
            this.layerAltas_Id.AutoSize = true;
            this.layerAltas_Id.Location = new System.Drawing.Point(136, 89);
            this.layerAltas_Id.Name = "layerAltas_Id";
            this.layerAltas_Id.Size = new System.Drawing.Size(18, 13);
            this.layerAltas_Id.TabIndex = 0;
            this.layerAltas_Id.Text = "ID";
            // 
            // textBoxAltas_ID
            // 
            this.textBoxAltas_ID.Location = new System.Drawing.Point(170, 87);
            this.textBoxAltas_ID.Name = "textBoxAltas_ID";
            this.textBoxAltas_ID.ReadOnly = true;
            this.textBoxAltas_ID.Size = new System.Drawing.Size(131, 20);
            this.textBoxAltas_ID.TabIndex = 1;
            // 
            // labelAltas_Preci
            // 
            this.labelAltas_Preci.AutoSize = true;
            this.labelAltas_Preci.Location = new System.Drawing.Point(418, 86);
            this.labelAltas_Preci.Name = "labelAltas_Preci";
            this.labelAltas_Preci.Size = new System.Drawing.Size(68, 13);
            this.labelAltas_Preci.TabIndex = 7;
            this.labelAltas_Preci.Text = "Precipitación";
            // 
            // labelAltas_Evap
            // 
            this.labelAltas_Evap.AutoSize = true;
            this.labelAltas_Evap.Location = new System.Drawing.Point(418, 142);
            this.labelAltas_Evap.Name = "labelAltas_Evap";
            this.labelAltas_Evap.Size = new System.Drawing.Size(67, 13);
            this.labelAltas_Evap.TabIndex = 8;
            this.labelAltas_Evap.Text = "Evaporación";
            // 
            // labelAltas_Tmax
            // 
            this.labelAltas_Tmax.AutoSize = true;
            this.labelAltas_Tmax.Location = new System.Drawing.Point(380, 197);
            this.labelAltas_Tmax.Name = "labelAltas_Tmax";
            this.labelAltas_Tmax.Size = new System.Drawing.Size(106, 13);
            this.labelAltas_Tmax.TabIndex = 9;
            this.labelAltas_Tmax.Text = "Temperatura Máxima";
            // 
            // labelAltas_Tmin
            // 
            this.labelAltas_Tmin.AutoSize = true;
            this.labelAltas_Tmin.Location = new System.Drawing.Point(380, 254);
            this.labelAltas_Tmin.Name = "labelAltas_Tmin";
            this.labelAltas_Tmin.Size = new System.Drawing.Size(105, 13);
            this.labelAltas_Tmin.TabIndex = 10;
            this.labelAltas_Tmin.Text = "Temperatura Mínima";
            // 
            // labelAltas_Date
            // 
            this.labelAltas_Date.AutoSize = true;
            this.labelAltas_Date.Location = new System.Drawing.Point(127, 141);
            this.labelAltas_Date.Name = "labelAltas_Date";
            this.labelAltas_Date.Size = new System.Drawing.Size(37, 13);
            this.labelAltas_Date.TabIndex = 13;
            this.labelAltas_Date.Text = "Fecha";
            // 
            // btnAltas_Agregar
            // 
            this.btnAltas_Agregar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAltas_Agregar.FlatAppearance.BorderSize = 0;
            this.btnAltas_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAltas_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAltas_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btnAltas_Agregar.Location = new System.Drawing.Point(532, 367);
            this.btnAltas_Agregar.Name = "btnAltas_Agregar";
            this.btnAltas_Agregar.Size = new System.Drawing.Size(168, 45);
            this.btnAltas_Agregar.TabIndex = 17;
            this.btnAltas_Agregar.Text = "AGREGAR";
            this.btnAltas_Agregar.UseVisualStyleBackColor = false;
            this.btnAltas_Agregar.Click += new System.EventHandler(this.btnAltas_Agregar_Click);
            // 
            // labelAltas_Message
            // 
            this.labelAltas_Message.AutoSize = true;
            this.labelAltas_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltas_Message.Location = new System.Drawing.Point(351, 316);
            this.labelAltas_Message.Name = "labelAltas_Message";
            this.labelAltas_Message.Size = new System.Drawing.Size(189, 16);
            this.labelAltas_Message.TabIndex = 18;
            this.labelAltas_Message.Text = "Mensaje de Error invisible";
            this.labelAltas_Message.Visible = false;
            // 
            // textBoxAltas_Date
            // 
            this.textBoxAltas_Date.Location = new System.Drawing.Point(170, 138);
            this.textBoxAltas_Date.Name = "textBoxAltas_Date";
            this.textBoxAltas_Date.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltas_Date.TabIndex = 19;
            // 
            // textBoxAltas_Preci
            // 
            this.textBoxAltas_Preci.Location = new System.Drawing.Point(501, 81);
            this.textBoxAltas_Preci.Name = "textBoxAltas_Preci";
            this.textBoxAltas_Preci.Size = new System.Drawing.Size(150, 20);
            this.textBoxAltas_Preci.TabIndex = 21;
            // 
            // textBoxAltas_Evap
            // 
            this.textBoxAltas_Evap.Location = new System.Drawing.Point(501, 142);
            this.textBoxAltas_Evap.Name = "textBoxAltas_Evap";
            this.textBoxAltas_Evap.Size = new System.Drawing.Size(80, 20);
            this.textBoxAltas_Evap.TabIndex = 22;
            // 
            // textBoxAltas_Tmax
            // 
            this.textBoxAltas_Tmax.Location = new System.Drawing.Point(501, 197);
            this.textBoxAltas_Tmax.Name = "textBoxAltas_Tmax";
            this.textBoxAltas_Tmax.Size = new System.Drawing.Size(150, 20);
            this.textBoxAltas_Tmax.TabIndex = 23;
            // 
            // textBoxAltas_Tmin
            // 
            this.textBoxAltas_Tmin.Location = new System.Drawing.Point(501, 254);
            this.textBoxAltas_Tmin.Name = "textBoxAltas_Tmin";
            this.textBoxAltas_Tmin.Size = new System.Drawing.Size(150, 20);
            this.textBoxAltas_Tmin.TabIndex = 24;
            // 
            // checkBoxAltas_Nulo
            // 
            this.checkBoxAltas_Nulo.AutoSize = true;
            this.checkBoxAltas_Nulo.Location = new System.Drawing.Point(595, 144);
            this.checkBoxAltas_Nulo.Name = "checkBoxAltas_Nulo";
            this.checkBoxAltas_Nulo.Size = new System.Drawing.Size(56, 17);
            this.checkBoxAltas_Nulo.TabIndex = 43;
            this.checkBoxAltas_Nulo.Text = "NULO";
            this.checkBoxAltas_Nulo.UseVisualStyleBackColor = true;
            this.checkBoxAltas_Nulo.CheckedChanged += new System.EventHandler(this.checkBoxAltas_Nulo_CheckedChanged);
            // 
            // monthCalendarAltas_Date
            // 
            this.monthCalendarAltas_Date.Location = new System.Drawing.Point(74, 170);
            this.monthCalendarAltas_Date.MaxSelectionCount = 1;
            this.monthCalendarAltas_Date.Name = "monthCalendarAltas_Date";
            this.monthCalendarAltas_Date.ShowTodayCircle = false;
            this.monthCalendarAltas_Date.TabIndex = 44;
            this.monthCalendarAltas_Date.TodayDate = new System.DateTime(2020, 12, 8, 0, 0, 0, 0);
            this.monthCalendarAltas_Date.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAltas_Date_DateSelected);
            // 
            // form_Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.monthCalendarAltas_Date);
            this.Controls.Add(this.checkBoxAltas_Nulo);
            this.Controls.Add(this.textBoxAltas_Tmin);
            this.Controls.Add(this.textBoxAltas_Tmax);
            this.Controls.Add(this.textBoxAltas_Evap);
            this.Controls.Add(this.textBoxAltas_Preci);
            this.Controls.Add(this.textBoxAltas_Date);
            this.Controls.Add(this.labelAltas_Message);
            this.Controls.Add(this.btnAltas_Agregar);
            this.Controls.Add(this.labelAltas_Date);
            this.Controls.Add(this.labelAltas_Tmin);
            this.Controls.Add(this.labelAltas_Tmax);
            this.Controls.Add(this.labelAltas_Evap);
            this.Controls.Add(this.labelAltas_Preci);
            this.Controls.Add(this.textBoxAltas_ID);
            this.Controls.Add(this.layerAltas_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Altas";
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.form_Altas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label layerAltas_Id;
        private System.Windows.Forms.TextBox textBoxAltas_ID;
        private System.Windows.Forms.Label labelAltas_Preci;
        private System.Windows.Forms.Label labelAltas_Evap;
        private System.Windows.Forms.Label labelAltas_Tmax;
        private System.Windows.Forms.Label labelAltas_Tmin;
        private System.Windows.Forms.Label labelAltas_Date;
        private System.Windows.Forms.Button btnAltas_Agregar;
        private System.Windows.Forms.Label labelAltas_Message;
        private System.Windows.Forms.TextBox textBoxAltas_Date;
        private System.Windows.Forms.TextBox textBoxAltas_Preci;
        private System.Windows.Forms.TextBox textBoxAltas_Evap;
        private System.Windows.Forms.TextBox textBoxAltas_Tmax;
        private System.Windows.Forms.TextBox textBoxAltas_Tmin;
        private System.Windows.Forms.CheckBox checkBoxAltas_Nulo;
        private System.Windows.Forms.MonthCalendar monthCalendarAltas_Date;
    }
}