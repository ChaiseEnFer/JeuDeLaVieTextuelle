using System;

namespace JeuDeLaVieTxt
{
    static class Program
    {
        static void Main()
        {
            Game game = new Game(4, 10);
            game.RunGameConsole();
        }
    }
}