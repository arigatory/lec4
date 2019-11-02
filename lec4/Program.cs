using System;


namespace lec4
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            Complex c = new Complex(1, 5);

            Complex c2 = new Complex(3, 5);
            list.Add(c);
            list.Add(new Complex(2, 5));
            list.Add(c2);
            list.Add(new Complex(4, 5));
            list.Add(new Complex(5, 5));

            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            
            list.Remove(c);

            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Remove(c2);

            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();
        }
    }
}
