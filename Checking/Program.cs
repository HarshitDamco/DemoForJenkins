using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("test".WordCount());

            A obj = new C(5);
            obj.show();
            Console.ReadLine();
        }
    }

    public class A
    {
        public virtual void show()
        {
            Console.WriteLine("Method A");
        }
    }

    class B : A
    {
        public sealed override void show()
        {
            Console.WriteLine("Method B");
        }
    }

    public class C : A
    {
        const int a1=2;
        readonly int a = 4;
        public C(int x)
        {
            Console.WriteLine(this.a);
            this.a = x;
        }
        public override void show()
        {
            Console.WriteLine(this.a);
        }

        public int? show1()
        {
            Console.WriteLine(this.a);
            return 1;
        }
    }

    public static class Extension
    {
        public static int WordCount(this string str)
        {
            string[] userString = str.Split(new char[] { ' ', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries);
            int wordCount = userString.Length;
            return wordCount;
        }
        public static int TotalCharWithoutSpace(this string str)
        {
            int totalCharWithoutSpace = 0;
            string[] userString = str.Split(' ');
            foreach (string stringValue in userString)
            {
                totalCharWithoutSpace += stringValue.Length;
            }
            return totalCharWithoutSpace;
        }
    }

}
