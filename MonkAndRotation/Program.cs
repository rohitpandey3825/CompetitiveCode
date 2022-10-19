//using System;
//using System.Collections.Generic;
//using Helper.IO;
//using System.Linq;


//class Program
//{
//    private static ConsoleReader Console = new ConsoleReader("MonkAndRotation");
//    public static string Csv(string csvFileContent)
//    {
//        Dictionary<string, List<string>> dict = StringToCsv(csvFileContent);
//        csvFileContent = DictToCsv(dict);
//        return csvFileContent;
//    }
//    public static Dictionary<string, List<string>> StringToCsv(string csvFileContent)
//    {
//        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
//        string[] lines = csvFileContent.Split("\n");
//        string[] colums = lines[0].Split(';');
//        for (int i = 0; i < lines.Length; i++)
//        {
//            string[] columnsLine = lines[i].Split(';');
//            for (int j = 0; j < columnsLine.Length; j++)
//            {
//                if (i == 0)
//                {
//                    dict[colums[j]] = new List<string>();
//                }
//                dict[colums[j]].Add(columnsLine[j]);
//            }
//        }
//        return dict;
//    }
//    public static string DictToCsv(Dictionary<String, List<String>> dict)
//    {
//        string output = "";
//        List<string> skeys = dict.Keys.OrderBy(x => x).ToList();
//        string[] lines = new string[dict[skeys[0]].Count];
//        foreach (string key in skeys)
//        {
//            for (int i = 0; i < dict[key].Count; i++)
//            {
//                if (String.IsNullOrEmpty(lines[i]))
//                {
//                    lines[i] = "";
//                }
//                else
//                {
//                    lines[i] += ";";
//                }
//                lines[i] += dict[key][i];
//            }
//        }
//        foreach (string line in lines)
//        {
//            output = output + (String.IsNullOrEmpty(output) ? "" : "\n") + line;
//        }
//        return output;
//    }


//    static void Main(string[] args)
//    {
//        string preSorting = "myjinxin2015;raulbc777;smile67;Dentzil;SteffenVogel_79\n"
//                  + "17945;10091;10088;3907;10132\n"
//                  + "2;12;13;48;11";
//        Csv(preSorting);
//    }
//}
////{

////    // ******************Code block******************
////    try
////    {
////        int T = Convert.ToInt32(Console.ReadLine());
////        for (int i = 0; i < T; i++)
////        {
////            string origstr = Console.ReadLine();
////            origstr.Length
////            int N = Convert.ToInt32(origstr.Split(' ')[0]);
////            int K = Convert.ToInt32(origstr.Split(' ')[1]);
////            int k = K % N;
////            if (k > 0)
////            {
////                string newstr = Console.ReadLine();
////                string sp1 = newstr.Substring(0, 2 * (N - k) - 1);
////                string sp2 = newstr.Substring(2 * (N - k));

////                Console.WriteLine(sp2 + " " + sp1);
////            }
////            else
////            {
////                Console.WriteLine(origstr);
////            }
////        }
////    }
////    catch (Exception ex)
////    {
////        Console.WriteLine(ex.ToString());
////    }
////    // ******************Copy till here******************
////    // ******************OR delete below lines******************
////    finally
////    {
////        Console.Dispose();
////    }


