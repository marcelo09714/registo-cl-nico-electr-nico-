﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terapeutica
{
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();

            labelData.BackColor = Color.Transparent;
            labelHora.BackColor = Color.Transparent;
            labelData.Text = DateTime.Now.ToLongDateString();

            //conta o tempo
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registo registo = new Registo();
            this.Hide();
            registo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            this.Hide();
            consultas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utentes utentes = new Utentes();
            this.Hide();
            utentes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login utentes = new Login();
            this.Hide();
            utentes.ShowDialog();
        }
    }
}
