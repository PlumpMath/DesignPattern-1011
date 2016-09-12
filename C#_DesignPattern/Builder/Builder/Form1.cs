﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Draw(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Yellow);

            PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            PersonDirector pdthin = new PersonDirector(ptb);
            pdthin.CreatePerson();

            PersonFatBuilder pfb = new PersonFatBuilder(pictureBox2.CreateGraphics(), p);
            PersonDirector pdFat = new PersonDirector(pfb);
            pdFat.CreatePerson();
        }
    }
}
