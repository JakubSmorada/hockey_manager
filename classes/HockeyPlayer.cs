namespace hockey_manager.classes;

abstract class HockeyPlayer
{
    private string name;
    private int age;

    protected HockeyPlayer(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    
    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }
    
}