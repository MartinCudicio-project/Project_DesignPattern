using System;
using System.Collections.Generic;

namespace Monopoly_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello bienvenue dans le monopoly");
            Initialisation();
            //Menu.Selection_avec_Consigne(null);
            //MainGame();

            Console.ReadKey();

        }

        static void Initialisation()
        {
            // Data necessaire :
            Type[] boardtype = { Type.Others, Type.Property, Type.Event, Type.Property, Type.Taxes, Type.Gare, Type.Property, Type.Event, Type.Property, Type.Property, Type.Others, 
                Type.Property, Type.Public,Type.Property,Type.Property,Type.Gare,Type.Property,Type.Event,Type.Property,Type.Property,Type.Others,
                Type.Property,Type.Event,Type.Property,Type.Property,Type.Gare,Type.Property,Type.Property,Type.Public,Type.Property,Type.Others,Type.Property,Type.Property,
                Type.Event,Type.Property,Type.Gare,Type.Event,Type.Property,Type.Taxes,Type.Property};
            
            ///Initialisation
            Game main = Game.Instance;
            main.create_player();
            main.First_player = chooseFirstPlayer(main.Player_list);

            Random rand = new Random();                    // Sinon on obtient toujours les mêmes nombres (si on cree un nouveau random a chaque fois)
            DiceInvoker diceinvoker = new DiceInvoker();   // Le invoker pour les lancées de dées, pour le command pattern
            int number_player_turn = main.First_player;
            bool win = false;
            int turn_number = 1;
            SwitchFactoryCommand ComandFactory = new SwitchFactoryCommand();
            SwitchInvokerFactory InvokerFactory = new SwitchInvokerFactory();
            int position = 0;
            Box case_actual;

            while (win != true)
            {
                Console.WriteLine("Tour numero " + turn_number);
                for(int i = number_player_turn; i < main.Player_list.Length+number_player_turn; i ++)
                {
                   
                    ///Debut du tour
                    Console.WriteLine("\nAu tour de " + main.Player_list[number_player_turn].Pseudo);
                    Command command = new Dice(main.Player_list[number_player_turn], rand);                   
                    diceinvoker.LaunchDice(command);
                    diceinvoker.ExecuteCommand();

                    //Choix des actions
                    position = main.Player_list[number_player_turn].Index;
                    case_actual = main.Board[position];
                    Console.WriteLine("\nArrivée sur la case " + case_actual.Name);
                    switch (boardtype[position])
                    {
                        case Type.Taxes:
                            BoxCommand boxcommand = ComandFactory.CreateCommand(Type.Taxes, main, main.Player_list[number_player_turn]);
                            BoxInvoker boxinvoker = InvokerFactory.CreateInvoker(Monopoly_game.InvokerFactory.Type.Taxes);
                            boxinvoker.setcommand(boxcommand);
                            boxinvoker.ExecuteCommand();
                            break;
                        case Type.Property:
                            BoxCommand boxcommand_property = ComandFactory.CreateCommand(Type.Property, main, main.Player_list[number_player_turn]);
                            BoxInvoker boxinvoker_property = InvokerFactory.CreateInvoker(Monopoly_game.InvokerFactory.Type.Taxes);
                            boxinvoker_property.setcommand(boxcommand_property);
                            boxinvoker_property.ExecuteCommand();
                            break;
                        default:
                            Console.WriteLine("pas encore");
                            break;
                    }


                    number_player_turn++;
                    if (number_player_turn >= main.Player_list.Length)
                    {
                        number_player_turn = 0;
                    }
                }

                //Console.Clear();
                
                turn_number++;
                if(turn_number == 4)
                {
                    win = true;
                    Console.WriteLine("Fin");
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
                Console.Clear();
                Console.WriteLine("Premier joueur a jouer : " + List_Player[first_player].Pseudo);
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
