
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
            this.monthCalendarAltas_Date = new System.Windows.Forms.MonthCalendar();
            this.labelAltas_Preci = new System.Windows.Forms.Label();
            this.labelAltas_Evap = new System.Windows.Forms.Label();
            this.labelAltas_Tmax = new System.Windows.Forms.Label();
            this.labelAltas_Tmin = new System.Windows.Forms.Label();
            this.textBoxAltas_Tmax = new System.Windows.Forms.NumericUpDown();
            this.textBoxAltas_Tmin = new System.Windows.Forms.NumericUpDown();
            this.labelAltas_Date = new System.Windows.Forms.Label();
            this.textBoxAltas_Evap = new System.Windows.Forms.NumericUpDown();
            this.textBoxAltas_Preci = new System.Windows.Forms.NumericUpDown();
            this.btnAltas_Agregar = new System.Windows.Forms.Button();
            this.labelAltas_Message = new System.Windows.Forms.Label();
            this.textBoxAltas_Date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Tmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Tmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Evap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Preci)).BeginInit();
            this.SuspendLayout();
            // 
            // layerAltas_Id
            // 
            this.layerAltas_Id.AutoSize = true;
            this.layerAltas_Id.Location = new System.Drawing.Point(161, 86);
            this.layerAltas_Id.Name = "layerAltas_Id";
            this.layerAltas_Id.Size = new System.Drawing.Size(18, 13);
            this.layerAltas_Id.TabIndex = 0;
            this.layerAltas_Id.Text = "ID";
            // 
            // textBoxAltas_ID
            // 
            this.textBoxAltas_ID.Location = new System.Drawing.Point(195, 83);
            this.textBoxAltas_ID.Name = "textBoxAltas_ID";
            this.textBoxAltas_ID.Size = new System.Drawing.Size(131, 20);
            this.textBoxAltas_ID.TabIndex = 1;
            // 
            // monthCalendarAltas_Date
            // 
            this.monthCalendarAltas_Date.Location = new System.Drawing.Point(78, 191);
            this.monthCalendarAltas_Date.Name = "monthCalendarAltas_Date";
            this.monthCalendarAltas_Date.TabIndex = 4;
            // 
            // labelAltas_Preci
            // 
            this.labelAltas_Preci.AutoSize = true;
            this.labelAltas_Preci.Location = new System.Drawing.Point(379, 83);
            this.labelAltas_Preci.Name = "labelAltas_Preci";
            this.labelAltas_Preci.Size = new System.Drawing.Size(68, 13);
            this.labelAltas_Preci.TabIndex = 7;
            this.labelAltas_Preci.Text = "Precipitación";
            // 
            // labelAltas_Evap
            // 
            this.labelAltas_Evap.AutoSize = true;
            this.labelAltas_Evap.Location = new System.Drawing.Point(380, 143);
            this.labelAltas_Evap.Name = "labelAltas_Evap";
            this.labelAltas_Evap.Size = new System.Drawing.Size(67, 13);
            this.labelAltas_Evap.TabIndex = 8;
            this.labelAltas_Evap.Text = "Evaporación";
            // 
            // labelAltas_Tmax
            // 
            this.labelAltas_Tmax.AutoSize = true;
            this.labelAltas_Tmax.Location = new System.Drawing.Point(380, 193);
            this.labelAltas_Tmax.Name = "labelAltas_Tmax";
            this.labelAltas_Tmax.Size = new System.Drawing.Size(106, 13);
            this.labelAltas_Tmax.TabIndex = 9;
            this.labelAltas_Tmax.Text = "Temperatura Máxima";
            // 
            // labelAltas_Tmin
            // 
            this.labelAltas_Tmin.AutoSize = true;
            this.labelAltas_Tmin.Location = new System.Drawing.Point(380, 247);
            this.labelAltas_Tmin.Name = "labelAltas_Tmin";
            this.labelAltas_Tmin.Size = new System.Drawing.Size(105, 13);
            this.labelAltas_Tmin.TabIndex = 10;
            this.labelAltas_Tmin.Text = "Temperatura Mínima";
            // 
            // textBoxAltas_Tmax
            // 
            this.textBoxAltas_Tmax.Location = new System.Drawing.Point(501, 191);
            this.textBoxAltas_Tmax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxAltas_Tmax.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxAltas_Tmax.Name = "textBoxAltas_Tmax";
            this.textBoxAltas_Tmax.Size = new System.Drawing.Size(160, 20);
            this.textBoxAltas_Tmax.TabIndex = 11;
            // 
            // textBoxAltas_Tmin
            // 
            this.textBoxAltas_Tmin.Location = new System.Drawing.Point(501, 245);
            this.textBoxAltas_Tmin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxAltas_Tmin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxAltas_Tmin.Name = "textBoxAltas_Tmin";
            this.textBoxAltas_Tmin.Size = new System.Drawing.Size(160, 20);
            this.textBoxAltas_Tmin.TabIndex = 12;
            // 
            // labelAltas_Date
            // 
            this.labelAltas_Date.AutoSize = true;
            this.labelAltas_Date.Location = new System.Drawing.Point(183, 140);
            this.labelAltas_Date.Name = "labelAltas_Date";
            this.labelAltas_Date.Size = new System.Drawing.Size(37, 13);
            this.labelAltas_Date.TabIndex = 13;
            this.labelAltas_Date.Text = "Fecha";
            // 
            // textBoxAltas_Evap
            // 
            this.textBoxAltas_Evap.Location = new System.Drawing.Point(501, 140);
            this.textBoxAltas_Evap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxAltas_Evap.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxAltas_Evap.Name = "textBoxAltas_Evap";
            this.textBoxAltas_Evap.Size = new System.Drawing.Size(160, 20);
            this.textBoxAltas_Evap.TabIndex = 15;
            // 
            // textBoxAltas_Preci
            // 
            this.textBoxAltas_Preci.Location = new System.Drawing.Point(501, 83);
            this.textBoxAltas_Preci.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxAltas_Preci.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.textBoxAltas_Preci.Name = "textBoxAltas_Preci";
            this.textBoxAltas_Preci.Size = new System.Drawing.Size(160, 20);
            this.textBoxAltas_Preci.TabIndex = 16;
            // 
            // btnAltas_Agregar
            // 
            this.btnAltas_Agregar.Location = new System.Drawing.Point(521, 366);
            this.btnAltas_Agregar.Name = "btnAltas_Agregar";
            this.btnAltas_Agregar.Size = new System.Drawing.Size(188, 45);
            this.btnAltas_Agregar.TabIndex = 17;
            this.btnAltas_Agregar.Text = "AGREGAR";
            this.btnAltas_Agregar.UseVisualStyleBackColor = true;
            // 
            // labelAltas_Message
            // 
            this.labelAltas_Message.AutoSize = true;
            this.labelAltas_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltas_Message.Location = new System.Drawing.Point(436, 309);
            this.labelAltas_Message.Name = "labelAltas_Message";
            this.labelAltas_Message.Size = new System.Drawing.Size(189, 16);
            this.labelAltas_Message.TabIndex = 18;
            this.labelAltas_Message.Text = "Mensaje de Error invisible";
            this.labelAltas_Message.Visible = false;
            // 
            // textBoxAltas_Date
            // 
            this.textBoxAltas_Date.Location = new System.Drawing.Point(152, 162);
            this.textBoxAltas_Date.Name = "textBoxAltas_Date";
            this.textBoxAltas_Date.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltas_Date.TabIndex = 19;
            // 
            // form_Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.textBoxAltas_Date);
            this.Controls.Add(this.labelAltas_Message);
            this.Controls.Add(this.btnAltas_Agregar);
            this.Controls.Add(this.textBoxAltas_Preci);
            this.Controls.Add(this.textBoxAltas_Evap);
            this.Controls.Add(this.labelAltas_Date);
            this.Controls.Add(this.textBoxAltas_Tmin);
            this.Controls.Add(this.textBoxAltas_Tmax);
            this.Controls.Add(this.labelAltas_Tmin);
            this.Controls.Add(this.labelAltas_Tmax);
            this.Controls.Add(this.labelAltas_Evap);
            this.Controls.Add(this.labelAltas_Preci);
            this.Controls.Add(this.monthCalendarAltas_Date);
            this.Controls.Add(this.textBoxAltas_ID);
            this.Controls.Add(this.layerAltas_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Altas";
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.form_Altas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Tmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Tmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Evap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAltas_Preci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label layerAltas_Id;
        private System.Windows.Forms.TextBox textBoxAltas_ID;
        private System.Windows.Forms.MonthCalendar monthCalendarAltas_Date;
        private System.Windows.Forms.Label labelAltas_Preci;
        private System.Windows.Forms.Label labelAltas_Evap;
        private System.Windows.Forms.Label labelAltas_Tmax;
        private System.Windows.Forms.Label labelAltas_Tmin;
        private System.Windows.Forms.NumericUpDown textBoxAltas_Tmax;
        private System.Windows.Forms.NumericUpDown textBoxAltas_Tmin;
        private System.Windows.Forms.Label labelAltas_Date;
        private System.Windows.Forms.NumericUpDown textBoxAltas_Evap;
        private System.Windows.Forms.NumericUpDown textBoxAltas_Preci;
        private System.Windows.Forms.Button btnAltas_Agregar;
        private System.Windows.Forms.Label labelAltas_Message;
        private System.Windows.Forms.TextBox textBoxAltas_Date;
    }
}