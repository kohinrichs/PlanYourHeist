using System;

namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public decimal CourageFactor { get; set; }


        // Need a constructor to make instances of Team Member
        public TeamMember(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }


        public string GetProfile()
        {
            return $"Team member {Name} has a skill level of {SkillLevel} and a courage level of {CourageFactor}.";
        }
    }
}