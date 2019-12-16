using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monopoly_game
{
    sealed class Game  // Cette classe est un singleton : en raison du niveau de protection du constructeur, de la création d'une instance readonly de la classe 
                       // L'instance est donc crée de "base" et est accesible par la propriété game qui ne retourne QUE cet instance
                       // https://www.e-naxos.com/Blog/post/Singleton-qui-es-tu-.aspx
    {
        private List<Box> board;
        private int common_pot;
<<<<<<< HEAD
        private Player[] player_list;
        private static readonly Game instance = new Game();

        private Game()
        {
            this.Boxes = null;
            this.Common_pot = 0;
            this.Player_list = null;             // je prefere mettre null plutot que createPlayer car sinon la creation des joueurs est la première chose qui s'affiche sur la console avant même le début du jeux, presentation, ect ....
            this.Board = createBoard();
=======
        private List<Player> player_list;
        private static readonly Game instance = new Game();
        private int first_player;
        private Game()
        {
            this.Common_pot = 0;
            this.Player_list = null;             // je prefere mettre null plutot que createPlayer car sinon la creation des joueurs est la première chose qui s'affiche sur la console avant même le début du jeux, presentation, ect ....
            this.Board = createBoard();
            this.First_player = 0;
>>>>>>> final
        }

        public static Game Instance => instance;

        public int Common_pot { get => common_pot; set => common_pot = value; }
<<<<<<< HEAD
        public List<Box> Boxes { get => Board; set => Board = value; }
        public Player[] Player_list { get => player_list; set => player_list = value; }
        internal List<Box> Board { get => board; set => board = value; }
=======
        internal List<Box> Board { get => board; set => board = value; }
        public int First_player { get => first_player; set => first_player = value; }
        internal List<Player> Player_list { get => player_list; set => player_list = value; }
>>>>>>> final

        public void  create_player()
        {
            string nom = "";
<<<<<<< HEAD
            Console.WriteLine("Selectionnez le nombre de joueurs (entre 2 et 8)");
            int choix = Convert.ToInt32(Console.ReadLine());
            while (choix > 8 || choix < 1) 
            {
                Console.WriteLine("Choix incorrect");
                Console.WriteLine("Selectionnez le nombre de joueurs (entre 2 et 8)");
                choix = Convert.ToInt32(Console.ReadLine());
            }
            Player [] List_player = new Player[choix];
            for (int i = 0; i < choix ;i++)
            {
                Console.WriteLine("Joueur "+i+" entrez votre nom");
                nom = Console.ReadLine();
                List_player[i] = new Player(nom, null);
            }
            this.player_list = List_player;
=======
            string[] consigne = { "Selectionnez le nombre de joueurs (entre 2 et 8)", "2", "3", "4", "5", "6", "7", "8" };
            int choix = Menu.Selection_avec_Consigne(consigne);
            List<Player> List_player = new List<Player>();
            for (int i = 0; i < choix+2 ;i++)
            {
                Console.WriteLine("Joueur "+(i+1)+" entrez votre nom");
                nom = Console.ReadLine();
                List_player.Add(new Player(nom, null));
            }
            this.Player_list = List_player;
>>>>>>> final
        }
       
        public List<Box> createBoard()  // Not a factory but it creates in he simple way each box of the board
        {                               // switch manage creation for class with a lot of instances(property) or class with simple constructor(others,event,gara_station)
                                        // Taxes and public_utility asl more parameters and with have enough index and data-array so i choose to create them manually
           
            string[] type = { "Others", "Event", "Property", "Taxes", "Public_utility", "Gare_stations" };
            List<Box> Board = new List<Box>();

            Others_Box Start = new Others_Box("Case départ",null);
            Board.Add(Start);

            int[] rents = { 2, 10, 30, 90, 160, 250 };
<<<<<<< HEAD
            Property Boulevard_belleville = new Property(60, 30, 50, rents,"marron", 0, null, "Boulevard De Belleville", null);
=======
            Property Boulevard_belleville = new Property(60, 30, 50, rents, ConsoleColor.Gray, 0, null, "Boulevard De Belleville", null);
>>>>>>> final
            Board.Add(Boulevard_belleville);

            Event communaute1 = new Event(null, "Caisse de Communauté", null);
            Board.Add(communaute1);

            int [] rents2 = { 4, 20, 60, 180, 320, 450};
<<<<<<< HEAD
            Property rue_lecourbe = new Property(60, 30, 50, rents2, "marron", 0, null, "Rue Lecourbe", null);
=======
            Property rue_lecourbe = new Property(60, 30, 50, rents2, ConsoleColor.Gray, 0, null, "Rue Lecourbe", null);
>>>>>>> final
            Board.Add(rue_lecourbe);

            Taxes revenu = new Taxes(200, "Impots sur le revenu", null);
            Board.Add(revenu);

            gare_station gare_montparnasse = new gare_station(200, 100, "Gare Montparnasse",null);
            Board.Add(gare_montparnasse);

            int[] rents3 = { 6, 30, 90, 270, 400, 550 };
<<<<<<< HEAD
            Property rue_vaugirard = new Property(100, 50, 50, rents3, "bleu clair", 0, null, "Rue de Vaugirad", null);
=======
            Property rue_vaugirard = new Property(100, 50, 50, rents3, ConsoleColor.Blue, 0, null, "Rue de Vaugirad", null);
>>>>>>> final
            Board.Add(rue_vaugirard);

            Event chance = new Event(null, "Chance", null);
            Board.Add(chance);

            int[] rents4 = { 6, 30, 90, 270, 400, 550 };
<<<<<<< HEAD
            Property rue_courcelles = new Property(100, 50, 50, rents4, "bleu clair", 0, null, "Rue de Courcelles", null);
            Board.Add(rue_courcelles);

            int[] rents5 = { 8, 40, 100, 350, 400, 600 };
            Property avenue_republique = new Property(120, 60, 50, rents5, "bleu clair ", 0, null, "Avenue de la République", null);
=======
            Property rue_courcelles = new Property(100, 50, 50, rents4, ConsoleColor.Blue, 0, null, "Rue de Courcelles", null);
            Board.Add(rue_courcelles);

            int[] rents5 = { 8, 40, 100, 350, 400, 600 };
            Property avenue_republique = new Property(120, 60, 50, rents5, ConsoleColor.Blue, 0, null, "Avenue de la République", null);
>>>>>>> final
            Board.Add(avenue_republique);

            Others_Box prison = new Others_Box("Prison", null);
            Board.Add(prison);

            int[] rents6 = { 10, 50, 150, 425, 625, 750 };
<<<<<<< HEAD
            Property boulevard_vilette = new Property(140, 70, 100, rents6, "rose", 0, null, "Boulevard de la Villette", null);
=======
            Property boulevard_vilette = new Property(140, 70, 100, rents6, ConsoleColor.Magenta, 0, null, "Boulevard de la Villette", null);
>>>>>>> final
            Board.Add(boulevard_vilette);

            Public_utility electricity = new Public_utility(150, 4, 75, "Compagnie de distribution d'électricité", null);
            Board.Add(electricity);

            int[] rents7 = { 10, 50, 150, 425, 625, 750};
<<<<<<< HEAD
            Property avenue_neuilly = new Property(140, 70, 100, rents7, "rose", 0, null, "Avenue de Neuilly", null);
            Board.Add(avenue_neuilly);

            int[] rents8 = { 12, 60, 180, 500, 700, 900 };
            Property rue_paradis = new Property(160, 80, 100, rents8, "rose", 0, null, "Rue du Paradis", null);
=======
            Property avenue_neuilly = new Property(140, 70, 100, rents7, ConsoleColor.Magenta, 0, null, "Avenue de Neuilly", null);
            Board.Add(avenue_neuilly);

            int[] rents8 = { 12, 60, 180, 500, 700, 900 };
            Property rue_paradis = new Property(160, 80, 100, rents8, ConsoleColor.Magenta
                
                
                , 0, null, "Rue du Paradis", null);
>>>>>>> final
            Board.Add(rue_paradis);

            gare_station gare_lyon = new gare_station(200, 100, "Gare de Lyon", null);
            Board.Add(gare_lyon);

            int[] rents9 = { 14, 70, 200, 550, 750, 950 };
<<<<<<< HEAD
            Property avenue_mozart = new Property(160, 80, 100, rents9 ,"orange", 0, null, "Avenue Mozart", null);
=======
            Property avenue_mozart = new Property(160, 80, 100, rents9 , ConsoleColor.DarkYellow, 0, null, "Avenue Mozart", null);
>>>>>>> final
            Board.Add(avenue_mozart);

            Event communaute2 = new Event(null, "Caisse de Communauté", null);
            Board.Add(communaute2);

            int[] rents10 = { 14, 70, 200, 550, 750, 950 };
<<<<<<< HEAD
            Property boulevard_saintmichel = new Property(180, 90, 100, rents10, "orange", 0, null, "Boulevard Saint-Michel", null);
            Board.Add(boulevard_saintmichel);

            int[] rents11 = { 16, 80, 220, 600, 800, 1000 };
            Property place_pigalle = new Property(200, 100, 100, rents11, "orange", 0, null, "Place Pigalle", null);
=======
            Property boulevard_saintmichel = new Property(180, 90, 100, rents10, ConsoleColor.DarkYellow, 0, null, "Boulevard Saint-Michel", null);
            Board.Add(boulevard_saintmichel);

            int[] rents11 = { 16, 80, 220, 600, 800, 1000 };
            Property place_pigalle = new Property(200, 100, 100, rents11, ConsoleColor.DarkYellow, 0, null, "Place Pigalle", null);
>>>>>>> final
            Board.Add(place_pigalle);

            Others_Box Park = new Others_Box("Parc gratuit", null);
            Board.Add(Park);

            int[] rents12 = { 18, 90, 250, 700, 875, 1050 };
<<<<<<< HEAD
            Property avenue_matignon = new Property(220, 110, 150, rents12, "rouge", 0, null, "Avenue Matignon", null);
=======
            Property avenue_matignon = new Property(220, 110, 150, rents12, ConsoleColor.Red, 0, null, "Avenue Matignon", null);
>>>>>>> final
            Board.Add(avenue_matignon);

            Event chance2 = new Event(null, "Chance", null);
            Board.Add(chance2);

            int[] rents13 = { 18, 90, 250, 700, 875, 1050 };
<<<<<<< HEAD
            Property boulevard_malsherbes = new Property(220, 110, 150, rents13, "rouge", 0, null, "Boulevard Malsherbes", null);
            Board.Add(boulevard_malsherbes);

            int[] rents14 = { 20, 100, 300, 750, 925, 1100 };
            Property avenue_henri = new Property(240, 120, 150, rents14, "rouge", 0, null, "Avenue Henri-Martin", null);
=======
            Property boulevard_malsherbes = new Property(220, 110, 150, rents13, ConsoleColor.Red, 0, null, "Boulevard Malsherbes", null);
            Board.Add(boulevard_malsherbes);

            int[] rents14 = { 20, 100, 300, 750, 925, 1100 };
            Property avenue_henri = new Property(240, 120, 150, rents14, ConsoleColor.Red, 0, null, "Avenue Henri-Martin", null);
>>>>>>> final
            Board.Add(avenue_henri);

            gare_station gare_nord = new gare_station(200, 100, "Gare du Nord", null);
            Board.Add(gare_nord);

            int[] rents15 = { 22, 110, 330, 800, 975, 1150 };
<<<<<<< HEAD
            Property faubourg_saint_honore = new Property(260, 130, 150, rents15, "jaune", 0, null, "Faubourg Saint-Honoré", null);
            Board.Add(faubourg_saint_honore);

            int[] rents16 = { 22, 110, 330, 800, 975, 1150 };
            Property place_bourse = new Property(260, 130, 150, rents16, "jaune", 0, null, "Place de la Bourse", null);
=======
            Property faubourg_saint_honore = new Property(260, 130, 150, rents15, ConsoleColor.Yellow, 0, null, "Faubourg Saint-Honoré", null);
            Board.Add(faubourg_saint_honore);

            int[] rents16 = { 22, 110, 330, 800, 975, 1150 };
            Property place_bourse = new Property(260, 130, 150, rents16, ConsoleColor.Yellow, 0, null, "Place de la Bourse", null);
>>>>>>> final
            Board.Add(place_bourse);

            Public_utility water = new Public_utility(150,4, 75, "Compagnie de distribution des eaux", null);
            Board.Add(water);

            int[] rents17 = { 24, 120, 360, 850, 1025, 1200 };
<<<<<<< HEAD
            Property rue_lafayette = new Property(280, 140, 150, rents17, "jaune", 0, null, "Rue la Fayette", null);
=======
            Property rue_lafayette = new Property(280, 140, 150, rents17, ConsoleColor.Yellow, 0, null, "Rue la Fayette", null);
>>>>>>> final
            Board.Add(rue_lafayette);

            Others_Box Aller_prison = new Others_Box("Aller en Prison", null);
            Board.Add(Aller_prison);

            int[] rents18 = { 26, 130, 390, 900, 1100, 1275 };
<<<<<<< HEAD
            Property avenue_breteuil = new Property(300, 150, 200, rents18, "vert", 0, null, "Avenue de Breteuil", null);
            Board.Add(avenue_breteuil);

            int[] rents19 = { 26, 130, 390, 900, 1100, 1275 };
            Property avenue_foch = new Property(300, 150, 200, rents19, "vert", 0, null, "Avenue Foch", null);
=======
            Property avenue_breteuil = new Property(300, 150, 200, rents18, ConsoleColor.DarkGreen, 0, null, "Avenue de Breteuil", null);
            Board.Add(avenue_breteuil);

            int[] rents19 = { 26, 130, 390, 900, 1100, 1275 };
            Property avenue_foch = new Property(300, 150, 200, rents19, ConsoleColor.DarkGreen, 0, null, "Avenue Foch", null);
>>>>>>> final
            Board.Add(avenue_breteuil);

            Event communaute3 = new Event(null, "Caisse de Communauté", null);
            Board.Add(communaute3);

            int[] rents20 = { 28, 150, 450, 1000, 1200, 1400 };
<<<<<<< HEAD
            Property boulevard_capucine = new Property(320, 160, 200, rents20, "vert", 0, null, "Boulevard des Capucines", null);
=======
            Property boulevard_capucine = new Property(320, 160, 200, rents20, ConsoleColor.DarkGreen, 0, null, "Boulevard des Capucines", null);
>>>>>>> final
            Board.Add(boulevard_capucine);

            gare_station gare_saintlaz = new gare_station(200, 100, "Gare Saint-Lazare", null);
            Board.Add(gare_saintlaz);

            Event chance3 = new Event(null, "Chance", null);
            Board.Add(chance3);

            int[] rents21 = { 35, 175, 500, 1100, 1300, 1500 };
<<<<<<< HEAD
            Property avenue_champ_elysees = new Property(350, 175, 200, rents21, "bleu marine", 0, null, "Avenue des Champs-Elysées", null);
=======
            Property avenue_champ_elysees = new Property(350, 175, 200, rents21, ConsoleColor.DarkBlue, 0, null, "Avenue des Champs-Elysées", null);
>>>>>>> final
            Board.Add(avenue_champ_elysees);

            Taxes luxe = new Taxes(100, "Taxe de luxe", null);
            Board.Add(luxe);

            int[] rents22 = { 50, 200, 600, 1400, 1700, 2000 };
<<<<<<< HEAD
            Property rue_paix = new Property(400,200, 200, rents22, "bleu marine", 0, null, "Rue de la Paix", null);
=======
            Property rue_paix = new Property(400,200, 200, rents22, ConsoleColor.DarkBlue, 0, null, "Rue de la Paix", null);
>>>>>>> final
            Board.Add(rue_paix);

            return Board;
        }

<<<<<<< HEAD
=======
        static void Preview_board(int index, Game main)
        {

            //nous allons recuperer les index avant et apres
            //nous choisissons d'afficher 5 cases avant et 5 cases apres
            int first_case = (index - 5) % 40;
            int last_case = (index + 5) % 40;
            Console.WriteLine("number | name | owner | house(s)?");
            for (int i = first_case; i < last_case; i = (i + 1) % 40)
            {
                Console.Write(i + " | ");
                if (main.Board[i] is Property)
                {
                    Console.ForegroundColor = ((Property)main.Board[i]).Color;
                }
                Console.Write(main.Board[i].Name + " | ");
                Console.ResetColor();
                if (main.Board[i] is Property)
                {
                    Console.Write(((Property)main.Board[i]).Owner.Pseudo + " | ");
                }
                else
                {
                    Console.WriteLine(((Property)main.Board[i]).House_number);
                }
            }
        }
>>>>>>> final
    }
        
 
 
 }

