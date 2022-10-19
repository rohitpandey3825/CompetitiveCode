//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class RangeString
//{
//    public int L { get; set; }
//    public int R { get; set; }
//    public bool isGoodString { get; set; }

//    Dictionary<char, int> _data = new Dictionary<char, int>();
//    public RangeString()
//    {
//        this.isGoodString = true;
//        char[] keys = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
//        foreach (var item in keys)
//        {
//            _data[item] = 0;
//        }
//    }

//    public void populateDict(string s)
//    {
//        char[] sChar = s.Substring(L, R - L + 1).ToCharArray();
//        foreach (var item in sChar)
//        {
//            this._data[item]++;
//        }
//        findIsGoodString();
//    }

//    public void decrese(char c)
//    {
//        if (isGoodString) return;
//        this._data[c]--;
//        findIsGoodString();
//    }

//    public bool findIsGoodString()
//    {
//        this.isGoodString = !_data.Any(x => x.Value >= 2);
//        return this.isGoodString;
//    }
//}

//public class Goodstring
//{

//    static void Main(string[] args)
//    {
//        try
//        {
//            int T = Convert.ToInt32(Console.ReadLine().Trim());
//            for (int t_i = 0; t_i < T; t_i++)
//            {
//                string[] line = Console.ReadLine().Split(" ");
//                int N = Convert.ToInt32(line[0]);
//                int Q = Convert.ToInt32(line[1]);
//                string S = Console.ReadLine().ToUpper();
//                string[] arr_arr = Console.ReadLine().Split(" ");
//                int[] arr = new int[N];
//                for (int i_arr = 0; i_arr < arr_arr.Length; i_arr++)
//                {
//                    arr[i_arr] = Convert.ToInt32(arr_arr[i_arr]);
//                }
//                int[,] ranges = new int[Q, 2];
//                for (int i_ranges = 0; i_ranges < Q; i_ranges++)
//                {
//                    string[] arr_ranges = Console.ReadLine().Split(" ");
//                    for (int j_ranges = 0; j_ranges < arr_ranges.Length; j_ranges++)
//                    {
//                        ranges[i_ranges, j_ranges] = Convert.ToInt32(arr_ranges[j_ranges]);
//                    }
//                }

//                int out_ = goodstring(N, Q, S, arr, ranges);
//                Console.WriteLine("" + out_);

//            }
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e.ToString());
//        }
//    }
//    static int goodstring(int N, int Q, string S, int[] arr, int[,] ranges)
//    {
//        // Write your code here
//        char[] sChar = S.ToCharArray();

//        RangeString[] rangeStrings = new RangeString[Q];
//        for (int i = 0; i < Q; i++)
//        {
//            rangeStrings[i] = new RangeString() { L = ranges[i, 0] - 1, R = ranges[i, 1] - 1 };
//            rangeStrings[i].populateDict(S);
//        }

//        int count = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (rangeStrings.All(x => x.isGoodString))
//                return count;
//            else
//            {
//                int pos = arr[i] - 1;
//                rangeStrings.Where(x => !x.isGoodString && x.L <= pos && pos <= x.R).ToList().ForEach(x => x.decrese(sChar[pos]));
//            }
//            count++;
//        }

//        return count;
//    }
//}