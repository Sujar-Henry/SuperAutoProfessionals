﻿using System;
using System.Data;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{
	static void Main()
	{
        //Creating the professionals



        var left = new Professional?[5];

		var right = new Professional?[5];

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Enter left team professional at {i}");
    Console.Write("CodeName:");
    var tempLeftProf = Console.ReadLine();
    var leftProf = CreateProfessionalByCodeName(tempLeftProf);
    if (leftProf != null)
    {
        Console.Write("Attack:");
        int attackValue;
        while (!int.TryParse(Console.ReadLine(), out attackValue) || attackValue < 1 || attackValue > 50)
        {
            Console.WriteLine("Invalid input. Please enter again.");
            Console.Write("Attack:");
        }
        leftProf.Attack = attackValue;

        Console.Write("Health:");
        int healthValue;
        while (!int.TryParse(Console.ReadLine(), out healthValue) || healthValue < 1 || healthValue > 50)
        {
            Console.WriteLine("Invalid input. Please enter again.");
            Console.Write("Health:");
        }
        leftProf.Health = healthValue;
    }
    else
    {
        Console.WriteLine($"Empty professional at index {i}");
    }
    left[i - 1] = leftProf;
}



for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Enter right team professional at {i}");
    Console.Write("CodeName:");
    var tempRightProf = Console.ReadLine();
    var rightProf = CreateProfessionalByCodeName(tempRightProf);
    if (rightProf != null)
    {
        Console.Write("Attack:");
        int attackValue;
        while (!int.TryParse(Console.ReadLine(), out attackValue) || attackValue < 1 || attackValue > 50)
        {
            Console.WriteLine("Invalid input. Please enter again.");
            Console.Write("Attack:");
        }
        rightProf.Attack = attackValue;

        Console.Write("Health:");
        int healthValue;
        while (!int.TryParse(Console.ReadLine(), out healthValue) || healthValue < 1 || healthValue > 50)
        {
            Console.WriteLine("Invalid input. Please enter again.");
            Console.Write("Health:");
        }
        rightProf.Health = healthValue;
    }
    else
    {
        Console.WriteLine($"Empty professional at index {i}");
    }
    right[i - 1] = rightProf;
}
        


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