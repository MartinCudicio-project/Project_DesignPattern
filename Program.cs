using System;
using System.Collections.Generic;

namespace Monopoly_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World MArtin !!!");
            Menu.Selection_avec_Consigne(null);
            //MainGame();
            Console.ReadKey();

        }

        static void MainGame()
        {
            Game main = Game.Instance;
            Console.WriteLine(main.Board[12].Name);
            main.create_player();
        }


    }
}
