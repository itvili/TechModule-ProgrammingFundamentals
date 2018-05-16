using System;
using System.Collections.Generic;
using System.Linq;

namespace _09TeamworkProjects
{
    class Program
    {
        class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }
        }
        static void Main()
        {
            int numbersOfTeam = int.Parse(Console.ReadLine());
            List<Team> teamsList = new List<Team>();
            Dictionary<string, Team> totalTeams = new Dictionary<string, Team>();

            for (int i = 0; i < numbersOfTeam; i++)
            {
                var registerTeam = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string teamCreator = registerTeam[0];
                string teamName = registerTeam[1];

                Team team = new Team();
                team.Name = teamName;
                team.Creator = teamCreator;
                team.Members = new List<string>();

                if (teamsList.Any(x=>x.Name == teamName))
                {
                    Console.WriteLine("Team {0} was already created!",teamName );
                    continue;
                }
                if (teamsList.Any(x=>x.Creator==teamCreator))
                {
                    Console.WriteLine("{0} cannot create another team!", teamCreator);
                    continue;
                }

                teamsList.Add(team);

                Console.WriteLine("Team {0} has been created by {1}!", teamName,teamCreator);
            }
            string member = "";

            while (member!= "end of assignment")
            {

                var membersInput = Console.ReadLine()
                   .Split(new[] { '-','>' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
                member = membersInput[0];
                if (member== "end of assignment")
                {
                    break;
                }
                string teamToJoin = membersInput[1];

                if (!teamsList.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                    continue;
                }
                if (teamsList.Any(x=>x.Creator==member)|| teamsList.Any(x=>x.Members.Contains(member)))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", member, teamToJoin);
                    continue;
                }
                foreach (var item in teamsList)
                {
                   
                    if (item.Name == teamToJoin)
                    {
                        item.Members.Add(member);
                    }
                    
                }
            }

            foreach (var item in teamsList.OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.Name))
            {
                if (item.Members.Count > 0)
                {

                    Console.WriteLine("{0}", item.Name);
                    Console.WriteLine("- {0}", item.Creator);

                    foreach (var memb in item.Members.OrderBy(x=>x))
                    {
                        Console.WriteLine("-- {0}", memb);
                    }
                }
               
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsList.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                if (item.Members.Count == 0)
                {

                 Console.WriteLine("{0}", item.Name);
                }
            }

        }
    }
}
