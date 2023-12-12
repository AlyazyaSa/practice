using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet1week3
{
    internal class world
    {
        private string[,] Grid;
        private int Rows;
        private int Columns;

        public world(string[,] grid)
        {
        Grid = grid;
            Rows = grid.GetLength(0);
            Columns = grid.GetLength(1);
        }
        public void Drew()
        {

        }
    }
}
