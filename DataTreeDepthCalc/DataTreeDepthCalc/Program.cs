using System;
using System.Collections.Generic;

namespace DataTreeDepthCalc
{
    class Program
    {
        static void Main()
        {
            PirmasTestas();
            AntrasTestas();
            Console.ReadKey();
        }
            private static void PirmasTestas()
        {
            Saka saka1 = new Saka();
            Saka saka11 = new Saka();
            Saka saka12 = new Saka();
            Saka saka13 = new Saka();
            Saka saka111 = new Saka();
            Saka saka112 = new Saka();
            Saka saka121 = new Saka();
            Saka saka131 = new Saka();
            Saka saka132 = new Saka();
            Saka saka133 = new Saka();
            Saka saka1311 = new Saka();
            Saka saka1312 = new Saka();
            Saka saka1321 = new Saka();
            Saka saka1322 = new Saka();
            Saka saka1323 = new Saka();
            Saka saka1331 = new Saka();
            Saka saka13221 = new Saka();
            Saka saka13231 = new Saka();
            Saka saka13232 = new Saka();
            Saka saka132311 = new Saka();
            Saka saka132312 = new Saka();
            Saka saka132321 = new Saka();
            Saka saka1323111 = new Saka();

            saka1.AddBranch(saka11);
            saka11.AddBranch(saka111);
            saka11.AddBranch(saka112);
            saka1.AddBranch(saka12);
            saka12.AddBranch(saka121);
            saka1.AddBranch(saka13);
            saka13.AddBranch(saka131);
            saka131.AddBranch(saka1311);
            saka131.AddBranch(saka1312);
            saka13.AddBranch(saka132);
            saka132.AddBranch(saka1321);
            saka132.AddBranch(saka1322);
            saka1322.AddBranch(saka13221);
            saka132.AddBranch(saka1323);
            saka1323.AddBranch(saka13231);
            saka13231.AddBranch(saka132311);
            saka132311.AddBranch(saka1323111); //giliausia - 7 laipsinio
            saka13231.AddBranch(saka132312);
            saka1323.AddBranch(saka13232);
            saka13232.AddBranch(saka132321);
            saka13.AddBranch(saka133);
            saka133.AddBranch(saka1331);

            Console.WriteLine("Pirmo testo rez: "+saka1.BranchDepth());
        }
        private static void AntrasTestas()
        {
            Saka saka1 = new Saka();
            Saka saka10 = new Saka();
            Saka saka11 = new Saka();
            Saka saka111 = new Saka();
            Saka saka1111 = new Saka();
            Saka saka11111 = new Saka();
            Saka saka111111 = new Saka();

            saka1.AddBranch(saka11);
            saka11.AddBranch(saka111);
            saka111.AddBranch(saka1111);
            saka1111.AddBranch(saka11111);
            saka11111.AddBranch(saka111111); // giliausia - 6 laipsnio
            saka1.AddBranch(saka10);

            Console.WriteLine("Antro testo rez: " + saka1.BranchDepth());
        }
    }
}
