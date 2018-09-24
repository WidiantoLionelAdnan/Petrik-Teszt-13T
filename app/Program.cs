using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            int max, min,db;
            
        
            Console.WriteLine("Hány darab számot írsz be?");
            //db = Convert.ToInt32(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out db))
            {
                Console.WriteLine("Nem számot adtál meg!");
            }
            Console.WriteLine("Kérek"+ " "+db+" " +"db számot!");

            max = szamok[0];
            for (int i = 0; i < db; i++)
            {
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                if (szamok[i]> max)
                {
                    max = szamok[i];
                }
            }
            Console.WriteLine("Legnagyobb szám: " + max);

            min = szamok[0];
            for (int i = 0; i < db; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            Console.WriteLine("Legkisebb szám: " + min);
            
            Console.ReadKey();
        }
    }
}
