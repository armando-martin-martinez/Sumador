﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumador
{
    public unsafe partial class Form1 : Form
    {
        int numero1;
        int numero2;
        int* sumatotal;
        public unsafe Form1(int a, int b, int & sumaab)
        {

            InitializeComponent();
            
            numero1 = a;
            numero2=b;
            sumatotal = &sumaab;
        }

        private int Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            *sumatotal = numero1 + numero2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = numero1.ToString();
            this.label2.Text = numero2.ToString();
            sumatotal = numero1 + numero2;
            this.label3.Text = sumatotal.ToString();
        }
    }
}
