namespace hockey_manager.classes;

class DefenderPlayer: HockeyPlayer
{
    private int hits;

    public DefenderPlayer(string name, int age, int hits) : base(name, age)
    {
        this.hits = hits;
    }

    public int Hits
    {
        get
        {
            return hits;
        }

        set
        {
            hits = value;
        }
    }
    
}