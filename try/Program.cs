using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EKRLib;

namespace Project1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Collection<Box> boxes;

            int N;
            bool check = false;
            do
            {
                if (check)
                {
                    Console.WriteLine("Неверно.");
                }
                Console.Write("Введите N: ");
                check = true;

            } while (!int.TryParse(Console.ReadLine(), out N) || N < 1);

            boxes = new Collection<Box>();

            for (int i = 0; i < N; i++)
            {
                try
                {
                    boxes.Add(new Box(rnd.Next(-3, 10) ,rnd.Next(-3, 10), rnd.Next(-3, 10), rnd.Next(-3, 10)));
                }
                catch (Exception e)
                {
                    i--;
                }
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
