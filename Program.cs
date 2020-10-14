using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10102020dz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Завдання для самостійної роботи: 
            Написати програму, для виконання операцій з множинами цілих чисел. 
            Множину представляє масив випадкових чисел. 

            Операції над множинами:
            - обєднання множин
                C = A u B
                A u B = { x : xєA або xєB  }
             - перетин множин
                D = A ∩ B
                A ∩ B = { x : xєA і xєB }
            - різниця множин
                E = A \ B
                A \ B = { x : x є A і x ∉ B }
            */

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість випадкових чисел для множин(A, B): ");
            int n = int.Parse(Console.ReadLine());
            //////////////////////////Множина A:
            int[] A = new int[n];
            Random rand = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i] = rand.Next(0, 25);
            Console.Write("Множина A: {      ");
            //вывод матриц
            foreach (var number in A)
                Console.Write($"{number}\t");
            Console.Write("}");
            //////////////////////////Множина B:
            int[] B = new int[n];
            for (int i = 0; i < B.Length; i++)
                B[i] = rand.Next(0, 25);
            Console.Write("\nМножина B: {      ");
            //вывод матриц
            foreach (var number in B)
                Console.Write($"{number}\t");
            Console.WriteLine("}");
            Console.WriteLine("Операції над множинами:");
            Console.WriteLine("- обєднання множин");
            Console.WriteLine("C = A u B");
            Console.WriteLine("A u B = { x: xєA або xєB  } "); // x пренадлежит А или х пренадлежит В

            int[] AB = new int[A.Length + B.Length];
            A.CopyTo(AB, 0);
            B.CopyTo(AB, A.Length);
            Array.Sort(AB);
            for (int i = 0; i < AB.Length; i++)
                Console.Write($"{AB[i]} ");
            Console.WriteLine();

            Console.WriteLine("- перетин множин");
            Console.WriteLine("D = A ∩ B");
            Console.WriteLine("A ∩ B = { x: xєA і xєB }"); // x пренадлежит А и х пренадлежит В
            var intersect = A.Intersect(B);
            foreach (int res in intersect)
                Console.Write($"{res} ");

            Console.WriteLine("\n- різниця множин");
            Console.WriteLine("E = A \\ B");
            Console.WriteLine("A \\ B = { x: x є A і x ∉ B }"); // x пренадлежит А и х не пренадлежит В
            var result = A.Except(B);
            foreach (int s in result)
                Console.Write($"{s} ");
            Console.ReadKey(); // затримка консолі
        }
    }
}
