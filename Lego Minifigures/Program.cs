using Lego_Minifigures.Figures;
using System;
using System.Threading;

namespace Lego_Minifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lego minifigure game!");
            Thread.Sleep(1500);
            Console.WriteLine("In this game, you can manipulate minifigures.");
            Thread.Sleep(1500);
            Console.WriteLine("Please choose a Lego minifigure. Enter the number for the corresponding character and press enter.");
            Thread.Sleep(1500);
            Console.WriteLine("1) for Bill");
            Console.WriteLine("2) for Jane");
            Console.WriteLine("3) for Pat");

            var chooseFigure = Console.ReadLine();
            switch (chooseFigure)
            {
                case "1":
                    //figureChoice = "Bill";
                    Console.WriteLine("You have chosen Bill.");
                    Thread.Sleep(1500);
                    Console.WriteLine("That is a fairly good choice.");
                    Thread.Sleep(1500);
                    var Bill = new Character("Bill", "no", "green", "tan", "mace");
                    Bill.Desc();
                    break;
                case "2":
                    //figureChoice = "Jane";
                    Console.WriteLine("You have chosen Jane.");
                    Thread.Sleep(1500);
                    Console.WriteLine("Excellent choice.");
                    Thread.Sleep(1500);
                    var Jane = new Character("Jane", "blonde", "white", "blue", "axe");
                    Jane.Desc();
                    break;
                case "3":
                    //figureChoice = "Pat";
                    Console.WriteLine("You have chosen Pat.");
                    Thread.Sleep(1500);
                    Console.WriteLine("An amazingly brave choice.");
                    Thread.Sleep(1500);
                    var Pat = new Character("Pat", "dark", "pink", "orange", "club");
                    Pat.Desc();
                    break;
                default:
                    Console.WriteLine("You have made an invalid choice.");
                    break;
            }

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("You are approached by Mabel, who is wielding a baseball bat.");
            Thread.Sleep(1500);
            Console.WriteLine("What do you choose to do? Enter a number for the corresponding action and press enter.");
            Thread.Sleep(1500);
            Console.WriteLine("1) run away");
            Console.WriteLine("2) attack");
            Console.WriteLine("3) kiss Mabel on the cheek");

            var chooseAttack = Console.ReadLine();
            switch (chooseAttack)
            {
                case "1":
                    Console.WriteLine("You run away like an utter coward. And Mabel only wanted to be friends.");
                    break;
                case "2":
                    Console.WriteLine("As you attack Mabel, you lose your balance and fall to the ground, knocking yourself unconscious. What a loser.");
                    break;
                case "3":
                    Console.WriteLine("A kiss was all that Mabel ever wanted. She thanks you and you both live happily ever after.");
                    break;
                default:
                    Console.WriteLine("You have made an invalid choice, idiot.");
                    break;
            }

            

           
        }
      

    }
}
