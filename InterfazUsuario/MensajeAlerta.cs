﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InterfazUsuario
{
    public partial class MensajeAlerta : Form
    {
        public MensajeAlerta()
        {
            InitializeComponent();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAlert_Acept_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}