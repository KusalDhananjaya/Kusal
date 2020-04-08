using System;

namespace ConsoleApp1
{


    public sealed class Australia
    {
        private static readonly Australia a1 = new Australia("Aaron Finch");
     
        private Australia(string captain)
        {
            Console.WriteLine("Captain of Australia is {0}",captain);
        }
        public static Australia Instance
        {
            get
            {
                return a1;
            }
        }

       
    }
    public sealed class England
    {
        private static readonly England e1 = new England("Joe Root");
        private England(string captain)
        {
            Console.WriteLine("Captain of England is {0}", captain);
        }
        public static England Instance
        {
            get
            {
                return e1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Australia a1 = Australia.Instance;
            Australia a2 = Australia.Instance;//Though we have 2 objects here we only get the Name "aaron finch" as result. so this ensures that this class can only have 1 instance
            England e1 = England.Instance;
            England e2 = England.Instance;//so it is same with England too
        }
    }
}

