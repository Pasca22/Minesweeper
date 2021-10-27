using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Cell : Button
    {
        int row = -1;
        int column = -1;
        bool visited = false;
        bool live = false;
        int neighbours = 0;
        bool flag = false;

        public Cell(int r, int c)
        {
            row = r;
            column = c;
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(40, 40);
            }
        }
        
        //get

        public bool getFlag()
        {
            return flag;
        }
        public bool getVisited()
        {
            return visited;
        }

        public bool getLive()
        {
            return live;
        }
 
        public int getNeighbours()
        {
            return neighbours;
        }

        public int getColumn()
        {
            return column;
        }

        public int getRow()
        {
            return row;
        }

        ///set

        public void setFlag(bool f)
        {
            flag = f;
        }
        public void setVisited(bool v)
        {
            visited = v;
        }
        public void setLive(bool l)
        {
            live = l;
        }
        public void setNeighbours(int n)
        {
            neighbours = n;
        }
        public void setRow(int r)
        {
            row = r;
        }
        public void setColumn(int c)
        {
            column = c;
        }

    }
}
