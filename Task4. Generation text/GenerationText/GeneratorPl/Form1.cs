﻿using GenerationText.BLL;
using System;
using System.Windows.Forms;

namespace GeneratorPl
{
    public partial class Form1 : Form
    {
        private GenerationLogic logic = new GenerationLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void сВыборомКолчичестваСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Text = logic.GenerateRandom("говорил");
        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logic.AddFile(openFileDialog1.FileName);
            }
        }

        private void случайнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}