using System;

namespace Anon_Methods
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mD = new MyDelegate(delegate { Console.WriteLine("Hello world!"); });
            mD(); 
        }
    }
}
