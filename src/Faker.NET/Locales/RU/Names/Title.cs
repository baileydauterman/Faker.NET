using Faker.NET.Common;

namespace Faker.NET.RU.Names
{
    internal class Title : FakerText
    {
        public override string Get(bool useAlternate)
        {
            if (useAlternate)
            {
                return $"{TranslatedDescriptor[Randomizer.Next(TranslatedDescriptor.Count)]} {TranslatedLevel[Randomizer.Next(TranslatedLevel.Count)]} {TranslatedJob[Randomizer.Next(TranslatedJob.Count)]}";
            }

            return $"{NativeDescriptor[Randomizer.Next(NativeDescriptor.Count)]} {NativeLevel[Randomizer.Next(NativeLevel.Count)]} {NativeJob[Randomizer.Next(NativeJob.Count)]}";
        }

        public List<string> NativeDescriptor = new()
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

        public List<string> TranslatedDescriptor = new()
        {
            "Leading",
            "General",
            "Chief",
            "Global",
            "International",
            "National",
            "Regional",
            "District",
            "Regional",
            "Central",
        };

        public List<string> NativeLevel = new()
        {
            "Интеграционный",
            "Логистический",
            "Маркетинговый",
            "Оптимизационный",
            "Страховой",
            "Функциональный",
            "Коммуникационный",
            "Операционный"
        };

        public List<string> TranslatedLevel = new()
        {
            "Integration",
            "Logistic",
            "Marketing",
            "Optimization",
            "Insurance",
            "Functional",
            "Communication",
            "Operational"
        };

        public List<string> NativeJob = new()
        {
            "Агент",
            "Администратор",
            "Аналитик",
            "Архитектор",
            "Дизайнер",
            "Инженер",
            "Консультант",
            "Координатор",
            "Менеджер",
            "Планировщик",
            "Помощник",
            "Разработчик",
            "Руководитель",
            "Сотрудник",
            "Специалист",
            "Техник",
        };

        public List<string> TranslatedJob = new()
        {
            "Agent",
            "Administrator",
            "Analyst",
            "Architect",
            "Designer",
            "Engineer",
            "Consultant",
            "Coordinator",
            "Manager",
            "Planner",
            "Assistant",
            "Developer",
            "Manager/Leader",
            "Employee",
            "Specialist",
            "Technician",
        };
    }
}
