using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.IO;
class Developers
{
    public Developers(int _id)
    {
        this.id = _id;
        contacts = new List<Developers>();
    }

    public int id { get; set; }
    public List<Developers> contacts { get; set; }

    public List<int> findContact(int id, List<Developers> parsed)
    {
        List<int> output = new List<int>();
        foreach (var item in this.contacts.Where(x => !parsed.Contains(x)))
        {
            parsed.Add(this);
            if (item.id == id || item.findContact(id, parsed.ToList()).Count() > 0)
            {
                output.Add(item.id);
            }
        }
        return output;
    }
}
class program
{
    private static ConsoleReader Console = new ConsoleReader("PracticeRound");

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<Developers> allDevelopers = new List<Developers>();
        for (int i = 0; i < N; i++)
        {
            allDevelopers.Add(new Developers(Convert.ToInt32(Console.ReadLine())));
        }
        int E = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < E; i++)
        {
            int[] inp = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            Developers dev1 = allDevelopers.First(x => x.id == inp[0]);
            Developers dev2 = allDevelopers.First(x => x.id == inp[1]);

            dev1.contacts.Add(dev2);
            dev2.contacts.Add(dev1);
        }
        int B = Convert.ToInt32(Console.ReadLine());
        int A = Convert.ToInt32(Console.ReadLine());
        Developers dev = allDevelopers.First(x => x.id == A);
        List<int> outp = dev.findContact(B, new List<Developers>()).OrderBy(x=>x).ToList();
        string output = "";
        foreach (var item in outp)
        {
            output = output + item + " ";
        }
        Console.WriteLine("" + output.Trim());

    }
}
