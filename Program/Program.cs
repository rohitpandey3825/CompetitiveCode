using System;
using Problem.Interface;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseType = ConnectorsFactory.CreateConnectorType("Calander");
            Console.WriteLine("Initialized connecter with lazy");
            var calander = baseType.Value.GetConnection("Google");
            calander.ConnectUser("Batroc");
            Console.WriteLine(calander.GetGonnectionString());
            calander.refreshToken();
            Console.WriteLine(calander.GetGonnectionString());
            Console.WriteLine();

            baseType = ConnectorsFactory.CreateConnectorType("Confrencing");
            Console.WriteLine("Initialized connecter with lazy");
            calander = baseType.Value.GetConnection("Google");
            calander.ConnectUser("Batroc");
            Console.WriteLine(calander.GetGonnectionString());
            calander.refreshToken();
            Console.WriteLine(calander.GetGonnectionString());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
