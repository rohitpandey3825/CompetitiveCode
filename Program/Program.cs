using System;
using Problem.Factory;
using Problem.Interface;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalanders calanders = CalandersFactory.GetCalander("Google");

            if (calanders != null)
            {
                calanders.ConnectUser("Batroc");
                Console.WriteLine(calanders.GetGonnectionString());
                calanders.refreshToken();
                Console.WriteLine(calanders.GetGonnectionString());
            }
            else
            {
                Console.WriteLine("Invalid Calander");
            }

            Console.ReadKey();
        }
    }
}
