//using system;
//using system.collections.generic;
//using helper.io;
//using system.linq;


//class program
//{
//    private static consolereader console = new consolereader("monkandrotation");

//    static void main(string[] args)
//    {

//    }
//}
//using system;
//using system.collections.generic;
//using system.linq;

//namespace monkandrotation
//{
//    class groupnum
//    {
//        public int value { get; set; }
//        public int count { get; set; }
//    }
//    class program
//    {
//        static void main(string[] args)
//        {
//            int n = convert.toint32(console.readline());
//            for (int i = 0; i < n; i++)
//            {
//                int t = convert.toint32(console.readline());
//                int output = calculatetotalmatch(t);
//                console.writeline(output);
//            }
//            args[1].split()
//        }

//        private static int calculatetotalmatch(int[] arr)
//        {
//            list<groupnum> grps = arr.groupby(x => x).select(x => new groupnum() { value = x.key, count = x.count() }).where(x => x.value == x.count).tolist();
//            if (grps.count > 0)
//                math.max
//            groupnum g = grps.orderbydescending(x => x.value).firstordefault().value;
//        }
//        private static consolereader console = new consolereader("monkandrotation");

//        static void main(string[] args)
//        {

//            // ******************code block******************
//            try
//            {
//                int t = convert.toint32(console.readline());
//                for (int i = 0; i < t; i++)
//                {
//                    string origstr = console.readline();
//                    int n = convert.toint32(origstr.split(' ')[0]);
//                    int k = convert.toint32(origstr.split(' ')[1]);
//                    int k = k % n;
//                    if (k > 0)
//                    {
//                        string newstr = console.readline();
//                        string sp1 = newstr.substring(0, 2 * (n - k) - 1);
//                        string sp2 = newstr.substring(2 * (n - k));

//                        console.writeline(sp2 + " " + sp1);
//                    }
//                    else
//                    {
//                        console.writeline(origstr);
//                    }
//                }
//            }
//            catch (exception ex)
//            {
//                console.writeline(ex.tostring());
//            }
//            // ******************copy till here******************
//            // ******************or delete below lines******************
//            finally
//            {
//                console.dispose();
//            }
//        }
//    }
//}
