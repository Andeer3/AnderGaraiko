using System;
using System.Data;
using System.Collections.Generic; 

namespace Programazioa;

class Programazioa
{
    
    static void Main()
    {
        List<Hitzordua> hitzorduak = new List<Hitzordua>();

        int aukera = 0;

        while (aukera != 9)
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("Ile-apaindegia");
            Console.WriteLine("========================");
            Console.WriteLine("1. Hitzordua sortu");
            Console.WriteLine("2. Hitzordua ikusi");
            Console.WriteLine("3. Bezeroaren izena aldatu");
            Console.WriteLine("4. Zerbitzua aldatu");
            Console.WriteLine("5. Data aldatu");
            Console.WriteLine("6. Prezioa aldatu");
            Console.WriteLine("7. Hitzordua ezabatu");
            Console.WriteLine("8. Informazio orokorra");
            Console.WriteLine("9. Irten");
            Console.WriteLine("=========================");

            Console.Write("Aukera: ");

            aukera = int.Parse(Console.ReadLine());

            // 1. HITZORDUA SORTU

            if (aukera == 1)
            {

                Hitzordua h = new Hitzordua();

                Console.Clear();

                Console.Write("Bezeroaren izena: ");
                h.bezeroa = Console.ReadLine();

                while (h.bezeroa == "")
                {
                    Console.Write("Izena ezin da hutsik egon. Saiatu berriro: ");
                    h.bezeroa = Console.ReadLine();
                }

                Console.WriteLine("Zerbitzua aukeratu: ");
                Console.WriteLine("1. Ilea moztu (10€)");
                Console.WriteLine("2. Ilea orraztu (5€)");
                Console.WriteLine("3. Ilea tintatu");
                Console.Write("Aukera: ");

                int zerbitzu = int.Parse(Console.ReadLine());

                if (zerbitzu == 1)
                {
                    h.zerbitzua = "Ilea moztu";
                    h.prezioa = 10;
                }
                else if (zerbitzu == 2)
                {
                    h.zerbitzua = "Ilea orraztu";
                    h.prezioa = 5;
                }
                else
                {
                    h.zerbitzua = "Ilea tintatu";
                    h.prezioa = 20;
                }

                Console.Write("Data: ");
                h.data = Console.ReadLine();

                hitzorduak.Add(h);

                Console.WriteLine("Hitzordua sortuta.");
                Console.ReadKey();
            }


            // 2. HITZORDUAK IKUSI

            else if (aukera == 2)
            {
                Console.Clear();

                if (hitzorduak.Count == 0)
                {
                    Console.WriteLine("Ez dago hitzordurik.");
                }
                else
                {
                    for (int i = 0; i < hitzorduak.Count; i++)
                    {
                        Console.WriteLine("HITZORDUA " + (i + 1));
                        Console.WriteLine("Bezeroa: " + hitzorduak[i].bezeroa);
                        Console.WriteLine("Zerbitzua: " + hitzorduak[i].zerbitzua);
                        Console.WriteLine("Data: " + hitzorduak[i].data);
                        Console.WriteLine("Prezioa: " + hitzorduak[i].prezioa);
                        Console.WriteLine("--------------------------");
                    }
                }

                Console.ReadKey();
            }

            // 3. BEZEROAREN IZENA ALDATU

            else if (aukera == 3)
            {

                Console.Clear();

                if (hitzorduak.Count > 0)
                {
                    Console.Write("Zein hitzordu (1-" + hitzorduak.Count + "): ");
                    int pos = int.Parse(Console.ReadLine()) - 1;

                    if (pos >= 0 && pos < hitzorduak.Count)
                    {
                        Console.Write("Izen berria: ");
                        hitzorduak[pos].bezeroa = Console.ReadLine();
                        Console.WriteLine("Izena eguneratu da.");
                    }
                    else
                    {
                        Console.WriteLine("Posizio okerra.");
                    }
                
                }
                else
                {
                    Console.WriteLine("Ez dago hitzordueik.");  
                }

                Console.ReadKey();            
            }

            // 4. ZERBITZUA ALDATU

            else if (aukera == 4)
            {

                Console.Clear();


                if (hitzorduak.Count == 0)
                {
                    Console.WriteLine("Ez dago hitzordurik.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Zein hitzordu aldatu (1-" + hitzorduak.Count + "): ");
                    int pos = int.Parse(Console.ReadLine()) - 1;

                    if (pos < 0 || pos >= hitzorduak.Count)
                    {
                        Console.WriteLine("Aukera okerra.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Zerbitzu berria aukeratu: ");
                        Console.WriteLine("1. Ilea moztu (10€)");
                        Console.WriteLine("2. Ilea orraztu (5€)");
                        Console.WriteLine("3. Ilea tintatu (20€)");
                        Console.Write("Aukera: ");

                        int zerbitzua = int.Parse(Console.ReadLine());

                        if (zerbitzua == 1)
                        {
                            hitzorduak[pos].zerbitzua = "Ilea moztu";
                            hitzorduak[pos].prezioa = 10;
                        }
                        else if (zerbitzua == 2)
                        {
                            hitzorduak[pos].zerbitzua = "Ilea orraztu";
                            hitzorduak[pos].prezioa = 5;
                        }
                        else if (zerbitzua == 3)
                        {
                            hitzorduak[pos].zerbitzua = "Ilea tintatu";
                            hitzorduak[pos].prezioa = 20;
                        }
                        else
                        {
                            Console.WriteLine("Aukera okerra.");
                        }

                        Console.WriteLine("Zerbitzua ondo aldatu da.");
                        Console.ReadKey();
                    }
                }

                Console.WriteLine("Zerbitzua ondo aldatu da");
                Console.ReadKey();

            }

            // 5. DATA ALDATU

            else if (aukera == 5)
            {

                Console.Clear();


                if (hitzorduak.Count > 0)
                {
                    Console.Write("Zein hitzordu: ");
                    int pos = int.Parse(Console.ReadLine()) -1;

                    Console.Write("Data berria: ");
                    hitzorduak[pos].data = Console.ReadLine();

                    Console.WriteLine("Data eguneratu da.");
                }

                Console.ReadKey();

            }

            // 6. PREZIOA ALDATU

            else if (aukera == 6)
            {
                Console.Clear();


                if (hitzorduak.Count > 0)
                {
                    Console.Write("Zein hitzordu: ");
                    int pos = int.Parse(Console.ReadLine()) -1;

                    Console.Write("Prezio berria: ");
                    hitzorduak[pos].prezioa = int.Parse(Console.ReadLine());

                    Console.WriteLine("Prezioa eguneratu da.");
                }

                Console.ReadKey();
            }

            // 7. HITZORDUA EZABATU

            else if (aukera == 7)
            {
                Console.Clear();


                if (hitzorduak.Count > 0)
                {
                    Console.Write("Zein hitzordu ezabatu nahi duzu: ");
                    int pos = int.Parse(Console.ReadLine()) - 1;

                    hitzorduak.RemoveAt(pos);
                    Console.WriteLine("Hitzordua ezabatuta.");
                }

            Console.ReadKey();

        }

        // 8. INFORMAZIO OROKORRA

        else if (aukera == 8)
            {
                Console.Clear();

                Console.WriteLine("INFORMAZIO OROKORRA");
                Console.WriteLine("-------------------");
                Console.WriteLine("Ilea moztu  - 10€");
                Console.WriteLine("Ilea orraztu  - 5€");
                Console.WriteLine("Ilea tintatu  - 20€");
                Console.WriteLine("--------------------");
                Console.WriteLine("Ordutegia: 9:00 - 21:00");
                Console.WriteLine("Larunbatak zabalik");
                Console.WriteLine("Igandeak itxita");

                Console.ReadKey();
            }

        // 9. IRTEN

        else if (aukera == 9)
            {
                Console.Clear();
                Console.WriteLine("Eskerrik asko etoryzeagatik");
                Console.WriteLine("Agur!");
                Console.ReadKey();        
            }
        }
    }
}
