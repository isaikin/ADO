using GenerationText.BLL;
using System;
using System.Windows.Forms;
using GenerationText.Entity;

namespace GeneratorPl
{
    public partial class Form1 : Form
    {
        private GenerationLogic GrahpLogic = new GenerationLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void сВыборомКолчичестваСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = GrahpLogic.GenerateRandom("говорил");
        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GrahpLogic.AddFile(openFileDialog1.FileName);
            }
        }

        private void случайнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void генерацияАлгоримомМарковаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkovChain temp = new MarkovChain();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = temp.GenerateText(openFileDialog1.FileName);
            }
             
        }

        private void ввестиТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}