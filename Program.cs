using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kişiler = new MyDictionary<int, string>();
            kişiler.Add(1, "Ali");
            kişiler.Add(2, "Engin");
            kişiler.Add(3, "Yavuz");
            kişiler.Add(4, "Derin");
            kişiler.Add(5, "Ahmet");
            kişiler.Add(6, "Ayşe");
            
        }

    }
}
