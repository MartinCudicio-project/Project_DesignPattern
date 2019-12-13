using System;
using System.Collections.Generic;

namespace Monopoly_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello World MArtin !!!");
=======
            MainGame();
            Console.ReadKey();
>>>>>>> Stashed changes
        }

        static void MainGame()
        {
            Game main = Game.Instance;
            Console.WriteLine(main.Board[12].Name);
            main.create_player();
        }


    }
}
