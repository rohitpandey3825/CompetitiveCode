using System;
using Problem.Factory;
using Problem.Interface;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var calanders = new DextopCalanderFactory().CreateCalanders();
            Console.WriteLine("Dextop");
            foreach (var calander in calanders)
            {
                calander.ConnectUser("Batroc");
                Console.WriteLine(calander.GetGonnectionString());
                calander.refreshToken();
                Console.WriteLine(calander.GetGonnectionString());
                Console.WriteLine();
            }

            Console.WriteLine("Moblie");
            var mobcalanders = new MobileCalandersFactory().CreateCalanders();

            foreach (var calander in mobcalanders)
            {
                calander.ConnectUser("Batroc");
                Console.WriteLine(calander.GetGonnectionString());
                calander.refreshToken();
                Console.WriteLine(calander.GetGonnectionString());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
