using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.IO;

public class ProgramD1
{
    private static ConsoleReader Console = new ConsoleReader("PracticeRound");

    static void Main(string[] args)
    {
        try
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                int NRegions = Convert.ToInt32(line[0]);
                int MCatagoris = Convert.ToInt32(line[1]);
                float sum = 0;
                int start = 0;
                int[] regionStrength = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).OrderByDescending(x => x).ToArray();
                for (int j = 0; j < MCatagoris - 1; j++, start++)
                {
                    int top = regionStrength.FirstOrDefault();
                    sum = sum + top;
                }
                int Length = regionStrength.Length;
                if (start < Length)
                {
                    Length = Length - start;
                    if (Length % 2 == 0)
                        sum += ((float)regionStrength[start + Length / 2] + (float)regionStrength[start + (Length / 2) - 1]) / 2;
                    else
                        sum += regionStrength[start + Length / 2];
                }

                Console.WriteLine($"Case #{i + 1}: " + sum.ToString("0.0"));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        // ******************copy till here******************
        // ******************or delete below lines******************
        finally
        {
            Console.Dispose();
        }
    }
}
