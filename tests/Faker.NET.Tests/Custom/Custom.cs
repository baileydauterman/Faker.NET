using Faker.NET.Extensions;
using Faker.NET.Implementations;
using Faker.NET.Interfaces;
using NUnit.Framework.Internal;
using System.Globalization;

namespace Faker.NET.Tests.Custom
{
    internal class Custom
    {
        [Test]
        public void CreateCustom()
        {
            Faker.SetRandomizerSeed(10000);
            Faker.SetLocale(new CustomFaker());
            Assert.Multiple(() =>
            {
                Assert.That(Faker.Name.First, Is.EqualTo("Morgana"));
                Assert.That(Faker.Name.Last, Is.EqualTo("Stormrider"));
                Assert.That(Faker.Name.Full, Is.EqualTo("Azura Ashenbrook"));
                Assert.That(Faker.Name.Job, Is.EqualTo("Dragon Rider"));
                Assert.That(Faker.Name.Prefix, Is.EqualTo("Warden of the Crystal Veil"));
            });
        }
    }

    internal class CustomFaker : FakerLocaleInstance
    {
        public CustomFaker()
        {
            Name = new CustomName();
        }
    }

    internal class CustomName : IFakerName
    {
        public string First => _firstNames.GetRandom();

        public string Last => _lastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => _prefix.GetRandom();

        public string Job => _jobs.GetRandom();

        public string Email => throw new NotImplementedException();

        private string[] _firstNames = new string[]
        {
            "Aeliana",
            "Draven",
            "Seraphina",
            "Thorian",
            "Elowen",
            "Kaelar",
            "Lysandra",
            "Fenris",
            "Elara",
            "Thalric",
            "Calista",
            "Zephyr",
            "Azura",
            "Rhydian",
            "Selene",
            "Galadriel",
            "Valerian",
            "Isolde",
            "Lucius",
            "Morgana",
        };

        private string[] _lastNames = new string[]
        {
            "Stormrider",
            "Ironheart",
            "Shadowthorn",
            "Fireforge",
            "Moonshadow",
            "Frostbane",
            "Bloodraven",
            "Silvermoon",
            "Blackthorn",
            "Starfall",
            "Stormsword",
            "Nightshade",
            "Winterhawk",
            "Dragonheart",
            "Goldenvale",
            "Shadowcaster",
            "Ravenshadow",
            "Thundershield",
            "Emberstone",
            "Ashenbrook",
        };

        private string[] _jobs = new string[]
        {
            "Spellweaver",
            "Dragon Rider",
            "Potionmaster",
            "Monster Hunter",
            "Enchantress",
            "Seer or Oracle",
            "Bard or Minstrel",
            "Druid",
            "Alchemist",
            "Elemental Mage",
            "Beast Tamer",
            "Shadow Assassin",
            "Celestial Scholar",
            "Witchdoctor",
            "Runesmith",
            "Fey Ambassador",
            "Time Traveler",
            "Necromancer",
            "Astral Navigator",
            "Knight of the Crystal Order",
        };

        private string[] _prefix = new string[]
        {
            "The Dragon Slayer",
            "Lord/Lady of the Enchanted Woods",
            "The Ironclad Mage",
            "Keeper of the Lost Realms",
            "The Chosen One",
            "The Mystic Wanderer",
            "Captain of the Skyship",
            "The Shadowblade Assassin",
            "Guardian of the Sacred Grove",
            "The Elemental Conjuror",
            "Warden of the Crystal Veil",
            "The Stormcaller",
            "High Priest/Priestess of the Moon",
            "The Luminous Knight",
            "Archmage of the Arcane Order",
            "The Fey Ambassador",
            "The Soul Whisperer",
            "The Time Weaver",
            "The Cursed Sorcerer/Sorceress",
            "Herald of the Celestial Dawn",
        };
    }
}
