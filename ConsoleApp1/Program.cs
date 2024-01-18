using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kolejka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolejka kolejka = new Kolejka();
            Console.WriteLine("Program tworzy kolejke oraz daje możliwość dodania do niej elementu, który jest liczbą całkowitą oraz usuwanie elementu");

            int wybor;
            do
            {
                    Console.WriteLine("Wybierz działanie. Wprowadź:");
                    Console.WriteLine("1 aby dodać element do kolejki");
                    Console.WriteLine("2 aby usunąć element z kolejki");
                    Console.WriteLine("3 aby wyjść");

                do
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out wybor))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość. Wprowadź 1 aby dodać, 2 aby usunąć, 3 aby wyjść.");
                    }
                } while (true);

                switch (wybor)
                {
                    case 1:
                        kolejka.Add();
                        break;
                    case 2:
                        kolejka.Remove();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Błędna wartość. Wprowadź 1 aby dodać, 2 aby usunąć, 3 aby wyjść");
                        break;
                }


            } while (wybor != 3);
        }


        class Kolejka
        {
            private Queue<int> queue;

            public Kolejka()
            {
                queue = new Queue<int>();
            }

            public void Add()
            {
                int element;
                do
                {
                    Console.Write("Podaj wartość do wprowadzenia do kolejki. Musi być to liczba całkowita ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out element))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość. Podaj liczbę całkowitą.");
                    }
                } while (true);

                queue.Enqueue(element);
                Console.WriteLine("Dodano do kolejki: " + element);
            }

            public void Remove()
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Kolejka jest pusta. Usuwanie niemożliwe");
                    return;
                }
                int usunietyElement = queue.Dequeue();
                Console.WriteLine("Usinięto element: " + usunietyElement);
            }
        }
    }
}