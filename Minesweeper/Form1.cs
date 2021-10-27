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
        public int size;
        int time = 0;
        int counter = 0;

        Bitmap blank = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\blank.png");
        Bitmap ablank = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\after blank.png");
        Bitmap flag = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\flag.png");
        Bitmap p1 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\1.png");
        Bitmap p2 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\2.png");
        Bitmap p3 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\3.png");
        Bitmap p4 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\4.png");
        Bitmap p5 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\5.png");
        Bitmap p6 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\6.png");
        Bitmap p7 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\7.png");
        Bitmap p8 = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\8.png");
        Bitmap bomb = new Bitmap(@"D:\proiecte VS\minesweeper\Minesweeper\Resources\bomb after click.png");

        public Form1()
        {
            SetDifficulty diff = new SetDifficulty();
            diff.ShowDialog();
            InitializeComponent();
            buttons = new Cell[diff.dificulty, diff.dificulty];
            this.Size = new Size((buttons.GetUpperBound(0) * +1) * 47 , (buttons.GetUpperBound(buttons.Rank - 1) + 1) * 49 + 2);
            size = diff.dificulty;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createButtons(buttons);
            activeBoard();
            findNeighbours();
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
            int ss=0;
            if (size == 10)
                ss = 10;
            if (size == 15)
                ss = 30;
            if (size == 20)
                ss = 50;
            while (s < ss)
            {
                for (int i = 0; i < buttons.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < buttons.GetUpperBound(1); j++)
                    {
                        int rnext = r.Next() % (buttons.GetLength(0) * buttons.GetLength(1));
                        if (rnext < size && buttons[i, j].getLive()==false && buttons[i,j].getNeighbours()!=9)
                        {
                            buttons[i, j].setLive(true);
                            buttons[i, j].setNeighbours(9);
                            liveCells[c] = buttons[i, j];
                            c++;
                            s++;
                        }
                        if (s == ss)
                            break;
                    }
                    if (s == ss)
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
                if (row < 0 || row >= size || column < 0 || column >= size)
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
                    DialogResult dialog = MessageBox.Show("You lost. Try again later");
                    if (dialog == DialogResult.OK)
                    {
                        timer1.Stop();
                        Application.Exit();
                    }
                }

                if (counter + c == size * size)
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
                    if (buttons[triggered.getRow(), triggered.getColumn()].getFlag() == false)
                    {
                        buttons[triggered.getRow(), triggered.getColumn()].setFlag(true);
                        buttons[triggered.getRow(), triggered.getColumn()].Image = flag;
                    }
                    else
                    {
                        buttons[triggered.getRow(), triggered.getColumn()].setFlag(false);
                        buttons[triggered.getRow(), triggered.getColumn()].Image = blank;
                    }
                }
                else
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
