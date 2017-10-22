using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
    }

    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value;}
    }

    public Dictionary<int, Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }

    public void AddParticipants(int id, Car car)
    {
        this.participants.Add(id, car);
    }

    public abstract int GetPerformance(int id);

    public Dictionary<int, Car> GetWiners()
    {
        var winers = this.Participants.OrderByDescending(p => this.GetPerformance(p.Key)).Take(3).ToDictionary(n => n.Key, m => m.Value);
        return winers;
    }

    public List<int> GetPrizes()
    {
        var result = new List<int>();

        result.Add((this.prizePool * 50) / 100);
        result.Add((this.prizePool * 30) / 100);
        result.Add((this.prizePool * 20) / 100);

        return result;
    }

    public string PrintWinners()
    {
        var winners = GetWiners();
        var prizes = GetPrizes();

        var sb = new StringBuilder();
        sb.Append($"{this.Route} - {this.Length}");

        for (int i = 0; i < winners.Count; i++)
        {
            sb.AppendLine();
            var car = winners.ElementAt(i);

            sb.Append($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
        }

        return sb.ToString();
    }
}
