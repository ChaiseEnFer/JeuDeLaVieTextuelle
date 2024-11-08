
namespace JeuDeLaVieTxt
{
    public class Game
    {
        private int n;
        private int iter;
        public Grid grid;
        List<Coords> AliveCellsCoords;
        EventHandler display;
        public Game(int nbCells,int nbIterations, bool cool)
        {
            n = nbCells;
            iter = nbIterations;
            this.AliveCellsCoords = new List<Coords>() { new Coords(1, 2), new Coords(1, 3), new Coords(1, 4) };
            this.grid = new Grid(n, AliveCellsCoords);
            if( cool )
            {
                display += grid.DisplayCoolGrid;
            }
            else
            {
                display += grid.DisplayGrid;
            }
        }

        public void RunGameConsole()
        {
            display.Invoke(new object(), EventArgs.Empty);
            for (int i = 0; i != iter; i++)
            {
                display.Invoke(new object(), EventArgs.Empty);
                grid.UpdateGrid();
                Thread.Sleep(1000);
            }
        }
    }
}
