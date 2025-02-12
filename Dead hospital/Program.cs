using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;

class Game
{
    private static Hero Player = new Hero ("" , 0);
    private static List<string> inventory = new List<string> ([""]);
    private static string Floore2_Room1item = "bottled water" ;
    private static string f1c = "1";
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("--                               Dead Hospital                              --");
        Console.WriteLine("------------------------------------------------------------------------------\n\n\n\n\n");

        SMenu();
    }

    public static void SMenu()
    {
         
  
         Console.Write(" 1- Start the game\n 2- Exit the game\n\n ______: ");
         var x = Console.ReadLine(); 
         int input = 0;
         int.TryParse(x, out input );
         if (input == 1)
         {
            ChoseHero();
         }

         else if (input == 2)
         {
            Exit();
         }

         else
         {
              Console.Clear();
              Console.WriteLine("---------------------------------------------------------------------------\n\nEnter a valid choice");
              SMenu();
          
         }

         
    }
    public static void Exit()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("--                       Thank you for playing this game                  --");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("\n\n\n Press any key to Exit");
        Console.ReadKey();
    }
        public class Hero
    {
        public string Name { get; set;}
        public int Helth {get; set;}
        public Hero (string name , int helth)
        {
            Name = name;
            Helth = helth;
        }
      

        public void Status()
        {
            Console.WriteLine($"\n\tName : {Name}\t\t\tHp : {Helth}\n");
        }
        
    }
      
   
    public static void ChoseHero()
    {
           
         Console.Clear();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("                            Chose your character                           ");
        Console.Write("\n\n\n\n 1- Leon S. Kennedy\t\t\thp : 100\n 2- Claire Redfield\t\t\thp : 150\n 3- Chris Redfield\t\t\thp : 50\n\n\n_____: ");
        var x = Console.ReadLine();
        int input = 0;
        int.TryParse(x , out input);
        
        switch (input)
        {
            case 1:
              Player.Name ="Leon S. Kennedy";
              Player.Helth = 100;
              Player.Status();
              StartGame();
              return;
            case 2:
              Player.Name ="Claire Redfield";
              Player.Helth = 150;
              Player.Status();
              StartGame();
              return;
            case 3:
              Player.Name ="Chris Redfield";
              Player.Helth = 50;
              Player.Status();
              StartGame();
              return;
            default :
              ChoseHero();
              return;
        }
    }
    public static void StartGame()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------\n");
        Console.WriteLine($"{Player.Name} woke up in a dimly lit hospital room, the harsh fluorescent lights flickering above him. He lay on a ");
        Console.WriteLine($"narrow bed, the sheets crisp but slightly rumpled. The walls were a dull green, peeling in places, and a ");
        Console.WriteLine($"small barred window offered a glimpse of the chaotic streets of Raccoon City outside.\n");
        Console.WriteLine($"A heart monitor beeped rhythmically, filling the silence. On a nightstand, a glass of water sat next to a ");
        Console.WriteLine($"wilted flower in a plastic vase. As he sat up, he heard muffled noises coming from somewhere below, ");
        Console.WriteLine($"distant and unsettling. {Player.Name}'s mind raced, trying to piece together how he had ended up in this eerie place.\n\n");

        Floore2_Room1();
    }                                                                                                                    
    public static void Floore2_Room1()                                                                                   
    {                                                                                                                    
                                                                                                                         
        Console.WriteLine(" 1_ Search the room\t2_ Go to the corridor\t3_ Check the window\t4_ Inventory\t5_ Menu\n\n"); 
        Console.Write(" ______: ");                                                                                      
        var x = Console.ReadLine();                                                                                      
        int.TryParse(x, out int input);                                                                                  
        switch (input)                                                                                                   
        {
            case 1:

                if (Floore2_Room1item == "bottled water")
                {Floore2_Room1item = ""; Console.Clear(); Console.WriteLine("\n** you found bottled water on the floor\n\n\n\n\n"); inventory.Add("bottled water"); Floore2_Room1();}

                else {Console.Clear(); Console.WriteLine("\nYou alredy Searched the room\n\n\n\n\n"); Floore2_Room1();}

                return;
            case 2:
                if (f1c == "1") 
                {
                    f1c = "";
                    Console.Clear();
                    Console.WriteLine($" As {Player.Name} stepped into the corridor, the fluorescent lights buzzed overhead, casting a sterile glow on the ");
                    Console.WriteLine($"pale walls. He noticed a hospital map mounted on the wall, revealing he was on the second floor, where ");
                    Console.WriteLine($"each floor had five rooms. His heart raced as he spotted old bloodstains smeared on the floor, a chilling ");
                    Console.WriteLine($"reminder of the chaos that had unfolded in this unsettling place.\n\n\n");
                    Floor2corridor();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" you are in corridor\n\n\n");
                    Floor2corridor();
                }
                return;
            case 3:
                Console.Clear();
                Console.WriteLine($"{Player.Name} glanced out the barred window and spotted a car parked haphazardly on the street below\nits door wide open.\n\n\n\n\n");
                Floore2_Room1();
                return;
            case 4:
                Console.Clear();
                Console.WriteLine($"\nYour inventory : {string.Join(" _ " , inventory)}\n\n\n\n\n");
                Floore2_Room1();
                return;
            case 5:
                Console.Clear(); SMenu();
                return;
            default :
                Console.Clear();
                Console.WriteLine(" You are in the Room 1\n\n\n\n\n\n");
                Floore2_Room1();
                return;
        }

    }
    public static void Floor2corridor()
    {
        Console.WriteLine(" 1_ Search the corridor    2_ Go to Room(1)\t3_ Go to Room(2)\t4_ Go to Room(3)\t5_ Go to Operating Room\n");
        Console.WriteLine("6_ Go to Staff Room\t7_ Check the Nurse Call Phone\t8_ Go to floor 1\t9_ Go to floor 3\n");
        Console.WriteLine("10_Inventory\t11_ Menu\n");
        Console.Write(" ______: ");
        var x = Console.ReadLine();
        int.TryParse(x, out int input);
        switch (input)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"{Player.Name} cautiously made his way down the corridor, scanning the surroundings for any signs of life. The ");
                Console.WriteLine($"reception area loomed ahead, its desk cluttered with abandoned papers and a flickering computer screen. ");
                Console.WriteLine($"The silence was oppressive, broken only by the distant hum of the building settling. He felt a growing ");
                Console.WriteLine($"sense of urgency, knowing he needed to find answers in this unsettling hospital.\n\n\n");
                Floor2corridor();
                return;

            case 2:
                Console.Clear();
                Console.WriteLine("You enterd to Room1 \n\n\n\n\n");
                Floore2_Room1();
                return;

            case 3:
                return;
            case 4:
                return;
            case 5:
                return;
            case 6:
                return;
            case 7:
                Console.Clear();
                Console.WriteLine($"{Player.Name} approached the Nurse Call Phone mounted on the wall, hoping to summon help. He pressed the ");
                Console.WriteLine($"button, but nothing happened—no chime, no response, just an unsettling silence that deepened his sense ");
                Console.WriteLine($"of isolation.\n\n\n\n");
                Floor2corridor();
                return;

            case 8:
                return;
            case 9:
                return;
            case 10:
                Console.Clear();
                Console.WriteLine($"\nYour inventory : {string.Join(" _ ", inventory)}\n\n\n\n\n");
                Floor2corridor();
                return;

            case 11:
                Console.Clear();
                SMenu();
                return;

            default:
                return;
        }    
    }

}