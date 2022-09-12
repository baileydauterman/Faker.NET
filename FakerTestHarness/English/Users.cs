using Faker.NET.EN.Account;

namespace FakerTestHarness.English
{
    public static class Users
    {
        public static void Test()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(User.NewAccount);
            }
        }
    }
}
