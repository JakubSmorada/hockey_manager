namespace hockey_manager.classes;

class ForwardPlayer : HockeyPlayer
{
    private int goals;

    public ForwardPlayer(string name, int age, int goals) : base(name, age)
    {
        this.goals = goals;
    }

    public int Goals
    {
        get
        {
            return goals;
        }

        set
        {
            goals = value;
        }
    }
}