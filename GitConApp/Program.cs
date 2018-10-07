using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //elso_commit();
            //masodik_commit();
            //harmadik_commit();
            negyedik_commit();
        }

        static void elso_commit()
        {
            Console.WriteLine("K");
            int[] tomb = new int[10];
            int legnagyobb = 0; 
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine("Kérem adja meg a {0}. számot!!!PLS!!",i+1);
                tomb[i] = int.Parse(Console.ReadLine());
                if (i == 0) legnagyobb = tomb[i];
                if (legnagyobb < tomb[i]) legnagyobb = tomb[i]; 
            }
            Console.WriteLine("A legnagyobb szám: {0}",legnagyobb);
        }
        static void masodik_commit()
        {
            Console.WriteLine("Add meg hogy mennyi számot szeretnél megadni!");
            int N = int.Parse(Console.ReadLine());
            int[] tomb = new int[N];
            int legnagyobb = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Kérem adja meg a {0}. számot!!!PLS!!", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
                if (i == 0) legnagyobb = tomb[i];
                if (legnagyobb < tomb[i]) legnagyobb = tomb[i];
            }
            Console.WriteLine("A legnagyobb szám: {0}", legnagyobb);
        }
        static void harmadik_commit()
        {
            Console.WriteLine("Add meg hogy mennyi számot szeretnél megadni!");
            int N = int.Parse(Console.ReadLine());
            int[] tomb = new int[N];
            int legkisebb = 0;
            int legnagyobb = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Kérem adja meg a {0}. számot!!!PLS!!", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
                if (i == 0) { legnagyobb = tomb[i]; legkisebb = tomb[i]; };
                if (legnagyobb < tomb[i]) legnagyobb = tomb[i];
                if (legkisebb > tomb[i]) legkisebb = tomb[i];
            }
            Console.WriteLine("A legnagyobb szám: {0}\nA legkisebb szám: {1}", legnagyobb,legkisebb);
        }

        static void negyedik_commit()
        {
            Console.WriteLine("Add meg hogy mennyi számot szeretnél megadni!");
            int N;
            while (!(Int32.TryParse(Console.ReadLine(), out N)))
            {
                Console.WriteLine("Egy szám kell, légyszíves azt írd! ");
            };
            int[] tomb = new int[N];
            int legkisebb = 0;
            int legnagyobb = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Kérem adja meg a {0}. számot!!!PLS!!", i + 1);
                if(Int32.TryParse(Console.ReadLine(), out tomb[i]))
                {
                    if (i == 0) { legnagyobb = tomb[i]; legkisebb = tomb[i]; };
                    if (legnagyobb < tomb[i]) legnagyobb = tomb[i];
                    if (legkisebb > tomb[i]) legkisebb = tomb[i];
                }
                else
                {
                    Console.WriteLine("Egy szám kell, légyszíves azt írd! ");
                    i--;
                }
                
            }
            Console.WriteLine("A legnagyobb szám: {0}\nA legkisebb szám: {1}", legnagyobb, legkisebb);
        }
    }
}
