using prueba.tecnica.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.tecnica.punto.uno
{
    public class Program
    {
         static void Main(string[] args)
        {
            int count = 8;

            bool[] houses = new bool[count];

            for (int i = 0; i < count; i++)
            {
                AddHouse(houses, i);
            }

            Console.WriteLine("Casas");

            for (int i = 0; i < count; i++)
            {
                int exit = houses[i] ? 1 : 0; 

                Console.Write(exit);
                Console.Write("-");
            }

            Console.WriteLine("");

            int days = GenerateDays();

            ChallengeOne challenge = new ChallengeOne();
            bool[] result = challenge.Test(houses,days);

            Console.WriteLine("resultado:");

            for (int i = 0; i < count; i++)
            {
                int exit = result[i] ? 1 : 0;

                Console.Write(exit);
                Console.Write("-");
            }

            Console.ReadLine();
        }

        private static int GenerateDays()
        {

            int value;

            try
            {
                Console.WriteLine("Ingrese la cantidad de dias");
                string line = Console.ReadLine();

                value = Convert.ToInt32(line);
            }

            catch(Exception exp)
            {
                Console.Write(exp.Message);
                value = GenerateDays();
            }

            return value;
         }

        private static void AddHouse(bool[] houses, int i)
        {
            try
            {
                Console.WriteLine($"Ingrese el valor de la casa {i + 1} (solo se admiten valores entre uno y cero)");

                string line = Console.ReadLine();

                int value = Convert.ToInt32(line);

                if (value > 1)
                {
                    Console.WriteLine("solo se admiten valores entre uno y cero");
                    AddHouse(houses, i);
                }
                else
                {
                    houses[i] = value == 1;
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
                AddHouse(houses, i);
            }
        }
    }
}
