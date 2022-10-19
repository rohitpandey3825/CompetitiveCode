using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Provinces
{
    public int provinceId { get; set; }
    public List<Provinces> connected { get; set; }
    public List<Provinces> landconnected { get; set; }

    public bool isValidSet { get; set; }
    public Provinces(int i)
    {
        this.provinceId = i;
        this.connected = new List<Provinces>();
        this.landconnected = new List<Provinces>();
        this.isValidSet = true;
    }
    public void connectLand(Provinces p)
    {
        this.connect(p);
        this.landconnected.Add(p);
        this.landconnected.AddRange(p.connected);
        this.landconnected = this.connected.Distinct().ToList();
    }
    public void connect(Provinces p)
    {
        this.connected.Add(p);
        this.connected.AddRange(p.connected);
        this.connected = this.connected.Distinct().ToList();
    }
}

public class TestClass
{

    static void Main(string[] args)
    {
        try
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());
            for (int t_i = 0; t_i < T; t_i++)
            {
                int N = Convert.ToInt32(Console.ReadLine().Trim());
                int A = Convert.ToInt32(Console.ReadLine().Trim());
                int B = Convert.ToInt32(Console.ReadLine().Trim());
                int[,] land = new int[A, 2];
                for (int i_land = 0; i_land < A; i_land++)
                {
                    String[] arr_land = Console.ReadLine().Split(" ");
                    for (int j_land = 0; j_land < arr_land.Length; j_land++)
                    {
                        land[i_land, j_land] = Convert.ToInt32(arr_land[j_land]);
                    }
                }
                int[,] water = new int[B, 2];
                for (int i_water = 0; i_water < B; i_water++)
                {
                    String[] arr_water = Console.ReadLine().Split(" ");
                    for (int j_water = 0; j_water < arr_water.Length; j_water++)
                    {
                        water[i_water, j_water] = Convert.ToInt32(arr_water[j_water]);
                    }
                }

                int out_ = solve(N, A, B, land, water);
                Console.WriteLine("" + out_);

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
     
    }
    static int solve(int N, int A, int B, int[,] land, int[,] water)
    {
        // Write your code here
        Provinces[] provinces = new Provinces[N];
        for (int i = 0; i < N; i++)
        {
            provinces[i] = new Provinces(i + 1);
        }
        List<Provinces> availableProvinces = new List<Provinces>(provinces);

        for (int i = 0; i < A; i++)
        {
            Provinces parent, child;
            bool childIsAParent=false;
            if (land[i, 0] <= land[i, 1])
            {
                parent = availableProvinces.Where(x => x.provinceId == land[i, 0]).FirstOrDefault();
                if(parent == null)
                {
                    parent= availableProvinces.Where(x=>x.landconnected.Where(y=>y.provinceId == land[i, 0]).Count()>0).First();
                }
                child = availableProvinces.Where(x => x.provinceId == land[i, 1]).FirstOrDefault();
                if (child == null)
                {
                    child = availableProvinces.Where(x => x.landconnected.Where(y => y.provinceId == land[i, 1]).Count() > 0).First();
                    childIsAParent = true;
                }
            }
            else
            {
                parent = availableProvinces.Where(x => x.provinceId == land[i, 1]).FirstOrDefault();
                if (parent == null)
                {
                    parent = availableProvinces.Where(x => x.landconnected.Where(y => y.provinceId == land[i, 1]).Count() > 0).First();
                }
                child = availableProvinces.Where(x => x.provinceId == land[i, 0]).FirstOrDefault();
                if (child == null)
                {
                    child = availableProvinces.Where(x => x.landconnected.Where(y => y.provinceId == land[i, 0]).Count() > 0).First();
                    childIsAParent = true;
                }
            }
            if (child != parent)
            {
                if (!childIsAParent || availableProvinces.Contains(child)) availableProvinces.Remove(child);
                parent.connectLand(child);
            }
        }
        List<Provinces> allProvinces = new List<Provinces>(provinces);

        for (int i = 0; i < B; i++)
        {
            Provinces parent, child;
            if (water[i, 0] <= water[i, 1])
            {
                parent = allProvinces.Where(x => x.provinceId == water[i, 0]).First();
                child = allProvinces.Where(x => x.provinceId == water[i, 1]).First();
            }
            else
            {
                parent = allProvinces.Where(x => x.provinceId == water[i, 1]).First();
                child = allProvinces.Where(x => x.provinceId == water[i, 0]).First();
            }

            parent.connect(child);
        }

        for (int i = 0; i < B; i++)
        {
            List<Provinces> waterconnect = availableProvinces.Where(x => (!x.isValidSet) || (x.provinceId == water[i, 0] && x.connected.Where(y => y.provinceId == water[i, 1]).Count() > 0)
                || (x.provinceId == water[i, 1] && x.connected.Where(y => y.provinceId == water[i, 0]).Count() > 0)
                || (x.connected.Where(y => y.provinceId == water[i, 0]).Count() > 0 && x.connected.Where(y => y.provinceId == water[i, 1]).Count() > 0)).
                ToList();
                waterconnect.ForEach(x => x.isValidSet = false);
        }

        availableProvinces = availableProvinces.Where(x => x.isValidSet).ToList();
        if (availableProvinces.Count <= 0)
            return 0;
        else
        {
            int max = 0;
            foreach (var item in availableProvinces)
            {
                if (item.connected.Count() > max)
                {
                    max = item.connected.Count();
                }
            }
            return max + 1;
        }
    }
}
