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
    public partial class Form1 : Form
    {
        Random r = new Random();
        public int c = 0;
        public Cell[,] buttons;
        public int bombs;
        public int h;
        public int w;
        int time = 0;
        int counter = 0;

        Bitmap blank = new Bitmap(Properties.Resources.blank);
        Bitmap ablank = new Bitmap(Properties.Resources.after_blank2);
        Bitmap flag = new Bitmap(Properties.Resources.flag);
        Bitmap p1 = new Bitmap(Properties.Resources._1);
        Bitmap p2 = new Bitmap(Properties.Resources._2);
        Bitmap p3 = new Bitmap(Properties.Resources._3);
        Bitmap p4 = new Bitmap(Properties.Resources._4);
        Bitmap p5 = new Bitmap(Properties.Resources._5);
        Bitmap p6 = new Bitmap(Properties.Resources._6);
        Bitmap p7 = new Bitmap(Properties.Resources._7);
        Bitmap p8 = new Bitmap(Properties.Resources._8);
        Bitmap bomb = new Bitmap(Properties.Resources.bomb_after_click);

        public Form1()
        {
            SetDifficulty diff = new SetDifficulty();
            diff.ShowDialog();
            InitializeComponent();
            w = diff.width;
            h = diff.height;
            buttons = new Cell[h,w];
            this.Size = new Size(w * 49 + 10  , h * 49 + 10);
            bombs = diff.dificulty;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createButtons(buttons);
            activeBoard();
            findNeighbours();
            label2.Text = bombs.ToString();
        }
        public void createButtons(Cell[,] buttons)
        {
            int rowNumber = buttons.GetUpperBound(0) + 1;
            int columnNumber = buttons.GetUpperBound(buttons.Rank - 1) + 1;

            for (int i = 0; i < rowNumber; i++)
                for (int j = 0; j < columnNumber; j++)
                {
                    buttons[i, j] = new Cell(i, j);
                    buttons[i, j].Location = new Point(j * 40, 50 + (i * 40));
                    buttons[i, j].MouseDown += new MouseEventHandler(button_MouseClick);
                    buttons[i, j].Image = blank;
                    Controls.Add(buttons[i, j]);
                }
        }
        public void activeBoard()
        {
            Cell[] liveCells = new Cell[100];
            int s = 0;
            while (s < bombs)
            {
                for (int i = 0; i < buttons.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < buttons.GetUpperBound(1); j++)
                    {
                        int rnext = r.Next() % (buttons.GetLength(0) * buttons.GetLength(1));
                        if (rnext < bombs && buttons[i, j].getLive()==false && buttons[i,j].getNeighbours()!=9)
                        {
                            buttons[i, j].setLive(true);
                            buttons[i, j].setNeighbours(9);
                            liveCells[c] = buttons[i, j];
                            c++;
                            s++;
                        }
                        if (s == bombs)
                            break;
                    }
                    if (s == bombs)
                        break;
                }
            }
        }
        public void findNeighbours()
        {
            int rowLimit = buttons.GetLength(0);
            int columnLimit = buttons.GetLength(1);

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].getNeighbours() < 9)
                    {
                        int neighbours = 0;

                        for (int x = Math.Max(0, i - 1); x <= Math.Min(i + 1, rowLimit - 1); x++)
                        {
                            for (int y = Math.Max(0, j - 1); y <= Math.Min(j + 1, columnLimit - 1); y++)
                            {
                                if (x != i || y != j)
                                {
                                    bool test = buttons[x, y].getLive();
                                    if (test == true)
                                    {
                                        neighbours++;
                                    }
                                }
                            }
                        }
                        buttons[i, j].setNeighbours(neighbours);
                    }
                }
            }
        }
        private void revealNeighbours(int row, int column)
            {
                if (row < 0 || row >= h || column < 0 || column >= w)
                {
                    return;
                }

                if (buttons[row, column].getNeighbours() < 9 && !buttons[row, column].getVisited())
                {
                    if (buttons[row, column].getNeighbours() == 0)
                    {
                        buttons[row, column].setVisited(true);
                        counter++;
                        buttons[row, column].Image = ablank;
                        revealNeighbours(row + 1, column);
                        revealNeighbours(row - 1, column);
                        revealNeighbours(row, column + 1);
                        revealNeighbours(row, column - 1);
                        revealNeighbours(row + 1, column + 1);
                        revealNeighbours(row - 1, column + 1);
                        revealNeighbours(row + 1, column - 1);
                        revealNeighbours(row - 1, column - 1);
                    }
                    if (buttons[row, column].getNeighbours() > 0)
                    {
                        buttons[row, column].setVisited(true);
                        counter++;
                        if (buttons[row, column].getNeighbours() == 1)
                        {
                            buttons[row, column].Image = p1;
                        }
                        if (buttons[row, column].getNeighbours() == 2)
                        {
                            buttons[row, column].Image = p2;
                        }
                        if (buttons[row, column].getNeighbours() == 3)
                        {
                            buttons[row, column].Image = p3;
                        }
                        if (buttons[row, column].getNeighbours() == 4)
                        {
                            buttons[row, column].Image = p4;
                        }
                        if (buttons[row, column].getNeighbours() == 5)
                        {
                            buttons[row, column].Image = p5;
                        }
                        if (buttons[row, column].getNeighbours() == 6)
                        {
                            buttons[row, column].Image = p6;
                        }
                        if (buttons[row, column].getNeighbours() == 7)
                        {
                            buttons[row, column].Image = p7;
                        }
                        if (buttons[row, column].getNeighbours() == 8)
                        {
                            buttons[row, column].Image = p8;
                        }
                    }
                }
                else if (buttons[row, column].getNeighbours() == 9)
                {
                    for (int i = 0; i < buttons.GetLength(0); i++)
                    {
                        for (int j = 0; j < buttons.GetLength(1); j++)
                        {
                            if (buttons[i, j].getLive())
                            {
                                buttons[i, j].Image = bomb;
                            }
                        }
                    }
                    DialogResult dialog = MessageBox.Show("You lost:(( Try again later");
                    if (dialog == DialogResult.OK)
                    {
                        timer1.Stop();
                        Application.Exit();
                    }
                }

                if (counter + c == w * h)
                {
                    DialogResult dialog = MessageBox.Show("You won!!! Your time was " + time + " seconds.");
                    if (dialog == DialogResult.OK)
                    {
                        timer1.Stop();
                        Application.Exit();
                    }
                }

            }
        
        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            Cell triggered = (Cell)sender;
            
            if (e.Button == MouseButtons.Right)
            {
                if (buttons[triggered.getRow(), triggered.getColumn()].getFlag() == false && (buttons[triggered.getRow(), triggered.getColumn()].getVisited() == false))
                {
                    buttons[triggered.getRow(), triggered.getColumn()].setFlag(true);
                    buttons[triggered.getRow(), triggered.getColumn()].Image = flag;
                    bombs--;
                    label2.Text = bombs.ToString();
                }
                else if(buttons[triggered.getRow(), triggered.getColumn()].getVisited() == false && buttons[triggered.getRow(), triggered.getColumn()].getFlag())
                {
                    buttons[triggered.getRow(), triggered.getColumn()].setFlag(false);
                    buttons[triggered.getRow(), triggered.getColumn()].Image = blank;
                    bombs++;
                    label2.Text = bombs.ToString();
                }
            }
            else if (buttons[triggered.getRow(), triggered.getColumn()].getFlag() == false)
            {

                revealNeighbours(triggered.getRow(), triggered.getColumn());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time.ToString();
            time++;
        } 

    }
 }
