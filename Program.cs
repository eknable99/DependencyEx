using System;

namespace DependencyEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new ConsoleNotification();

            var user1 = new User("Tim", notificationService);
            user1.ChangeUsername("Robert");

            Console.ReadKey();
        }
    }
}
