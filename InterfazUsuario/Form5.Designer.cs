
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
            this.textBoxMod_Preci = new System.Windows.Forms.NumericUpDown();
            this.textBoxMod_Evap = new System.Windows.Forms.NumericUpDown();
            this.labelMod_Date = new System.Windows.Forms.Label();
            this.textBoxMod_Tmin = new System.Windows.Forms.NumericUpDown();
            this.textBoxMod_Tmax = new System.Windows.Forms.NumericUpDown();
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
            this.radioButtonMod_Nulo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Preci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Evap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Tmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Tmax)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMod_Message
            // 
            this.labelMod_Message.AutoSize = true;
            this.labelMod_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMod_Message.Location = new System.Drawing.Point(420, 287);
            this.labelMod_Message.Name = "labelMod_Message";
            this.labelMod_Message.Size = new System.Drawing.Size(189, 16);
            this.labelMod_Message.TabIndex = 32;
            this.labelMod_Message.Text = "Mensaje de Error invisible";
            this.labelMod_Message.Visible = false;
            // 
            // textBoxMod_Preci
            // 
            this.textBoxMod_Preci.DecimalPlaces = 1;
            this.textBoxMod_Preci.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.textBoxMod_Preci.Location = new System.Drawing.Point(515, 92);
            this.textBoxMod_Preci.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxMod_Preci.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxMod_Preci.Name = "textBoxMod_Preci";
            this.textBoxMod_Preci.Size = new System.Drawing.Size(160, 20);
            this.textBoxMod_Preci.TabIndex = 30;
            // 
            // textBoxMod_Evap
            // 
            this.textBoxMod_Evap.DecimalPlaces = 1;
            this.textBoxMod_Evap.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.textBoxMod_Evap.Location = new System.Drawing.Point(515, 127);
            this.textBoxMod_Evap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxMod_Evap.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxMod_Evap.Name = "textBoxMod_Evap";
            this.textBoxMod_Evap.Size = new System.Drawing.Size(122, 20);
            this.textBoxMod_Evap.TabIndex = 29;
            // 
            // labelMod_Date
            // 
            this.labelMod_Date.AutoSize = true;
            this.labelMod_Date.Location = new System.Drawing.Point(189, 134);
            this.labelMod_Date.Name = "labelMod_Date";
            this.labelMod_Date.Size = new System.Drawing.Size(37, 13);
            this.labelMod_Date.TabIndex = 28;
            this.labelMod_Date.Text = "Fecha";
            // 
            // textBoxMod_Tmin
            // 
            this.textBoxMod_Tmin.DecimalPlaces = 1;
            this.textBoxMod_Tmin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.textBoxMod_Tmin.Location = new System.Drawing.Point(515, 199);
            this.textBoxMod_Tmin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxMod_Tmin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxMod_Tmin.Name = "textBoxMod_Tmin";
            this.textBoxMod_Tmin.Size = new System.Drawing.Size(160, 20);
            this.textBoxMod_Tmin.TabIndex = 27;
            // 
            // textBoxMod_Tmax
            // 
            this.textBoxMod_Tmax.DecimalPlaces = 1;
            this.textBoxMod_Tmax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.textBoxMod_Tmax.Location = new System.Drawing.Point(515, 163);
            this.textBoxMod_Tmax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxMod_Tmax.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxMod_Tmax.Name = "textBoxMod_Tmax";
            this.textBoxMod_Tmax.Size = new System.Drawing.Size(160, 20);
            this.textBoxMod_Tmax.TabIndex = 26;
            // 
            // labelMod_Tmin
            // 
            this.labelMod_Tmin.AutoSize = true;
            this.labelMod_Tmin.Location = new System.Drawing.Point(395, 206);
            this.labelMod_Tmin.Name = "labelMod_Tmin";
            this.labelMod_Tmin.Size = new System.Drawing.Size(105, 13);
            this.labelMod_Tmin.TabIndex = 25;
            this.labelMod_Tmin.Text = "Temperatura Mínima";
            // 
            // labelMod_Tmax
            // 
            this.labelMod_Tmax.AutoSize = true;
            this.labelMod_Tmax.Location = new System.Drawing.Point(394, 165);
            this.labelMod_Tmax.Name = "labelMod_Tmax";
            this.labelMod_Tmax.Size = new System.Drawing.Size(106, 13);
            this.labelMod_Tmax.TabIndex = 24;
            this.labelMod_Tmax.Text = "Temperatura Máxima";
            // 
            // labelMod_Evap
            // 
            this.labelMod_Evap.AutoSize = true;
            this.labelMod_Evap.Location = new System.Drawing.Point(432, 129);
            this.labelMod_Evap.Name = "labelMod_Evap";
            this.labelMod_Evap.Size = new System.Drawing.Size(67, 13);
            this.labelMod_Evap.TabIndex = 23;
            this.labelMod_Evap.Text = "Evaporación";
            // 
            // labelMod_Prec
            // 
            this.labelMod_Prec.AutoSize = true;
            this.labelMod_Prec.Location = new System.Drawing.Point(431, 95);
            this.labelMod_Prec.Name = "labelMod_Prec";
            this.labelMod_Prec.Size = new System.Drawing.Size(68, 13);
            this.labelMod_Prec.TabIndex = 22;
            this.labelMod_Prec.Text = "Precipitación";
            // 
            // monthCalendarMod_Date
            // 
            this.monthCalendarMod_Date.Location = new System.Drawing.Point(86, 189);
            this.monthCalendarMod_Date.Name = "monthCalendarMod_Date";
            this.monthCalendarMod_Date.TabIndex = 21;
            // 
            // textBoxMod_ID
            // 
            this.textBoxMod_ID.Location = new System.Drawing.Point(74, 61);
            this.textBoxMod_ID.Name = "textBoxMod_ID";
            this.textBoxMod_ID.Size = new System.Drawing.Size(131, 20);
            this.textBoxMod_ID.TabIndex = 20;
            // 
            // labelMod_ID
            // 
            this.labelMod_ID.AutoSize = true;
            this.labelMod_ID.Location = new System.Drawing.Point(50, 64);
            this.labelMod_ID.Name = "labelMod_ID";
            this.labelMod_ID.Size = new System.Drawing.Size(18, 13);
            this.labelMod_ID.TabIndex = 19;
            this.labelMod_ID.Text = "ID";
            // 
            // btnMod_Eliminar
            // 
            this.btnMod_Eliminar.Location = new System.Drawing.Point(397, 354);
            this.btnMod_Eliminar.Name = "btnMod_Eliminar";
            this.btnMod_Eliminar.Size = new System.Drawing.Size(125, 45);
            this.btnMod_Eliminar.TabIndex = 33;
            this.btnMod_Eliminar.Text = "ELIMINAR";
            this.btnMod_Eliminar.UseVisualStyleBackColor = true;
            // 
            // labelMod_MessageBusqueda
            // 
            this.labelMod_MessageBusqueda.AutoSize = true;
            this.labelMod_MessageBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMod_MessageBusqueda.Location = new System.Drawing.Point(99, 96);
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
            this.btnMod_Buscar.Location = new System.Drawing.Point(220, 58);
            this.btnMod_Buscar.Name = "btnMod_Buscar";
            this.btnMod_Buscar.Size = new System.Drawing.Size(126, 26);
            this.btnMod_Buscar.TabIndex = 35;
            this.btnMod_Buscar.Text = "BUSCAR";
            this.btnMod_Buscar.UseVisualStyleBackColor = false;
            // 
            // textBoxMod_Date
            // 
            this.textBoxMod_Date.Location = new System.Drawing.Point(159, 158);
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
            this.btnMod_Guardar.Location = new System.Drawing.Point(543, 354);
            this.btnMod_Guardar.Name = "btnMod_Guardar";
            this.btnMod_Guardar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMod_Guardar.Size = new System.Drawing.Size(168, 45);
            this.btnMod_Guardar.TabIndex = 31;
            this.btnMod_Guardar.Text = "   GUARDAR CAMBIOS";
            this.btnMod_Guardar.UseVisualStyleBackColor = false;
            // 
            // radioButtonMod_Nulo
            // 
            this.radioButtonMod_Nulo.AutoSize = true;
            this.radioButtonMod_Nulo.Location = new System.Drawing.Point(643, 130);
            this.radioButtonMod_Nulo.Name = "radioButtonMod_Nulo";
            this.radioButtonMod_Nulo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonMod_Nulo.TabIndex = 37;
            this.radioButtonMod_Nulo.TabStop = true;
            this.radioButtonMod_Nulo.Text = " NULO";
            this.radioButtonMod_Nulo.UseVisualStyleBackColor = true;
            // 
            // form_modBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.radioButtonMod_Nulo);
            this.Controls.Add(this.textBoxMod_Date);
            this.Controls.Add(this.btnMod_Buscar);
            this.Controls.Add(this.labelMod_MessageBusqueda);
            this.Controls.Add(this.btnMod_Eliminar);
            this.Controls.Add(this.labelMod_Message);
            this.Controls.Add(this.btnMod_Guardar);
            this.Controls.Add(this.textBoxMod_Preci);
            this.Controls.Add(this.textBoxMod_Evap);
            this.Controls.Add(this.labelMod_Date);
            this.Controls.Add(this.textBoxMod_Tmin);
            this.Controls.Add(this.textBoxMod_Tmax);
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Preci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Evap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Tmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMod_Tmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMod_Message;
        private System.Windows.Forms.Button btnMod_Guardar;
        private System.Windows.Forms.NumericUpDown textBoxMod_Preci;
        private System.Windows.Forms.NumericUpDown textBoxMod_Evap;
        private System.Windows.Forms.Label labelMod_Date;
        private System.Windows.Forms.NumericUpDown textBoxMod_Tmin;
        private System.Windows.Forms.NumericUpDown textBoxMod_Tmax;
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
        private System.Windows.Forms.RadioButton radioButtonMod_Nulo;
    }
}