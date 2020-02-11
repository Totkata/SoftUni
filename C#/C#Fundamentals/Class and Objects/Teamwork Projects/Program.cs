using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            
            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string teamName = input[1];
                string creator = input[0];

                if (teams.Count == 0)
                {
                   teams.Add(new Team(teamName, creator));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else
                {
                    Team team = Team.CreateTeam(teamName, creator, teams);

                    if (team != null)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
            }
            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] splitedCommand = command.Split("->");

                if (TeamExists(splitedCommand[1], teams))
                {
                    if (!MemberExists(splitedCommand[0], teams))
                    {
                        foreach (var team in teams)
                        {
                            if (team.Name == splitedCommand[1])
                            {
                                team.Members.Add(splitedCommand[0]);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Member {splitedCommand[0]} cannot join team {splitedCommand[1]}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {splitedCommand[1]} does not exist!");
                }
                command = Console.ReadLine();
            }
            List<string> disbanedTeams = new List<string>();

            foreach (var team in teams)
            {
                if (team.Members.Count == 0)
                {
                    disbanedTeams.Add(team.Name);
                }
            }
            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (var team in teams)
            {
                if (team.Members.Count != 0)
                {
                    Console.WriteLine(team.ToString());
                }
            }

            disbanedTeams.Sort();
            Console.WriteLine($"Teams to disband:");
            foreach (var item in disbanedTeams)
            {
                Console.WriteLine($"{item}");
            }
        }
        public static bool TeamExists(string teamName, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Name == teamName)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool MemberExists(string member, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Members.Contains(member) || team.User == member)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Team
    {
        public Team(string name, string user)
        {
            Name = name;
            User = user;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string User { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name)
            .Append(Environment.NewLine)
            .Append($"- {User}")
            .Append(Environment.NewLine);

            Members.Sort();
            foreach (var item in Members)
            {
                sb.Append($"-- {item}")
                .Append(Environment.NewLine);
            }
            return sb.ToString().TrimEnd();
        }
        public static Team CreateTeam(string teamName, string creator , List<Team> teams)
        {
            Team team = null;

            if (TeamExists(teamName, teams))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                return null;
            }
            else if (CreatorExists(creator,teams))
            {
                Console.WriteLine($"{creator} cannot create another team!");
                return null;
            }
            team = new Team(teamName,creator);
            return team;
        }
        public static bool TeamExists(string teamName, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Name == teamName)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CreatorExists(string creator, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.User == creator)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
