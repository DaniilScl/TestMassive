using System;

namespace Lesson
{
    class Programm
    {
        static void Main(string[] args)
        {
            Test3();
        }

        private static void Test()
        {
            int[] myarrarei = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int resul = myarrarei.Max();
            int resulTwo = myarrarei.Min();
            Console.WriteLine("{0}, {1}",resul, resulTwo);

            Console.WriteLine(myarrarei.Where(i => i%2==0).Sum());
            Console.WriteLine(myarrarei.Sum());


            Console.WriteLine(myarrarei.Where(i => i % 2 != 0).Min());

        }
        private static void Test2()
        {
            int[] MyA = { 11, 2, 3, 11, 5, 6, 7, 8, 9, 10 };
            int[] MyB = MyA.Distinct().ToArray();
            
            MyB.OrderBy(i => i).ToArray();

            Array.Sort(MyB);
            int[] resilt = Array.FindAll(MyB, i => i < 7);
            Console.WriteLine(MyB);


        }
        private static void Test3()
        {
            int[] MyA = { 11, 2, 3, 11, 5, 6, 7, 8, 9, 10 };

            Index MYIND = ^2;
            Console.WriteLine(MyA[MYIND]);

            int[] MyB = MyA[1..5];

            foreach(var item in MyB)
            {
                Console.WriteLine(item);
            }
        }

        private static void Test4()
        {
            double[] MyA = { 1, 2, 3, 45, 4896, 22, 7, 23, 978 };

            for (int i = 0; i <= MyA.Length - 1; i++)
            {

                Array.Sort(MyA);
                Console.WriteLine(MyA[i] + " ");

            }
            Console.WriteLine("\n" + "Сумма");
            Console.WriteLine(MyA.Where(j => j % 2 == 0).Sum());
            Console.WriteLine("Максимальное число в массиве");
            Console.Write(MyA.Max() + "\n");
        }

        private static void Test5()
        {
            int[] MyA = { 0 };
            int sum = 0;
            int Limit = Convert.ToInt32(Console.ReadLine());
            int[] MyB = { Limit };
            for (int i = 0; i <= Limit; i++)
            {
                sum += MyA[0] = i;

                Console.WriteLine(MyA.Where(j => j % 2 == 0).Sum() + Limit);
            }
            Console.WriteLine("Вывод");
            Console.Write(sum);
        }

        private static void Test6()
        {
            int[] A = { 243, 546, 56, 566, 56 };
            int[] B = A.Distinct().ToArray();
            Console.WriteLine(B.Where(i => i <= 100).Sum());
        }
    }
}
 