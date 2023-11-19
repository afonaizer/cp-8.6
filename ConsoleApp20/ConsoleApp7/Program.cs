using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        ////задача 1
        //static void Height()
        //{
        //    int[] height = new int[12];
        //    Random rnd = new Random();
        //    for (int i = 0; i < height.Length; i++)
        //    {
        //        height[i] = rnd.Next(163,190);
        //        Console.Write($"Рост {i+1} человека = {height[i]}\n");
        //    }
        //    int all = 0;
        //    for (int i = 0; i < height.Length; i++)
        //    {
        //        all = all+height[i];
        //    }
        //    int medium = all / height.Length;
        //    Console.Write($"Средний рост равен {medium}");
        //}

        //static void Main(string[] args)
        //{
        //    Height();
        //    Console.ReadKey();
        //}

        ////задача 2
        //static void Minmax()
        //{
        //    int[] omas = new int [8] {37,0,50,46,34,46,0,-13 };
        //    for (int i=0; i<omas.Length;i++)
        //    {
        //        Console.Write($"{omas[i]}\t");
        //    }
        //    int min = omas.Min();
        //    int max = omas.Max();
        //    Console.Write($"\nМинимальное значение = {min}\tМаксимальное значение = {max}");
        //}
        //static void Main(string[] args)
        //{
        //    Minmax();
        //    Console.ReadKey();
        //}

        ////задача 3
        //static void Reverse()
        //{
        //    int[] omas = new int[5];
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        Console.Write($"\nВведите {i+1} значение:");
        //        omas[i] = int.Parse(Console.ReadLine());
        //    }
        //    for (int i = omas.Length-1; i >= 0; i--)
        //    {
        //        Console.Write($"{omas[i]}\t");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Reverse();
        //    Console.ReadKey();
        //}

        ////задача 4
        //static void Double()
        //{

        //    int[] omas = new int[6];
        //    Random rnd = new Random();
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        omas[i] = rnd.Next(-5, 5);
        //        Console.Write($"omas{i} = {omas[i]}\n");
        //        omas[i] = omas[i] * 2;
        //    }
        //    foreach (int i in omas)
        //    {
        //        Console.Write($"{i}\t");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Double();
        //    Console.ReadKey();
        //}

        ////задача 5
        static void Marks()
        {
            int a = 0, b = 0, c = 0, d = 0;
            int[] marks = new int[25];
            Random rnd = new Random();
            for (int i=0;i<marks.Length;i++)
            {
                marks[i] = rnd.Next(2, 5+1);
                Console.Write($"{marks[i]}\t");
                if (marks[i] == 2)
                { a++; }
                if (marks[i] == 3)
                { b++; }
                if (marks[i] == 4)
                { c++; }
                if (marks[i] == 5)
                { d++; }
            }
            Console.WriteLine($"\nдвоечников = {a}");
            Console.WriteLine($"троеников = {b}");
            Console.WriteLine($"хорошистов = {c}");
            Console.WriteLine($"отличников = {d}");
        }
        static void Main(string[] args)
        {
            Marks();
            Console.ReadKey();
        }
    }
}
