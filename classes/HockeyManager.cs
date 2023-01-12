namespace hockey_manager.classes;

public class HockeyManager
{
    private readonly List<HockeyPlayer> _hockeyPlayers = new(); 

    public void AddNewForward(string name, int age, int goals)
    {
        _hockeyPlayers.Add(new ForwardPlayer(name, age, goals));
    }

    public void AddNewDefender(string name, int age, int hits)
    {
        _hockeyPlayers.Add(new DefenderPlayer(name, age, hits));
    }

    public void AddNewGoalie(string name, int age, int wins)
    {
        _hockeyPlayers.Add(new GoaliePlayer(name, age, wins));
    }

    public void PrintNameAndAgeOfTheYoungestPlayer()
    {
        if (_hockeyPlayers.Count == 0)
        {
            Console.WriteLine("Not enough players!");
            return;
        }
        
        var youngestAge = _hockeyPlayers.First().Age;
        var youngestName = _hockeyPlayers.First().Name;
        
        foreach (var h in _hockeyPlayers)
        {
            var currentAge = h.Age;

            if (currentAge < youngestAge)
            {
                youngestAge = currentAge;
                youngestName = h.Name;
            }
        }
        
        Console.WriteLine(youngestName + ", " + youngestAge);
    }
}