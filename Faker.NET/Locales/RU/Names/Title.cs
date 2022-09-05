using Faker.NET.Common;

namespace Faker.NET.Locales.RU.Names
{
    internal class Title : IFakerText
    {
        public new string Get()
        {
            return $"{Descriptor[Randomizer.Next(Descriptor.Count)]} {Level[Randomizer.Next(Level.Count)]} {Job[Randomizer.Next(Job.Count)]}";
        }

        public List<string> Descriptor = new()
        {
            "Ведущий",
            "Генеральный",
            "Главный",
            "Глобальный",
            "Международный",
            "Национальный",
            "Областной",
            "Районный",
            "Региональный",
            "Центральный",
        };

        public List<string> Level = new()
        {
            "интеграционный",
            "логистический",
            "маркетинговый",
            "оптимизационный",
            "страховой",
            "функциональный",
            "коммуникационный",
            "операционный",
        };

        public List<string> Job = new()
        {
            "агент",
            "администратор",
            "аналитик",
            "архитектор",
            "дизайнер",
            "инженер",
            "консультант",
            "координатор",
            "менеджер",
            "планировщик",
            "помощник",
            "разработчик",
            "руководитель",
            "сотрудник",
            "специалист",
            "техник",
        };
    }
}
