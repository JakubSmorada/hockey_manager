namespace hockey_manager.classes;

class GoaliePlayer: HockeyPlayer
{
    private int wins;

    public GoaliePlayer(string name, int age, int wins) : base(name, age)
    {
        this.wins = wins;
    }

    public int Wins
    {
        get
        {
            return wins;
        }

        set
        {
            wins = value;
        }
    }
}