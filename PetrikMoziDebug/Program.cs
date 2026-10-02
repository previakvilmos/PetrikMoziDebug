using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrikMoziDebug
{
    internal class Program
    {
        static void MenuKiir()
        {
            Console.WriteLine("=== PETRIK MOZI 2.0 ===");
            Console.WriteLine();

            Console.WriteLine("1.) Jegyvásárlás");
            Console.WriteLine("2.) Mai filmek");
            Console.WriteLine("3.) Kedvezmény kalkulátor");
            Console.WriteLine("4.) Bevétel");
            Console.WriteLine("5.) Kilépés");

            Console.WriteLine();

            Console.Write("Választás: ");
        }


        static string JegyTipus(int eletkor)
        {
            if (eletkor <= 11)
            {
                return "Gyerekjegy";
            }
            else if (eletkor <= 17)
            {
                return "Diákjegy";
            }
            else if (eletkor <= 64)
            {
                return "Felnőttjegy";
            }
            else
            {
                return "Nyugdíjas jegy";
            }
        }


        static int JegyAr(int eletkor)
        {
            if (eletkor < 12)
            {
                return 1500;
            }
            else if (eletkor < 18)
            {
                return 2000;
            }
            else if (eletkor < 65)
            {
                return 3000;
            }
            else
            {
                return 1800;
            }
        }


        static void FilmValasztas()
        {
            Console.Clear();

            Console.WriteLine("=== MAI FILMEK ===");
            Console.WriteLine();

            Console.WriteLine("1.) Minecraft");
            Console.WriteLine("2.) Bosszúállók");
            Console.WriteLine("3.) Shrek");

            Console.WriteLine();

            Console.Write("Melyik filmet választod? ");

            int film = Convert.ToInt32(Console.ReadLine());

            switch (film)
            {
                case 1:
                    Console.WriteLine("A Minecraft című filmet választottad.");
                    break;

                case 2:
                    Console.WriteLine("A Bosszúállók című filmet választottad.");
                    break;

                case 3:
                    Console.WriteLine("A Shrek című filmet választottad.");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen film!");
                    break;
            }
        }


        static int KedvezmenyesAr(int ar, int kedvezmeny)
        {
            switch (kedvezmeny)
            {
                case 1:
                    return ar;

                case 2:
                    return ar - (ar * 20 / 100);

                case 3:
                    return ar - (ar * 10 / 100);

                default:
                    return ar;
            }
        }


        static void KedvezmenyKalkulator()
        {
            Console.Clear();

            Console.WriteLine("=== KEDVEZMÉNY KALKULÁTOR ===");
            Console.WriteLine();

            Console.WriteLine("1.) Nincs kedvezmény");
            Console.WriteLine("2.) Diákkedvezmény - 20%");
            Console.WriteLine("3.) Törzsvásárlói kedvezmény - 10%");

            Console.WriteLine();

            Console.Write("Jegy eredeti ára: ");

            int ar = Convert.ToInt32(Console.ReadLine());


            Console.Write("Kedvezmény típusa: ");

            int kedvezmeny = Convert.ToInt32(Console.ReadLine());


            if (kedvezmeny >= 1 && kedvezmeny <= 3)
            {
                int fizetendo = KedvezmenyesAr(ar, kedvezmeny);

                Console.WriteLine();

                Console.WriteLine(
                    $"Fizetendő: {fizetendo} Ft"
                );
            }
            else
            {
                Console.WriteLine("Nincs ilyen kedvezménytípus!");
            }
        }


        static void Main(string[] args)
        {
            int bevetel = 0;

            int valasztas = 0;


            do
            {
                Console.Clear();

                MenuKiir();


                try
                {
                    valasztas = Convert.ToInt32(Console.ReadLine());


                    switch (valasztas)
                    {
                        case 1:

                            Console.Clear();

                            Console.WriteLine("=== JEGYVÁSÁRLÁS ===");

                            Console.WriteLine();


                            Console.Write("Név: ");

                            string nev =
                                Console.ReadLine();


                            Console.Write("Életkor: ");

                            int eletkor =
                                Convert.ToInt32(
                                    Console.ReadLine()
                                );


                            if (eletkor < 0 || eletkor > 120)
                            {
                                Console.WriteLine("Hibás életkor!");
                            }
                            else
                            {
                                string jegyTipus = JegyTipus(eletkor);


                                int ar = JegyAr(eletkor);


                                Console.WriteLine();

                                Console.WriteLine($"Jegytípus: {jegyTipus}");


                                Console.WriteLine($"Fizetendő: {JegyAr(eletkor)} Ft");


                                bevetel += ar;
                            }

                            Console.ReadLine();

                            break;


                        case 2:

                            FilmValasztas();

                            Console.ReadLine();

                            break;


                        case 3:

                            KedvezmenyKalkulator();

                            Console.ReadLine();

                            break;


                        case 4:

                            Console.Clear();

                            Console.WriteLine("=== BEVÉTEL ===");

                            Console.WriteLine();

                            Console.WriteLine($"A mozi teljes bevétele: {bevetel} Ft");

                            Console.ReadLine();

                            break;


                        case 5:

                            Console.WriteLine("Viszlát!");

                            Console.ReadLine();

                            break;


                        default:

                            Console.WriteLine("Válassz az 1-5 lehetőség közül!");

                            Console.ReadLine();

                            break;
                    }
                }
                catch
                {
                    Console.WriteLine();

                    Console.WriteLine("Hiba! Számot kell megadni!");

                    Console.ReadLine();
                   
                }

            } while (valasztas != 5);
        }
    }
}