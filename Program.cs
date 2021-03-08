using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("-----------------");

            // Team Member's Name
            Console.WriteLine("Enter a team member's name.");
            string name = Console.ReadLine();

            // Team Member's Skill Level
            Console.WriteLine("What's their skill level (Between 1 - 10) ?");
            string stringSkillLevel = Console.ReadLine();

            int skillLevel;

            int.TryParse(stringSkillLevel, out skillLevel);

            // Team Member's Courage Factor
            Console.WriteLine("What's their courage factor? (Between 0.0 - 2.0)");
            string stringCourageFactor = Console.ReadLine();

            decimal courageFactor;

            decimal.TryParse(stringCourageFactor, out courageFactor);

            TeamMember newTeamMember = new TeamMember(name, skillLevel, courageFactor);

            Console.WriteLine(newTeamMember.GetProfile());




        }
    }
}
