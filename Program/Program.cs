using System;
using Helper.IO;

namespace Problem
{
    class Program
    {
        private static ConsoleReader Console = new ConsoleReader("Problem");

        static void Main(string[] args)
        {

            // ******************Code block******************
            try
            {
                MainSubstitute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // ******************Copy till here******************
            // ******************OR delete below lines******************
            finally
            {
                Console.Dispose();
            }
        }

        static void MainSubstitute()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string origstr = Console.ReadLine();
                int N = Convert.ToInt32(origstr.Split(' ')[0]);
                int K = Convert.ToInt32(origstr.Split(' ')[1]);


            }
        }
    }
}
