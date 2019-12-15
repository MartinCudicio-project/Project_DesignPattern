using System;
using System.Collections.Generic;

namespace Monopoly_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World MArtin !!!");


            Initialisation();

            Menu.Selection_avec_Consigne(null);
            //MainGame();

            Console.ReadKey();

        }

        static void Initialisation()
        {
            ///Initialisation
            Game main = Game.Instance;
            main.create_player();
            main.First_player = chooseFirstPlayer(main.Player_list);

            Random rand = new Random();                    // Sinon on obtient toujours les mêmes nombres (si on cree un nouveau random a chaque fois)
            DiceInvoker diceinvoker = new DiceInvoker();   // Le invoker pour les lancées de dées, pour le command pattern
            int number_player_turn = main.First_player;
            bool win = false;
            int turn_number = 1;
            while(win != true)
            {

                for(int i = number_player_turn; i < main.Player_list.Length+main.First_player; i ++)
                {
                    if(i > main.Player_list.Length)
                    {
                        number_player_turn -= main.Player_list.Length;
                    }
                    ///Debut du tour
                    Console.WriteLine("Au tour de " + main.Player_list[number_player_turn].Pseudo);
                    Command command = new Dice(main.Player_list[number_player_turn], rand);
                    
                    diceinvoker.LaunchDice(command);
                    diceinvoker.ExecuteCommand();
                    Console.WriteLine(main.Player_list[number_player_turn].Index); 


                }



                number_player_turn++;
                turn_number++;
                if(turn_number == 4)
                {
                    win = true;
                }
                
            }
            }

        static int chooseFirstPlayer(Player[] List_Player)
        {
            Console.WriteLine("Lancer les dées pour choisir le joueur qui commence en premier : ");
            Random rand = new Random();                    // Sinon on obtient toujours les mêmes nombres (si on crée un nouveau random à chaque fois
            Command command;
            DiceInvoker diceinvoker = new DiceInvoker();
            int first_player = 0;
            for (int i = 0; i < List_Player.Length; i++)  // We use our command launchdice, we don't forget to reset plaer's index on the board 
            {
                command = new Dice(List_Player[i], rand);
                diceinvoker.LaunchDice(command);
                Console.WriteLine("\nJoueur " + (i+1));
                diceinvoker.ExecuteCommand();
                if (i > 0 && List_Player[i].Index > List_Player[i - 1].Index)
                {
                    first_player = i;
                }
            }
            //In case of two person have same highest value we have to redo with less player
            bool redo = false;
            Player[] potentialredo = new Player[List_Player.Length];
            int index = 0;
            potentialredo[index] = List_Player[first_player];
            index++;
            for (int i = 0; i < List_Player.Length; i++)
            {
                if (List_Player[i].Index == List_Player[first_player].Index && first_player != i)
                {
                    redo = true;
                    potentialredo[index] = List_Player[i];
                    index++;
                }
            }
            if (redo == false)
            {
                Console.WriteLine("\nPremier joueur a jouer : Joueur "
                    + (first_player+1));
                return first_player;
            }
            else
            {
                Console.WriteLine("\n"+index + " joueurs ont eu le même meilleur lancer de " + ((potentialredo[0].Index) + 1));
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine("Joueur " + (i+1));
                }
                Console.WriteLine();         
                return chooseFirstPlayer(potentialredo);
            }        
        }


    }
}
