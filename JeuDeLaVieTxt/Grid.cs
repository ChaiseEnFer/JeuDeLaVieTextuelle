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
        public int n {get {return _n;} set { _n = value; } }
        Cell[,] TabCells;

        public Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            this.n = nbCells;
            TabCells = new Cell[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (AliveCellsCoords.Contains(new Coords(i,j)) )
                    {
                        TabCells[i,j] = new Cell(true);
                    }
                    else
                    {
                        TabCells[i,j] = new Cell(false);
                    }
                }
            }
        }

        public int getNbALiveNeighboor(int i, int j)
        {
            
        }
    }
}
