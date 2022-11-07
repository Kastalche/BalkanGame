using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System;

public class GameInterface : IDisplayable
{
    ConsoleColor backgroundColor = ConsoleColor.DarkYellow;
    ConsoleColor foregroundColor = ConsoleColor.DarkYellow;

    public string EnterName()
    {

        System.Console.WriteLine("Please enter your name player: ");
        string name = Console.ReadLine();

        Console.Write("Hello {0} ", name);
        return name;
    }

    public void WelcomePlayer()
    {
        Console.BackgroundColor = backgroundColor;
        Console.ForegroundColor = foregroundColor;

        System.Console.WriteLine("Welcome to the deepest forest in Rodopa near village Zornitsa, bewear of bears ;) Here two teams will fight for tressure hidden in the woods. The Great Damadjana");

        Console.ResetColor();
    }


    public void DisplayTeams(Team yourTeam, Team botTeam)
    {
        Console.BackgroundColor = backgroundColor;
        Console.ForegroundColor = foregroundColor;

        System.Console.WriteLine("Your team wiil face the keepers of the Damadjana. Your fighter are gathering...");
        Thread.Sleep(3000);

        System.Console.WriteLine("Here they are:");
        System.Console.Write(yourTeam);
        Thread.Sleep(3000);

        System.Console.WriteLine("The keeper's team are: ");
        System.Console.WriteLine(botTeam);
        Console.ResetColor();
    }

    public void AtackReceived()
    {
        //
    }

    public void DisplayTeams()
    {
        throw new System.NotImplementedException();
    }

    public void ShowRoundSummary()
    {
        throw new System.NotImplementedException();
    }

    public void BattleBegin()
    {
        throw new NotImplementedException();
    }

    public void ShowWinner()
    {
        throw new NotImplementedException();
    }

    public void NewGame()
    {
        throw new NotImplementedException();
    }
}