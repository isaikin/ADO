using GenerationText.BLL;
using System;
using System.Windows.Forms;
using GenerationText.Entity;

namespace GeneratorPl
{
    public partial class Form1 : Form
    {
        
        private GenerationLogic GrahpLogic = new GenerationLogic();

        private int n = 10;

        public Form1()
        {
            
            InitializeComponent();
            textBox1.Visible = false;
            button1.Visible = false;
        }

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Is not pozitive");//исправить
                }

                n = value;
            }
        }

        private void сВыборомКолчичестваСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = GrahpLogic.GenerateRandom(N);
            }
            catch
            {   
            }

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
            try
            {
                label1.Text = GrahpLogic.GenerateRandom();
            }
            catch
            {
            }
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

        private void задатьКоличесвоСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible =true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Отрицательное количество слов");
                n = 10;
            }
            else
            {
                n = int.Parse(textBox1.Text);

                textBox1.Visible = false;
                button1.Visible = false;
            }
        }
    }
}
