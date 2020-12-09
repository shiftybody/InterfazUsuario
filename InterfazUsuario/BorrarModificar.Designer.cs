
namespace InterfazUsuario
{
    partial class form_modBajas
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
            this.labelMod_Message = new System.Windows.Forms.Label();
            this.labelMod_Date = new System.Windows.Forms.Label();
            this.labelMod_Tmin = new System.Windows.Forms.Label();
            this.labelMod_Tmax = new System.Windows.Forms.Label();
            this.labelMod_Evap = new System.Windows.Forms.Label();
            this.labelMod_Prec = new System.Windows.Forms.Label();
            this.monthCalendarMod_Date = new System.Windows.Forms.MonthCalendar();
            this.textBoxMod_ID = new System.Windows.Forms.TextBox();
            this.labelMod_ID = new System.Windows.Forms.Label();
            this.btnMod_Eliminar = new System.Windows.Forms.Button();
            this.labelMod_MessageBusqueda = new System.Windows.Forms.Label();
            this.btnMod_Buscar = new System.Windows.Forms.Button();
            this.textBoxMod_Date = new System.Windows.Forms.TextBox();
            this.btnMod_Guardar = new System.Windows.Forms.Button();
            this.textBoxMod_Preci = new System.Windows.Forms.TextBox();
            this.textBoxMod_Evap = new System.Windows.Forms.TextBox();
            this.textBoxMod_Tmax = new System.Windows.Forms.TextBox();
            this.textBoxMod_Tmin = new System.Windows.Forms.TextBox();
            this.checkBoxMod_Nulo = new System.Windows.Forms.CheckBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnAnswerN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMod_Message
            // 
            this.labelMod_Message.AutoSize = true;
            this.labelMod_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMod_Message.Location = new System.Drawing.Point(434, 309);
            this.labelMod_Message.Name = "labelMod_Message";
            this.labelMod_Message.Size = new System.Drawing.Size(189, 16);
            this.labelMod_Message.TabIndex = 32;
            this.labelMod_Message.Text = "Mensaje de Error invisible";
            this.labelMod_Message.Visible = false;
            // 
            // labelMod_Date
            // 
            this.labelMod_Date.AutoSize = true;
            this.labelMod_Date.Location = new System.Drawing.Point(45, 131);
            this.labelMod_Date.Name = "labelMod_Date";
            this.labelMod_Date.Size = new System.Drawing.Size(37, 13);
            this.labelMod_Date.TabIndex = 28;
            this.labelMod_Date.Text = "Fecha";
            // 
            // labelMod_Tmin
            // 
            this.labelMod_Tmin.AutoSize = true;
            this.labelMod_Tmin.Location = new System.Drawing.Point(380, 254);
            this.labelMod_Tmin.Name = "labelMod_Tmin";
            this.labelMod_Tmin.Size = new System.Drawing.Size(105, 13);
            this.labelMod_Tmin.TabIndex = 25;
            this.labelMod_Tmin.Text = "Temperatura Mínima";
            // 
            // labelMod_Tmax
            // 
            this.labelMod_Tmax.AutoSize = true;
            this.labelMod_Tmax.Location = new System.Drawing.Point(380, 197);
            this.labelMod_Tmax.Name = "labelMod_Tmax";
            this.labelMod_Tmax.Size = new System.Drawing.Size(106, 13);
            this.labelMod_Tmax.TabIndex = 24;
            this.labelMod_Tmax.Text = "Temperatura Máxima";
            // 
            // labelMod_Evap
            // 
            this.labelMod_Evap.AutoSize = true;
            this.labelMod_Evap.Location = new System.Drawing.Point(418, 142);
            this.labelMod_Evap.Name = "labelMod_Evap";
            this.labelMod_Evap.Size = new System.Drawing.Size(67, 13);
            this.labelMod_Evap.TabIndex = 23;
            this.labelMod_Evap.Text = "Evaporación";
            // 
            // labelMod_Prec
            // 
            this.labelMod_Prec.AutoSize = true;
            this.labelMod_Prec.Location = new System.Drawing.Point(417, 86);
            this.labelMod_Prec.Name = "labelMod_Prec";
            this.labelMod_Prec.Size = new System.Drawing.Size(68, 13);
            this.labelMod_Prec.TabIndex = 22;
            this.labelMod_Prec.Text = "Precipitación";
            // 
            // monthCalendarMod_Date
            // 
            this.monthCalendarMod_Date.Location = new System.Drawing.Point(88, 163);
            this.monthCalendarMod_Date.MaxSelectionCount = 1;
            this.monthCalendarMod_Date.Name = "monthCalendarMod_Date";
            this.monthCalendarMod_Date.ShowTodayCircle = false;
            this.monthCalendarMod_Date.TabIndex = 21;
            this.monthCalendarMod_Date.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMod_Date_DateSelected);
            // 
            // textBoxMod_ID
            // 
            this.textBoxMod_ID.Location = new System.Drawing.Point(88, 83);
            this.textBoxMod_ID.Name = "textBoxMod_ID";
            this.textBoxMod_ID.Size = new System.Drawing.Size(131, 20);
            this.textBoxMod_ID.TabIndex = 20;
            // 
            // labelMod_ID
            // 
            this.labelMod_ID.AutoSize = true;
            this.labelMod_ID.Location = new System.Drawing.Point(64, 85);
            this.labelMod_ID.Name = "labelMod_ID";
            this.labelMod_ID.Size = new System.Drawing.Size(18, 13);
            this.labelMod_ID.TabIndex = 19;
            this.labelMod_ID.Text = "ID";
            // 
            // btnMod_Eliminar
            // 
            this.btnMod_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMod_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMod_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btnMod_Eliminar.Location = new System.Drawing.Point(386, 367);
            this.btnMod_Eliminar.Name = "btnMod_Eliminar";
            this.btnMod_Eliminar.Size = new System.Drawing.Size(125, 45);
            this.btnMod_Eliminar.TabIndex = 33;
            this.btnMod_Eliminar.Text = "ELIMINAR";
            this.btnMod_Eliminar.UseVisualStyleBackColor = true;
            this.btnMod_Eliminar.Click += new System.EventHandler(this.btnMod_Eliminar_Click);
            // 
            // labelMod_MessageBusqueda
            // 
            this.labelMod_MessageBusqueda.AutoSize = true;
            this.labelMod_MessageBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMod_MessageBusqueda.Location = new System.Drawing.Point(194, 125);
            this.labelMod_MessageBusqueda.Name = "labelMod_MessageBusqueda";
            this.labelMod_MessageBusqueda.Size = new System.Drawing.Size(189, 16);
            this.labelMod_MessageBusqueda.TabIndex = 34;
            this.labelMod_MessageBusqueda.Text = "Mensaje de Error invisible";
            this.labelMod_MessageBusqueda.Visible = false;
            // 
            // btnMod_Buscar
            // 
            this.btnMod_Buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMod_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMod_Buscar.ForeColor = System.Drawing.Color.Black;
            this.btnMod_Buscar.Location = new System.Drawing.Point(244, 81);
            this.btnMod_Buscar.Name = "btnMod_Buscar";
            this.btnMod_Buscar.Size = new System.Drawing.Size(126, 26);
            this.btnMod_Buscar.TabIndex = 35;
            this.btnMod_Buscar.Text = "BUSCAR";
            this.btnMod_Buscar.UseVisualStyleBackColor = false;
            this.btnMod_Buscar.Click += new System.EventHandler(this.btnMod_Buscar_Click);
            // 
            // textBoxMod_Date
            // 
            this.textBoxMod_Date.Location = new System.Drawing.Point(88, 124);
            this.textBoxMod_Date.Name = "textBoxMod_Date";
            this.textBoxMod_Date.Size = new System.Drawing.Size(100, 20);
            this.textBoxMod_Date.TabIndex = 36;
            // 
            // btnMod_Guardar
            // 
            this.btnMod_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(207)))), ((int)(((byte)(5)))));
            this.btnMod_Guardar.FlatAppearance.BorderSize = 0;
            this.btnMod_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod_Guardar.Image = global::InterfazUsuario.Properties.Resources.disquete__1_;
            this.btnMod_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod_Guardar.Location = new System.Drawing.Point(532, 367);
            this.btnMod_Guardar.Name = "btnMod_Guardar";
            this.btnMod_Guardar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMod_Guardar.Size = new System.Drawing.Size(168, 45);
            this.btnMod_Guardar.TabIndex = 31;
            this.btnMod_Guardar.Text = "   GUARDAR CAMBIOS";
            this.btnMod_Guardar.UseVisualStyleBackColor = false;
            this.btnMod_Guardar.Click += new System.EventHandler(this.btnMod_Guardar_Click);
            // 
            // textBoxMod_Preci
            // 
            this.textBoxMod_Preci.Location = new System.Drawing.Point(501, 83);
            this.textBoxMod_Preci.Name = "textBoxMod_Preci";
            this.textBoxMod_Preci.Size = new System.Drawing.Size(150, 20);
            this.textBoxMod_Preci.TabIndex = 38;
            // 
            // textBoxMod_Evap
            // 
            this.textBoxMod_Evap.Location = new System.Drawing.Point(501, 138);
            this.textBoxMod_Evap.Name = "textBoxMod_Evap";
            this.textBoxMod_Evap.Size = new System.Drawing.Size(80, 20);
            this.textBoxMod_Evap.TabIndex = 39;
            // 
            // textBoxMod_Tmax
            // 
            this.textBoxMod_Tmax.Location = new System.Drawing.Point(501, 194);
            this.textBoxMod_Tmax.Name = "textBoxMod_Tmax";
            this.textBoxMod_Tmax.Size = new System.Drawing.Size(150, 20);
            this.textBoxMod_Tmax.TabIndex = 40;
            // 
            // textBoxMod_Tmin
            // 
            this.textBoxMod_Tmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMod_Tmin.Location = new System.Drawing.Point(501, 254);
            this.textBoxMod_Tmin.Name = "textBoxMod_Tmin";
            this.textBoxMod_Tmin.Size = new System.Drawing.Size(150, 20);
            this.textBoxMod_Tmin.TabIndex = 41;
            // 
            // checkBoxMod_Nulo
            // 
            this.checkBoxMod_Nulo.AutoSize = true;
            this.checkBoxMod_Nulo.Location = new System.Drawing.Point(595, 142);
            this.checkBoxMod_Nulo.Name = "checkBoxMod_Nulo";
            this.checkBoxMod_Nulo.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMod_Nulo.TabIndex = 42;
            this.checkBoxMod_Nulo.Text = "NULO";
            this.checkBoxMod_Nulo.UseVisualStyleBackColor = true;
            this.checkBoxMod_Nulo.CheckedChanged += new System.EventHandler(this.checkBoxMod_Nulo_CheckedChanged);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnswer.FlatAppearance.BorderSize = 0;
            this.btnAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(532, 367);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(76, 45);
            this.btnAnswer.TabIndex = 43;
            this.btnAnswer.Text = "SI";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Visible = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerN
            // 
            this.btnAnswerN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnswerN.FlatAppearance.BorderSize = 0;
            this.btnAnswerN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAnswerN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAnswerN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerN.Location = new System.Drawing.Point(624, 367);
            this.btnAnswerN.Name = "btnAnswerN";
            this.btnAnswerN.Size = new System.Drawing.Size(76, 45);
            this.btnAnswerN.TabIndex = 44;
            this.btnAnswerN.Text = "NO";
            this.btnAnswerN.UseVisualStyleBackColor = false;
            this.btnAnswerN.Visible = false;
            this.btnAnswerN.Click += new System.EventHandler(this.btnAnswerN_Click);
            // 
            // form_modBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.btnAnswerN);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.checkBoxMod_Nulo);
            this.Controls.Add(this.textBoxMod_Tmin);
            this.Controls.Add(this.textBoxMod_Tmax);
            this.Controls.Add(this.textBoxMod_Evap);
            this.Controls.Add(this.textBoxMod_Preci);
            this.Controls.Add(this.textBoxMod_Date);
            this.Controls.Add(this.btnMod_Buscar);
            this.Controls.Add(this.labelMod_MessageBusqueda);
            this.Controls.Add(this.btnMod_Eliminar);
            this.Controls.Add(this.labelMod_Message);
            this.Controls.Add(this.btnMod_Guardar);
            this.Controls.Add(this.labelMod_Date);
            this.Controls.Add(this.labelMod_Tmin);
            this.Controls.Add(this.labelMod_Tmax);
            this.Controls.Add(this.labelMod_Evap);
            this.Controls.Add(this.labelMod_Prec);
            this.Controls.Add(this.monthCalendarMod_Date);
            this.Controls.Add(this.textBoxMod_ID);
            this.Controls.Add(this.labelMod_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_modBajas";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.form_modBajas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMod_Message;
        private System.Windows.Forms.Button btnMod_Guardar;
        private System.Windows.Forms.Label labelMod_Date;
        private System.Windows.Forms.Label labelMod_Tmin;
        private System.Windows.Forms.Label labelMod_Tmax;
        private System.Windows.Forms.Label labelMod_Evap;
        private System.Windows.Forms.Label labelMod_Prec;
        private System.Windows.Forms.MonthCalendar monthCalendarMod_Date;
        private System.Windows.Forms.TextBox textBoxMod_ID;
        private System.Windows.Forms.Label labelMod_ID;
        private System.Windows.Forms.Button btnMod_Eliminar;
        private System.Windows.Forms.Label labelMod_MessageBusqueda;
        private System.Windows.Forms.Button btnMod_Buscar;
        private System.Windows.Forms.TextBox textBoxMod_Date;
        private System.Windows.Forms.TextBox textBoxMod_Preci;
        private System.Windows.Forms.TextBox textBoxMod_Evap;
        private System.Windows.Forms.TextBox textBoxMod_Tmax;
        private System.Windows.Forms.TextBox textBoxMod_Tmin;
        private System.Windows.Forms.CheckBox checkBoxMod_Nulo;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnAnswerN;
    }
}