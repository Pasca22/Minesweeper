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
            }
            if(medium.Checked)
            { 
                dificulty = 15;
            }
            if(hard.Checked)
            {
                dificulty = 20;
            }
            this.Close();
        }
    }
}
