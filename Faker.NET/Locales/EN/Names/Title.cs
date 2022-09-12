using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Names
{
    internal class Title : FakerText
    {
        public new string Get()
        {
            return $"{Descriptor[Randomizer.Next(Descriptor.Count)]} {Level[Randomizer.Next(Level.Count)]} {Job[Randomizer.Next(Job.Count)]}";
        }

        public List<string> Descriptor = new()
        {
            "Lead",
            "Senior",
            "Direct",
            "Corporate",
            "Dynamic",
            "Future",
            "Product",
            "National",
            "Regional",
            "District",
            "Central",
            "Global",
            "Customer",
            "Investor",
            "Dynamic",
            "International",
            "Legacy",
            "Forward",
            "Internal",
            "Human",
            "Chief",
            "Principal",
        };
        public List<string> Level = new()
        {
            "Solutions",
            "Program",
            "Brand",
            "Security",
            "Research",
            "Marketing",
            "Directives",
            "Implementation",
            "Integration",
            "Functionality",
            "Response",
            "Paradigm",
            "Tactics",
            "Identity",
            "Markets",
            "Group",
            "Division",
            "Applications",
            "Optimization",
            "Operations",
            "Infrastructure",
            "Intranet",
            "Communications",
            "Web",
            "Branding",
            "Quality",
            "Assurance",
            "Mobility",
            "Accounts",
            "Data",
            "Creative",
            "Configuration",
            "Accountability",
            "Interactions",
            "Factors",
            "Usability",
            "Metrics",
        };
        public List<string> Job = new()
        {
            "Supervisor",
            "Associate",
            "Executive",
            "Liaison",
            "Officer",
            "Manager",
            "Engineer",
            "Specialist",
            "Director",
            "Coordinator",
            "Administrator",
            "Architect",
            "Analyst",
            "Designer",
            "Planner",
            "Orchestrator",
            "Technician",
            "Developer",
            "Producer",
            "Consultant",
            "Assistant",
            "Facilitator",
            "Agent",
            "Representative",
            "Strategist",
        };
    }
}
