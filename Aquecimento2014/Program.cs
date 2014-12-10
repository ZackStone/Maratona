using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mansao
{
    class Program
    {
        static void Main(string[] args)
        {

            aq2();



        }


        static void aq1()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int j = 0;
                if (int.TryParse(Math.Sqrt(i).ToString(), out j))
                {
                    Console.Write(i + " ");
                }

            }

            Console.ReadKey();

            //return;

            Console.WriteLine("\n\n");

            bool[] arr = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {

                    if (i == 0)
                    {
                        arr[j] = false;
                    }
                    else if (j % i == 0)
                    {
                        arr[j] = !arr[j];
                    }

                }

            }

            for (int i = 1; i <= n; i++)
            {
                if (arr[i])
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }

        static void aq2()
        {

            StreamReader sr = new StreamReader("volver.txt");

            int i = 0;

            while (!sr.EndOfStream)
            {
                char c = Convert.ToChar(sr.Read());

                if (c == 'E')
                {
                    i--;
                }
                else if (c == 'D')
                {
                    i++;
                }
            }

            i = i % 4;

            switch (i)
            {
                case 0:
                    Console.Write("Norte");
                    break;
                case 1:
                case -3:
                    Console.Write("Leste");
                    break;
                case 2:
                case -2:
                    Console.Write("Sul");
                    break;
                case 3:
                case -1:
                    Console.Write("Oeste");
                    break;
                default:
                    Console.Write("Algo deu errado! i = " + i);
                    break;
            }


            Console.ReadKey();

        }

    }
}
