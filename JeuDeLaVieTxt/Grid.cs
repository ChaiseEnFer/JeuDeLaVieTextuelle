using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVieTxt
{
    public class Grid
    {
        private int _n;
        public int n { get { return _n; } set { _n = value; } }
        Cell[,] TabCells;

        public Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            this.n = nbCells;
            TabCells = new Cell[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (AliveCellsCoords.Contains(new Coords(i, j)))
                    {
                        TabCells[i, j] = new Cell(true);
                    }
                    else
                    {
                        TabCells[i, j] = new Cell(false);
                    }
                }
            }
        }

        public int getNbALiveNeighboor(int i, int j)
        {
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int aliveCount = 0;
            for (int k = 0; k < 8; k++)
            {
                int ni = i + dx[k];
                int nj = j + dy[k];
            }


            return aliveCount;
        }
    }
}
