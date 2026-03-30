
internal class TeamsCreator
{
    public string User { get; set; }

    public string Team { get; set; }

    public List<string> Members { get; set; }

    public TeamsCreator(string user, string team)
    {
        User = user;
        Team = team;
        Members = new List<string>();
    }


}

