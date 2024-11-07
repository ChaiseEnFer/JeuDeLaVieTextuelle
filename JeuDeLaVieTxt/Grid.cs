using System;
using System.Collections.Generic;
using System.Linq;
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
                    
                }
            }
        }
    }
}
