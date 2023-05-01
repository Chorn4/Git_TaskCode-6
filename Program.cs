using System;
using System.Collections.Generic;
using System.Linq;

namespace Prakt5
{
    internal class Program
    {
        enum companys
        {
          //kyiv
          Telemart = 1,
          SoftServe,
          SoftwareONE,
          //Kharkiv
          YouControl,
          Rkeeper,
          Lopan,
        }
        static void Main(string[] args)
        {
            Console.Write("Company names:\n");

            for (int i = 1; i <= (int)companys.Lopan; i++)
            {
                Console.WriteLine($"{i})" + (companys)i);
            }

            Console.Write("\nEnter known companys (Separate numbers with a comma): ");

            string Entered = Console.ReadLine();
            string[] EnteredCompanysArr = Entered.Split(',');

            int[] Transfered = new int[EnteredCompanysArr.Length];

            for (int i = 0; i < EnteredCompanysArr.Length; i++)
            {
                Transfered[i] = int.Parse(EnteredCompanysArr[i]);
            }

            List<int> KnownCompanys = Transfered.ToList();

            Console.WriteLine("\nKnown companys: ");

            foreach (int i in KnownCompanys)
            {
                if (i <= 0 || i > (int)companys.Lopan)
                {
                    Console.WriteLine($"{i})Error");
                }
                else 
                {
                    Console.WriteLine($"{i}){(companys)i}");
                }
            }
        }
    }
}
