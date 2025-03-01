using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatkertOOp
{
    internal class Allatkert
    {
        //Laci segítségével csináltam a feladatot meg, ezért lesz kb ugyanolyan mint az övé
        //Az ő kódját mutatva magyarázta nekem, hogy ő hogy csinálta
        Random r = new Random();


        List<Viz> viziallat = new List<Viz>();
        List<Hideg> hidegallat = new List<Hideg>();
        List<Mediterrán> mediterranallat = new List<Mediterrán>();
        List<Meleg> melegallat = new List<Meleg>();
        List<Trópusi> tropusiallat = new List<Trópusi>();

        private int hanyAllat;
        private int ferohely;


        public Allatkert()
        {
            ferohely = r.Next(5, 16);
        }



        public void Beolvas()
        {
            viziallat.Add(new Viz(1, "cetcápa", "hím", 2));
            hidegallat.Add(new Hideg(6, "pézsmatulok", "hím", 5));
            mediterranallat.Add(new Mediterrán(5, "dámszarvas ", "nőstény", 3));
            melegallat.Add(new Meleg(9, "gepárd ", "nőstény", 1));
            tropusiallat.Add(new Trópusi(5, "pókmajom ", "hím", 6));

        }

        public void KibolMennyi()
        {

            for (int i = 0; i < viziallat.Count; i++)
            {
                //hanyAllat += r.Next(1, 4);
                hanyAllat += 1;
            }
            for (int i = 0; i < hidegallat.Count; i++)
            {
                hanyAllat += 1;
            }
            for (int i = 0; i < mediterranallat.Count; i++)
            {
                // hanyAllat += r.Next(1, 3);
                hanyAllat += 1;
            }
            for (int i = 0; i < melegallat.Count; i++)
            {
                //hanyAllat += r.Next(1, 4);
                hanyAllat += 1;
            }
            for (int i = 0; i < tropusiallat.Count; i++)
            {
                hanyAllat += 1;
            }

            for (int i = 0; i < ferohely; i++)
            {
                if (i < hanyAllat)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
                Console.ResetColor();
            }
            Console.WriteLine();

            Console.WriteLine($"Kapacitás: {ferohely} / telítettség: {hanyAllat}");



            //if (ferohely < hanyAllat)
            //{
            //    Console.WriteLine("ajajj, úgy látszik néhény állatot el kéne költöztess, amíg nagyobb nem lesz a férőhejed, újrakalkulálás");
            //    for (int i = 0; i < viziallat.Count; i++)
            //    {
            //        hanyAllat += r.Next(1, 4);
            //    }
            //    for (int i = 0; i < hidegallat.Count; i++)
            //    {
            //        hanyAllat += 1;
            //    }
            //    for (int i = 0; i < mediterranallat.Count; i++)
            //    {
            //        hanyAllat += r.Next(1, 3);
            //    }
            //    for (int i = 0; i < melegallat.Count; i++)
            //    {
            //        hanyAllat += r.Next(1, 4);
            //    }
            //    for (int i = 0; i < tropusiallat.Count; i++)
            //    {
            //        hanyAllat += 1;
            //    }

            //    for (int i = 0; i < ferohely; i++)
            //    {
            //        if (i < hanyAllat)
            //        {
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.Write(" ");
            //        }
            //        else
            //        {

            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.Write(" ");
            //        }
            //        Console.ResetColor();
            //    }
            //    Console.WriteLine();

            //    Console.WriteLine($"Kapacitás: {ferohely} / telítettség: {hanyAllat}");
            //}
        }

        public void Lakosok()
        {
            string[] neve = new string[5];
            neve[0] = viziallat[0].Nev;
            neve[1] = hidegallat[0].Nev;
            neve[2] = mediterranallat[0].Nev;
            neve[3] = melegallat[0].Nev;
            neve[4] = tropusiallat[0].Nev;
            Console.WriteLine($"Az állatkert lakosai:{neve[0]}, {neve[1]}, {neve[2]}, {neve[3]}, {neve[4]}");
        }


        public void Verseny()
        {
            //nemigazán értettem ahogy Laci próbált segíteni, ezért én máshogy csináltam meg
            string[] neve = new string[5];
            neve[0] = viziallat[0].Nev;
            neve[1] = hidegallat[0].Nev;
            neve[2] = mediterranallat[0].Nev;
            neve[3] = melegallat[0].Nev;
            neve[4] = tropusiallat[0].Nev;

            
            int[] sebesege = new int[5];
            sebesege[0] = viziallat[0].Sebesseg;
            sebesege[1] = hidegallat[0].Sebesseg;
            sebesege[2] = mediterranallat[0].Sebesseg;
            sebesege[3] = melegallat[0].Sebesseg;
            sebesege[4] = tropusiallat[0].Sebesseg;


            //int randomIndex = r.Next(0, 5);
            //Console.WriteLine($"A(z) {neve[randomIndex]} sebessége: {sebesege[randomIndex]} km/h");
            //Console.WriteLine(sebesege[r.Next(0, 5)]);

            int jatekos1 = r.Next(0, 5);
            int jatekos2 = r.Next(0, 5);



            Console.WriteLine("Induljon a verseny!");
            //Console.WriteLine(neve[jatekos1] +"\n" + neve[jatekos2]); 
            int haladas = 0;
            int vegosszeg1 = 0;
            int haladas2 = 0;
            int vegosszeg2 = 0;

            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.SetCursorPosition(haladas += sebesege[jatekos1], 0);
                Console.WriteLine(neve[jatekos1]);
                vegosszeg1 += sebesege[jatekos1];


                Console.SetCursorPosition(haladas2 += sebesege[jatekos2], 1);
                Console.WriteLine(neve[jatekos2]);
                vegosszeg2 += sebesege[jatekos2];

                
            }
            if (vegosszeg1 > vegosszeg2)
            {
                Console.WriteLine($"A {neve[jatekos1]} nyert");
            }
            else { Console.WriteLine($"A {neve[jatekos2]} nyert"); }

            //itt sajnos nem tudom hogy hogyan lehet úgy megoldani, hogy az elején végig ottmaradjon a név, de mikor meg fut a verseny akkor O is legyen és név is az elején
        }
    }







    }

