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

                if(ni >= 0 && ni <n && nj >= 0 && nj < n)
                {
                    if (TabCells[ni, nj].isAlive)
                    {
                        aliveCount++;
                    }
                }
            }
            return aliveCount;
        }

        public List<Coords> getCoordsCellsAlive()
        {

            List<Coords> coords = new List<Coords>();
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (TabCells[k, j].isAlive)
                    {
                        coords.Add(new Coords(k, j));
                    }
                }
                
            }
            return coords;
        }

        public void DisplayGrid()
        {
            string ToDisplay = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ToDisplay += "+---";
                }
                ToDisplay += "+\n";

                for (int j = 0; j < n; j++)
                {
                    if (TabCells[i, j].isAlive)
                    {
                        ToDisplay += "| X ";
                    }
                    else
                    {
                        ToDisplay += "|   ";
                    }
                }
                ToDisplay += "|\n";
            }
            for (int j = 0; j < n; j++)
            {
                ToDisplay += "+---";
            }
            ToDisplay += "+\n";

            Console.WriteLine(ToDisplay);
        }

    }
}
