namespace Game;

public class MobileLegendPlayer : IPlayer, IOnlinePlayer
{
    public int GetID(int id)
    {
        return id;
    }


    public int GetLevel()
    {
        return 15;
    }

    public string GetName(string name)
    {
        return name;
    }


    public string GetUsername(string username)
    {
        return username;
    }

}
