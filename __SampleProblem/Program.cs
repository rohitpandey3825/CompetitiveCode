using System;
using Helper.IO;
namespace SampleProblem
{
    class Program
    {
        // dotnet new console -n MonkAndRotation    
        // dotnet sln add .\MonkAndRotation\MonkAndRotation.csproj
        //


        private static ConsoleReader Console = new ConsoleReader("Sample");

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("hello Monk");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            finally
            {
                Console.Dispose();
            }
        }
    }
}
