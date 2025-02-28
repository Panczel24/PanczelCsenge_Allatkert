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
            viziallat.Add(new Viz(5, "cetcápa", "hím", 2));
            hidegallat.Add(new Hideg(6, "pézsmatulok", "hím", 5));
            mediterranallat.Add(new Mediterrán(55, "dámszarvas ", "nőstény", 3));
            melegallat.Add(new Meleg(8, "oroszlán ", "nőstény", 1));
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


        public void Verseny()
        {
            List<string> nev = new List<string>();
            List<int> sebesseg = new List<int>();

            string[] neve = new string[6];
            neve[0] = viziallat[1].Nev;
            neve[1] = hidegallat[1].Nev;
            neve[2] = mediterranallat[1].Nev;
            neve[3] = melegallat[1].Nev;
            neve[4] = tropusiallat[1].Nev;
            Random rnd = new Random();
            Console.WriteLine(neve[rnd.Next(0, 2)]);

            string[] questions = new string[3];
            questions[0] = "question1";
            questions[1] = "question2";
            questions[2] = "question3";
            Console.WriteLine(questions[rnd.Next(0, 2)]);


            //nevük
            for (int i = 0; i < viziallat.Count; i++)
            {
                nev.Add(viziallat[1].Nev);
            }
            for (int i = 0; i < hidegallat.Count; i++)
            {
                nev.Add(hidegallat[1].Nev);
            }
            for (int i = 0; i < mediterranallat.Count; i++)
            {
                nev.Add(mediterranallat[1].Nev);
            }
            for (int i = 0; i < melegallat.Count; i++)
            {
                nev.Add(melegallat[1].Nev);
            }
            for (int i = 0; i < tropusiallat.Count; i++)
            {
                nev.Add(tropusiallat[1].Nev);
            }

            //sebességük
            for (int i = 0; i < viziallat.Count; i++)
            {
                sebesseg.Add(viziallat[1].Sebesseg);
            }
            for (int i = 0; i < hidegallat.Count; i++)
            {
                sebesseg.Add(hidegallat[1].Sebesseg);
            }
            for (int i = 0; i < mediterranallat.Count; i++)
            {
                sebesseg.Add(mediterranallat[1].Sebesseg);
            }
            for (int i = 0; i < melegallat.Count; i++)
            {
                sebesseg.Add(melegallat[1].Sebesseg);
            }
            for (int i = 0; i < tropusiallat.Count; i++)
            {
                sebesseg.Add(tropusiallat[1].Sebesseg);
            }

           






        } 
    }







    }

