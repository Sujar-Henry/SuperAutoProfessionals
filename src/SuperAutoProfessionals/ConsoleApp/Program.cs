﻿using System;
using System.Data;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{
	static void Main()
	{
        Console.WriteLine("Enter left team professional at 1");
        Console.Write("CodeName:");
        var templeftprof1 = Console.ReadLine();
        var leftprof1 = CreateProfessionalByCodeName(templeftprof1);
        if (leftprof1 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            leftprof1.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            leftprof1.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 1");
        }



        Console.WriteLine("Enter left team professional at 2");
        Console.Write("CodeName:");
        var templeftprof2 = Console.ReadLine();
        var leftprof2 = CreateProfessionalByCodeName(templeftprof2);
        if (leftprof2 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            leftprof2.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            leftprof2.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 2");
        }
        

        Console.WriteLine("Enter left team professional at 3");
        Console.Write("CodeName:");
        var templeftprof3 = Console.ReadLine();
        var leftprof3 = CreateProfessionalByCodeName(templeftprof3);
        if (leftprof3 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            leftprof3.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            leftprof3.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 3");
        }

        Console.WriteLine("Enter left team professional at 4");
        Console.Write("CodeName:");
        var templeftprof4 = Console.ReadLine();
        var leftprof4 = CreateProfessionalByCodeName(templeftprof4);
        if (leftprof4 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            leftprof4.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            leftprof4.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 4");
        }

        Console.WriteLine("Enter left team professional at 5");
        Console.Write("CodeName:");
        var templeftprof5 = Console.ReadLine();
        var leftprof5 = CreateProfessionalByCodeName(templeftprof5);
        if (leftprof5 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            leftprof5.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            leftprof5.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 5");
        }

        //Create right team

        Console.WriteLine("Enter right team professional at 1");
        Console.Write("CodeName:");
        var temprightprof1 = Console.ReadLine();
        var rightprof1 = CreateProfessionalByCodeName(temprightprof1);
        if (rightprof1 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            rightprof1.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            rightprof1.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 1");
        }
        

        Console.WriteLine("Enter right team professional at 2");
        Console.Write("CodeName:");
        var temprightprof2 = Console.ReadLine();
        var rightprof2 = CreateProfessionalByCodeName(temprightprof2);
        if (rightprof2 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            rightprof2.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            rightprof2.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 2");
        }


        Console.WriteLine("Enter right team professional at 3");
        Console.Write("CodeName:");
        var temprightprof3 = Console.ReadLine();
        var rightprof3 = CreateProfessionalByCodeName(temprightprof3);
        if (rightprof3 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            rightprof3.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            rightprof3.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 3");
        }


        Console.WriteLine("Enter right team professional at 4");
        Console.Write("CodeName:"); 
        var temprightprof4 = Console.ReadLine();
        var rightprof4 = CreateProfessionalByCodeName(temprightprof4);
        
        if (rightprof4 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            rightprof4.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            rightprof4.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 4");
        }
            



        Console.WriteLine("Enter right team professional at 5");
        Console.Write("CodeName:");
        var temprightprof5 = Console.ReadLine();
        var rightprof5 = CreateProfessionalByCodeName(temprightprof5);
        if (rightprof5 != null)
        {
            Console.Write("Attack:");
            int attackValue;
            while (!int.TryParse(Console.ReadLine(), out attackValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Attack:");
            }
            rightprof5.Attack = attackValue;

            Console.Write("Health:");
            int healthValue;
            while (!int.TryParse(Console.ReadLine(), out healthValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                Console.Write("Health:");
            }
            rightprof5.Health = healthValue;
        }
        else
        {
            Console.WriteLine($"Empty professional at index 5");
        }

        

		var left = new Professional?[]
		{
            
            leftprof1,
			leftprof2,
			leftprof3,
			leftprof4,
			leftprof5
		};

		var right = new Professional?[]
		{
			rightprof1,
			rightprof2,
			rightprof3,
			rightprof4,
			rightprof5
		};

		var game = new Game(new Team(left, Side.Left), new Team(right, Side.Right));

		var winner = game.RunTurn().Result;

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(winner == null ? "Draw" : $"Winner: {winner.Side}");
	}
    static Professional? CreateProfessionalByCodeName(string codeName)
    {
    switch (codeName)
    {
 
        case "Nu": return new Nurse();
        case "Sn": return new Sniper();
        case "GD": return new GraveDigger();
        case "DM": return new Demolitionist();
        case "Bu": return new Buthcer();
        case "HK": return new Hacker();
        case "MT": return new Mathematician();
        case "AT": return new Attorney();
        case "Tr": return new Trainer();
        case "-": return null;
        default:
                Console.WriteLine($"Unknown code name: {codeName}");
                Console.Write("Please enter a valid code name: ");
                codeName = Console.ReadLine();
                return CreateProfessionalByCodeName(codeName);
        

     }
}
}