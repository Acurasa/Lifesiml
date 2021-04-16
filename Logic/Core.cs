using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesiml.Logic
{
    class Core
    {
        private bool[,] space; private readonly int row, col;
        Random random = new Random();
        public ushort Gen { get; private set; }
        public Core(int row,int col,int intensivity)
        {
            this.row = row;
            this.col = col;
            space = new bool[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    space[i, j] = random.Next(intensivity) == 0;
                }
            }
        }


        public void GenerateNew()
        {
            var newArr = new bool[col, row];
            
            for (int i = 1; i < col; i++)
            {

                for (int j = 1; j < row; j++)
                {
                    var CellNumber = GetCells(i, j);
                    if (!space[i, j] && CellNumber == 3)
                        newArr[i, j] = true;
                    else if (space[i, j] && (CellNumber < 2 || CellNumber > 3))
                        newArr[i, j] = false;
                    else
                        newArr[i, j] = space[i, j];

                 
                }
            }
            //
            //
            space = newArr;
            Gen++;
        }

        public bool [,] GetCurrentAge()
        {
            var result = new bool[col, row];
            for (int x = 0; x < col; x++)
            {
                for (int y = 0; y < row; y++)
                {
                    result[x, y] = space[x, y];
                }
            }
            return result;
        }

        private bool isOnScreen(int x, int y)
        {
            return x >= 0 && y >= 0 && x < col && y < row;
        }
        private void Update(int x, int y, bool status)
        {
            if (isOnScreen(x, y)) 
                space[x, y] = status;
        }
        public void AddCell(int x,int y)
        {
            Update(x, y, status: true);
        }
        public void RemoveCell(int x, int y)
        {
            Update(x, y, status: false);
        }


        private int GetCells(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var rows = (y + j + row) % row;
                    var cols = (x + i + col) % col;
                   
                    var check = cols == x && rows == y;
                    // space[i, j] = space[cols, rows];
                    var Alive = space[cols, rows];
                    if (Alive && !check)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
