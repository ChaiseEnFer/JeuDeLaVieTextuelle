
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

        public int getNbAliveNeighboor(int i, int j)
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

        public void DisplayGrid(object? sender, EventArgs e)
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

        public void DisplayCoolGrid(object? sender, EventArgs e)
        {
            for (var y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (TabCells[y, x].isAlive)
                    {
                        Console.Write("██");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
        }

        public void UpdateGrid()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int aliveNeighbors = getNbAliveNeighboor(i, j);
                    if (TabCells[i, j].isAlive)
                    {
                        // Une cellule vivante reste en vie si elle a 2 ou 3 voisins vivants
                        TabCells[i, j].nextState = (aliveNeighbors == 2 || aliveNeighbors == 3);

                    }
                    else
                    {
                        // Une cellule morte devient vivante si elle a exactement 3 voisins vivants
                        TabCells[i, j].nextState = (aliveNeighbors == 3);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TabCells[i, j].isAlive = TabCells[i, j].nextState;
                }
            }
        }
    }
}


//dans mon constructeur de game je mets un bool qui dis coolgrid true soit false après, je fais un delegate event et je bind coolgrid ou dsgrid