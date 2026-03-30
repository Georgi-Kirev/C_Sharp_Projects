namespace _03._Teamwork_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TeamsCreator> teams = new List<TeamsCreator>();
            int teamCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamCount; i++)
            {
                string[] givenTeams = Console.ReadLine().Split("-");

                string givenUser = givenTeams[0];
                string givenTeam = givenTeams[1];

                bool userAlreadyCreatedTeam = teams.Any(t => t.User == givenUser);
                bool teamAlreadyExists = teams.Any(t => t.Team == givenTeam);

                if (userAlreadyCreatedTeam)
                {
                    Console.WriteLine($"{givenUser} cannot create another team!");
                    continue;
                }

                if (teamAlreadyExists)
                {
                    Console.WriteLine($"Team {givenTeam} was already created!");
                    continue;
                }

                TeamsCreator newTeam = new TeamsCreator(givenUser, givenTeam);
                teams.Add(newTeam);

                Console.WriteLine($"Team {givenTeam} has been created by {givenUser}!");
            }

            string newUser = Console.ReadLine();

            while (newUser != "end of assignment")
            {
                string[] userToBeAdded = newUser.Split("->");

                string userName = userToBeAdded[0];
                string teamToJoin = userToBeAdded[1];

                var team = teams.FirstOrDefault(t => t.Team == teamToJoin);

                if (team == null)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    bool alreadyInTeam =
                        teams.Any(t => t.User == userName || t.Members.Contains(userName));

                    if (alreadyInTeam)
                    {
                        Console.WriteLine($"Member {userName} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        team.Members.Add(userName);
                    }
                }

                newUser = Console.ReadLine();
            }

            var validTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Team);

            foreach (var team in validTeams)
            {
                Console.WriteLine($"{team.Team}");
                Console.WriteLine($"- {team.User}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Team))
            {
                Console.WriteLine(team.Team);
            }
        }


        // Място на което да поставиш кода от Файла TeamsCreator за да може да качиш кода!
        // Може и да хванеш файловете да ги архивираш и да ги подадеш така на Judge!


    }
}


