using System;

namespace JeuDeLaVieTxt
{
    static class Program
    {
        static int rdm = new Random().Next(6, 12);
        static int rdmSecond = new Random().Next(10, 22);
        static void Main()
        {
            Game game = new Game(rdm, rdmSecond,true);
            game.RunGameConsole();
        }
    }
}