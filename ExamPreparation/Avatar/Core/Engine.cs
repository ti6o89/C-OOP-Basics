using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private bool IsRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.IsRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }
    
    public void Run()
    {        
        while (IsRunning)
        {
            string inputCommand = Console.ReadLine();
            List<string> commandParameters = inputCommand.Split().ToList();
            this.DistributeCommnad(commandParameters);
        }
    }

    private void DistributeCommnad(List<string> commandParameters)
    {
        var command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command)
        {
            case "Bender":
                this.nationsBuilder.AssignBender(commandParameters);
                break;

            case "Monument":
                this.nationsBuilder.AssignMonument(commandParameters);
                break;

            case "Status":
                var status = this.nationsBuilder.GetStatus(commandParameters[0]);
                this.OutputWriter(status);
                break;

            case "War":
                this.nationsBuilder.IssueWar(commandParameters[0]);
                break;

            case "Quit":
                var record = this.nationsBuilder.GetWarsRecord();
                this.OutputWriter(record);
                IsRunning = false;
                break;

        }
    }

    private void OutputWriter(string status)
    {
        Console.WriteLine(status);
    }
}
