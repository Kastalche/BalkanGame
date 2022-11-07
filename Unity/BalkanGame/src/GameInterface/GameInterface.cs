using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
public class GameInterface:IDisplayable{
    

    public string EnterName(){

        System.Console.WriteLine("Please enter your name player: ");
        string name = Console.ReadLine();

        Console.Write("Hello {0} ", name)
        return name;
    }
    
    public void WelcomePlayer(){
        Console.BackgroundColor=brown;
        Console.ForegroundColor=black;

        System.Console.WriteLine("Welcome to the deepest forest in Rodopa near village Zornitsa, bewear of bears ;) Here two teams will fight for tressure hidden in the woods. The Great Damadjana");

        Console.ResetColor();
    }


    public void DisplayTeams(Team yourTeam, Team botTeam){
        Console.BackgroundColor=brown;
        Console.ForegroundColor=black;

        System.Console.WriteLine("Your team wiil face the keepers of the Damadjana. Your fighter are gathering...");
        Thread.Sleep(3000);

        System.Console.WriteLine("Here they are:");
        System.Console.Write(team);
        Thread.Sleep(3000);

        System.Console.WriteLine("The keeper's team are: "));
        System.Console.WriteLine(team2);
        Console.ResetColor();
    }

    public void AtackReceived()
    {
        //
    }


}