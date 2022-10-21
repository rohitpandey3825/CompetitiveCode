using System;
using Problem.Interface;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseType = ConnectorsFactory.CreateConnectorType("Calander");
            var calander = baseType.GetConnection("Google");
            calander.ConnectUser("Batroc");
            Console.WriteLine(calander.GetGonnectionString());
            calander.refreshToken();
            Console.WriteLine(calander.GetGonnectionString());
            Console.WriteLine();

            baseType = ConnectorsFactory.CreateConnectorType("Confrencing");
            calander = baseType.GetConnection("Google");
            calander.ConnectUser("Batroc");
            Console.WriteLine(calander.GetGonnectionString());
            calander.refreshToken();
            Console.WriteLine(calander.GetGonnectionString());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
