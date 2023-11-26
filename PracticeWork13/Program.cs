using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticeWork13
{
    internal class Program
    {
        static void expl1()
        {
            ArrayList list = new ArrayList();
            object test = 55;
            int x = (int)test;

            list.Add(5);
            list.Add(true);
            list.Add("test");

        }
        static void prac1()
        {
            List<int> Col = new List<int>();
            Random random = new Random();
            for (int i = 0; i <= 100; i++)
            {
                Col.Add(random.Next(1,100));
            }
            int max = 0;
            for (int i = 0;i <100; i++)
            {
                if (Col.ElementAt(i)>max)
                {
                    max = Col.ElementAt(i);
                }
            }
            Console.WriteLine(Col);
        }
        static void Prak2()
        {
            List<double> Col = new List<double>();
            Random random = new Random();
            double sum = 0; 

          
            for (int i = 0; i < 22; i++) 
            {
                
                double number = random.NextDouble() * 20 + 1; //  1 до 21
                Col.Add(number);

                
                sum += number;
                Console.WriteLine(number);
            }

            
            double average = sum / Col.Count;
            Console.WriteLine(sum);
            Console.WriteLine($"Среднее значение: {average}");

            
            //Console.WriteLine("Числа больше среднего:");
            //foreach (double number in Col)
            //{
            //    if (number > average)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
        }
        static void prac3()
        {
            List<double> nabor = new List<double>();
            Random random = new Random();

            for (int i = 0; i <= 22; i++)
            {
                nabor.Add(random.Next(1, 22));
                Console.WriteLine(nabor[i] + "  ");
            }
            

  
            List<double> Newnabor = new List<double>();
            Console.WriteLine(nabor);
            int k = 21;
            for(int i = 0; i < 22; i++)
            {
                Newnabor.Add(nabor[k]);
                k--;
                Console.WriteLine(Newnabor.ElementAt(i));
            }

        }
        static void Main(string[] args)
        {
            prac1();
            //Prak2();
            prac3();        }
    }
}
