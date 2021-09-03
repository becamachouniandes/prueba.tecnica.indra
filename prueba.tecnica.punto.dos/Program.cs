using prueba.tecnica.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.tecnica.punto.dos
{
    public class Program
    {
        static void Main(string[] args)
        {

            int space = 30;

            List<int> packages = new List<int>();

            AddPackage(packages);

            Console.WriteLine("Paquetes");

            foreach (int package in packages)
            {
                Console.Write(package);
                Console.Write("-");
            }

            Console.WriteLine("");

            int capacity = GenerateCapacity();

            ChallengeTwo challenge = new ChallengeTwo();
            int[] result = challenge.Test(capacity,space,packages.ToArray());

            Console.WriteLine("resultado:");

            foreach (int package in result)
            {
                Console.Write(package);
                Console.Write("-");
            }

            Console.ReadLine();
        }

        private static int GenerateCapacity()
        {

            int value;

            try
            {
                Console.WriteLine("Ingrese la capacidad del camión (Debe ser mayor a 30)");
                string line = Console.ReadLine();

                value = Convert.ToInt32(line);
            }

            catch (Exception exp)
            {
                Console.Write(exp.Message);
                value = GenerateCapacity();
            }

            return value;
        }

        private static void AddPackage(List<int> packages)
        {
            try
            {
                Console.WriteLine($"Ingrese el valor del paquete");

                string line = Console.ReadLine();

                int value = Convert.ToInt32(line);

                packages.Add(value);
                ExitPackage(packages);
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
                AddPackage(packages);
            }
        }

        private static void ExitPackage(List<int> packages)
        {
            string line;
            Console.WriteLine($"Desea agregar otro paquete s/n");

            line = Console.ReadLine();

            if (line.ToLower() == "s")
            {
                AddPackage(packages);
            }
            else if (line.ToLower() != "n")
            {
                ExitPackage(packages);
            }
        }
    }
}
