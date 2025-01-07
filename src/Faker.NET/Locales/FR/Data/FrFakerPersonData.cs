using Faker.NET.Common;
using Faker.NET.Common.Person;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.FR.Data
{
    internal class FrFakerPersonData : IFakerPersonDefinition
    {
        public string[] BioPart => throw new NotImplementedException();

        public string[] BioPattern => throw new NotImplementedException();

        public string[] BioSupporter => throw new NotImplementedException();

        public SexSpecificValues<string> FirstName { get; } = new SexSpecificValues<string>
        {
            Unisex = new string[]
    {
        "Alexis", "Andréa", "Camille", "Claude", "Dominique", "Émilien", "Florian", "Gabriel",
        "Jean", "Julien", "Laurent", "Léo", "Luc", "Maël", "Manon", "Marine", "Maxime", "Morgan",
        "Nicolas", "Noël", "Patrice", "Quentin", "Raphaël", "René", "Robin", "Sacha", "Sam", "Samuel",
        "Simon", "Stéphane", "Sylvain", "Théo", "Thomas", "Valentin", "Valérie", "Victor", "Vincent",
        "Xavier", "Yann", "Adrien", "Albéric", "Aurélien", "Bastien", "Benoît", "Clément", "Corentin",
        "Damien", "David", "Denis", "Dorian", "Édouard", "Émeric", "Fabien", "Félix", "Gauthier",
        "Gérald", "Guillaume", "Hugo", "Igor", "Jacques", "Joël", "Jules", "Kevin", "Loïc", "Ludovic",
        "Marc", "Mathias", "Nathan", "Noé", "Olivier", "Paul", "Pierre", "Rémi", "Rémy", "Rodrigue",
        "Romain", "Thibault", "Timothée", "Tristan", "Ulysse", "Vianney", "Yves", "Yvan", "Zacharie",
        "Zéphyr", "Adrienne", "Aline", "Amory", "Audrey", "Bénédicte", "Céleste", "Charlie", "Dani",
    },
            Female = new string[]
    {
        "Adèle", "Amélie", "Anaïs", "Angèle", "Antoinette", "Ariane", "Aurélie", "Axelle", "Bérénice",
        "Camille", "Carine", "Catherine", "Chantal", "Charlotte", "Christelle", "Christine", "Claire",
        "Clémence", "Colette", "Coralie", "Delphine", "Élodie", "Émilie", "Estelle", "Eugénie",
        "Fabienne", "Fanny", "Florence", "Françoise", "Geneviève", "Hélène", "Inès", "Isabelle",
        "Jacqueline", "Jeanne", "Joséphine", "Julie", "Juliette", "Laetitia", "Laurence", "Léa",
        "Léna", "Liliane", "Louise", "Madeleine", "Manon", "Margaux", "Marguerite", "Marie", "Marina",
        "Martine", "Mathilde", "Mélanie", "Michèle", "Monique", "Myriam", "Nadine", "Nathalie", "Nicole",
        "Odette", "Odile", "Olivia", "Patricia", "Paulette", "Pauline", "Renée", "Rosalie", "Sabine",
        "Sandra", "Sarah", "Sophie", "Stéphanie", "Suzanne", "Sylvie", "Thérèse", "Valérie", "Véronique",
        "Victoire", "Yvette", "Yvonne", "Zoé", "Édith", "Éliane", "Élisabeth", "Élise", "Éloïse",
    },
            Male = new string[]
    {
        "Adrien", "Alain", "Alexandre", "Antoine", "Arnaud", "Aurélien", "Baptiste", "Benoît", "Bernard",
        "Charles", "Christophe", "Claude", "Clément", "Damien", "Daniel", "David", "Denis", "Didier",
        "Édouard", "Émile", "Étienne", "Fabien", "Félix", "Florian", "François", "Frédéric", "Gabriel",
        "Georges", "Gérard", "Gilbert", "Gilles", "Guillaume", "Henri", "Hervé", "Hugo", "Jacques",
        "Jean", "Jérôme", "Joël", "Joseph", "Julien", "Laurent", "Louis", "Luc", "Lucas", "Marc",
        "Mathieu", "Matthieu", "Maurice", "Maxime", "Michel", "Nicolas", "Noël", "Olivier", "Pascal",
        "Patrick", "Paul", "Philippe", "Pierre", "Quentin", "Raphaël", "Raymond", "Rémi", "René",
        "Richard", "Robert", "Romain", "Sébastien", "Simon", "Stanislas", "Stéphane", "Sylvain", "Théodore",
        "Thibault", "Thierry", "Thomas", "Timothée", "Tristan", "Valentin", "Victor", "Vincent", "Wilfried",
        "Xavier", "Yann", "Yves", "Zacharie", "Édouard", "Émeric", "Éric", "Évariste", "Évrard",
    },
        };

        public string[] Gender => throw new NotImplementedException();

        public string[] JobArea => throw new NotImplementedException();

        public string[] JobDescriptor => throw new NotImplementedException();

        public string[] JobTitlePattern => throw new NotImplementedException();

        public string[] JobType => throw new NotImplementedException();

        public SexSpecificValues<string> LastName { get; } = new SexSpecificValues<string>
        {
            Unisex = new string[]
            {
                "Martin", "Bernard", "Dubois", "Thomas", "Robert", "Richard", "Petit", "Durand",
                "Leroy", "Moreau", "Simon", "Laurent", "Michel", "Garcia", "David", "Bertrand",
                "Roux", "Vincent", "Fournier", "Morel", "Girard", "André", "Mercier", "Dupont",
                "Lambert", "Bonnet", "François", "Martinez", "Legrand", "Garnier", "Faure", "Roussel",
                "Blanc", "Gauthier", "Perrin", "Morin", "Mathieu", "Clement", "Gillet", "Etienne",
                "Marchand", "Blanchard", "Brun", "Chevalier", "Clément", "Colin", "Fernandez", "Fabre",
                "Arnaud", "Dumas", "Joly", "Barbier", "Brunet", "Moulin", "Jacquet", "Guichard",
                "Rolland", "Humbert", "Perrot", "Giraud", "Pons", "Gaillard", "Germain", "Boyer",
                "Adam", "Chevallier", "Noël", "Renaud", "Boucher", "Guillon", "Roy", "Lopez",
                "Pierre", "Jacques", "Meunier", "Dupuis", "Olivier", "Rodriguez", "Gonzalez", "Pascal",
                "Navarro", "Delmas", "Laborde", "Caron", "Deschamps", "Chartier", "Bouchet", "Philippe",
                "Langlois", "Aubry", "Legendre", "Lemoine", "Marin", "Vidal", "Teixeira", "Perret",
            },
        };

        public WeightedList<string> LastNamePattern { get; } = new WeightedList<string>(new Dictionary<string, int>
        {
            { "{{person.LastName}}", 1 }
        });

        public SexSpecificValues<string> MiddleName => FirstName;

        public WeightedList<Func<string>> Name => throw new NotImplementedException();

        public SexSpecificValues<string> Prefix { get; } = new SexSpecificValues<string>
        {
            Unisex = new string[]
            {
                "Dr.", "Mx.", "Prof.", "Me", "Pr."
            },
            Female = new string[]
            {
                "Mme.", "Mlle.", "Dre.", "Prof.", "Me"
            },
            Male = new string[]
            {
                "M.", "Dr.", "Prof.", "Mgr.", "Me"
            }
        };

        public string[] Suffix => throw new NotImplementedException();

        public string[] ZodiacSign => throw new NotImplementedException();
    }
}
