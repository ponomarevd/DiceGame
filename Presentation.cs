﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubic
{
    
    public partial class Presentation : Form
    {
        StartMenu startMenu = new StartMenu();
        public Presentation()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.Context.MainForm = startMenu;
            startMenu.Show();
            Close();
        }
    }
}
