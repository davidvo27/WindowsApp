﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greeting", "Hello!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateTimeSelection = this.dateTimePicker1;
            //MessageBox.Show("Setting Date & Time", "Please select your desire date and time");
            MessageBox.Show(dateTimeSelection.ToString(), "You Picked Data & Time");  ;
        }
    }
}
