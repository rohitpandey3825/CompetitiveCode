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
                int T = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    string origstr = Console.ReadLine();
                    int N = Convert.ToInt32(origstr.Split(' ')[0]);
                    int K = Convert.ToInt32(origstr.Split(' ')[1]);
                    int k = K % N;
                    if (k > 0)
                    {
                        string newstr = Console.ReadLine();
                        string sp1 = newstr.Substring(0, 2 * (N - k) - 1);
                        string sp2 = newstr.Substring(2 * (N - k));

                        Console.WriteLine(sp2 + " " + sp1);
                    }
                    else
                    {
                        Console.WriteLine(origstr);
                    }
                }
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
    }
}
