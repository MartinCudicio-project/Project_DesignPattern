using System;
namespace Monopoly_game
{
    public abstract class Menu
    {

        //l'affichage console commencera par indiquer à l'utilisateur comment fonctionne le menu
        //selection_sans_consigne retourne le numero de (0, 1, ..., n-1) de l'option selectionnée par l'utilisateur
        //on passe en parametres les differentes options disponibles
        //EXEMPLE : "Jaune","Rouge","Bleu", ...

        static public int Selection_sans_Consigne(string[] choix_gen)
        {
            string[] Instructions = new string[choix_gen.Length + 1];
            Instructions[0] = "utiliser les fleches pour se déplacer, tappez entrer pour selectionner";
            choix_gen.CopyTo(Instructions, 1);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            int choix = 1;
            while (cki.Key != ConsoleKey.Enter)
            {
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    choix++;
                    if (choix > Instructions.Length - 1)
                    {
                        choix = 1;
                    }
                    Console.Clear();
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    choix--;
                    if (choix < 1)
                    {
                        choix = Instructions.Length - 1;
                    }
                    Console.Clear();
                }
                for (int cas = 0; cas < Instructions.Length; cas++)
                {
                    if (cas == choix)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(Instructions[cas]);
                        Console.ResetColor();
                    }
                    else
                        Console.WriteLine(Instructions[cas]);
                }
                cki = Console.ReadKey();
            }
            Console.Clear();
            return choix - 1;
        }
        //l'affichage console commencera par indiquer à l'utilisateur comment fonctionne le menu
        //selection_avec_consigne retourne le numero de (0, 1, ..., n-2) de l'option selectionnée par l'utilisateur
        //la premiere chaine de caractere du tableau devra etre la consigne.
        //EXEMPLE: "veuillez selectez la couleur pour pion..."
        //on passe en parametres les differentes options disponibles
        //EXEMPLE: "Jaune","Bleu","Rouge", ...
        static public int Selection_avec_Consigne(string[] choix_gen)
        {
            string[] Instructions = new string[choix_gen.Length + 1];
            Instructions[0] = "utiliser les fleches pour se déplacer, tappez entrer pour selectionner";
            choix_gen.CopyTo(Instructions, 1);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            int choix = 2;
            while (cki.Key != ConsoleKey.Enter)
            {
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    choix++;
                    if (choix > Instructions.Length - 1)
                    {
                        choix = 2;
                    }
                    Console.Clear();
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    choix--;
                    if (choix < 2)
                    {
                        choix = Instructions.Length - 1;
                    }
                    Console.Clear();
                }
                for (int cas = 0; cas < Instructions.Length; cas++)
                {
                    if (cas == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(Instructions[cas]);
                        Console.ResetColor();
                    }
                    if (cas == choix)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(Instructions[cas]);
                        Console.ResetColor();
                    }
                    if (cas != 1 && cas != choix)
                        Console.WriteLine(Instructions[cas]);
                }
                cki = Console.ReadKey();
            }
            Console.Clear();
            return choix - 2;
        }
    }
}

