using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class SetDifficulty : Form
    {
        public int dificulty = 10;
        public int width;
        public int height;
        public SetDifficulty()
        {
            InitializeComponent();
        }

        private void SetDifficulty_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if(easy.Checked)
            {
                dificulty = 10;
                width = 10;
                height = 10;
            }
            if(medium.Checked)
            { 
                dificulty = 40;
                width = 15;
                height = 15;
            }
            if(hard.Checked)
            {
                dificulty = 70;
                width = 19;
                height = 19;
            }
            else if(!easy.Checked && !medium.Checked && !hard.Checked)
            {
                dificulty = int.Parse(textBox3.Text);
                width = int.Parse(textBox1.Text);
                height = int.Parse(textBox2.Text);

            }
            this.Close();
        }
    }
}
