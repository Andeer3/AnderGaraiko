using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
    

//=====================================================================================
// PROIEKTUA: Garaiko ile-apaindegia.
// Aplikazio honek ile-apaindegirako hitzorduak sortu, kontsultatu eta bilatu egiten du.
//=====================================================================================


//===========================
// Funtzio nagusiak:
// 1) Hitzordu berria sortu.
// 2) Hitzordu guztiak ikusi.
// 3) Bezeroen laburpena
// 4) Hitzordua ezabatu
// 5) Hitzordu bat editatu
// 6) Hitzordu kopurua begiratu
// 7) Gaurko hitzorduak begiratu
// 8) Programatik irten.
//===============================


//=============================================================================
// class Hitzordua.
// Hitzoruda: Bezeroen datuak gordetzeko.
//=============================================================================
class Hitzordua
{
    public string Izena;
    public string Zerbitzua;
    public List<string> Gehigarria;
    public DateTime DataOrdua;
}

//==================================================================================
// class Programa
// Hau programa nagusia da, menu nagusia, funtzio guztiak eta datuen kudeaketa dago.
//==================================================================================
class Programa
{
    static List<Hitzordua> hitzorduaZerrenda = new List<Hitzordua>();

    static void Main(string[] args)
    {
        int aukera = 0;

        do
        {
            GarbituPantaila();
            Tituloa(" Garaiko ile-apaindegia ");

            Menua();
            aukera = ZenbakiraPasatu(Console.ReadLine());

            switch (aukera)
            {
                case 1:
                    HitzorduaSortu();
                    break;

                case 2:
                    HitzorduaIkusi();
                    break;

                case 3:
                    BezeroLaburpena();
                    break;

                case 4:
                    Tituloa(" Ekerrik asko ile-apaindegira etortzeagatik! Ongi izan! ");
                    break;

                case 5:
                    HitzorduaEzabatu();
                    break;

                case 6:
                    EditatuHitzordua();
                    break;

                case 7:
                    HitzorduKopurua();
                    break;

                case 8:
                    Gaurko hitzorduak();
                    break;

                default:
                    Console.WriteLine(" Aukera okerra, saiatu berriro mesedez.");
                    break;
            }

            TeklaSakatu();
        }
        while (aukera != 7);
    }


    //=========================================================
    // Funtzioa GarbituPantaila()
    // Pantaila garbitzen du, horrela txukuntasuna gehiago dago
    //=========================================================
    static void GarbituPantaila()
    {
        Console.Clear();
    }

    //========================================
    // Funtzioa Tituloa()
    // Titulo txukun bat erakusten du.
    //========================================

    static void Tituloa(string testua)
    {
        Console.WriteLine("===================");
        Console.WriteLine(" " + testua);
        Console.WriteLine("===================");
    }

    //============================================================
    // Funtzioa TeklaSakatu()
    // Erabiltzaileri eskatzen diot ENTER tekla ematea jarraitzeko
    //============================================================

    static void TeklaSakatu()
    {
        Console.WriteLine("\nJarraitzeko ENTER tekla sakatu, mesedez.");
        Console.ReadLine();
    }


    //===============================================
    // Funtzioa Menua()
    // Aukera nagusiak erakuisteko kontsolan
    //===============================================

    static void Menua()
    {
        Console.WriteLine(" 1. Hitzordu berria sortu. ");

        Console.WriteLine(" 2. Hitzordu guztiak ikusi. ");

        Console.WriteLine(" 3. Ikusi bezero guztien laburpena. ");

        Console.WriteLine(" 4. Ezabatu hitzordu bat. ");

        Console.WriteLine(" 5. Hitzordu bat editatu. ");

        Console.WriteLine(" 6. Hitzordu kopurua kontatu. ");

        Console.WriteLine(" 7. Gaurko hitzorduak ikusi. ");

        Console.WriteLine(" 8. Irten ");

        Console.Write("\nAukera (1-8): ");
    }


    //================================================
    // Funztioa ZenbakiraPasatu()
    // Erabiltzailearen sarrera zenbakira pasatzen du.
    //================================================

    static int ZenbakiraPasatu(string testua)
    {
        int zenb = 0;
        int.TryParse(testua, out zenb);
        return zenb;
    }


    //=============================================
    // Funtzioa IzenaBalidatu
    // Izenak hutsik ez dagoela ziurtatzen du
    //=============================================
    static string IzenaBalidatu()
    {
        string izena = "";

        do
        {
            Console.Write(" Sartu zure izena: ");
            izena = Console.ReadLine();
        }
        while (izena == "");

        return izena;
    }


    //=========================================================
    // Funtzioa Lerroa()
    // Lerro bat agertzen da pantailan, txukuntasuna hobetzeko
    //=========================================================

    static void Lerroa()
    {
        Console.WriteLine("------------------------------------");
    }


    //=======================================
    // Funtzioa ApainduTestua()
    // Testua apaintzeko, txukuntasun gehiago
    //=======================================

    static void ApainduTestua(string mezua)
    {
        Lerroa();
        Console.WriteLine(" " + mezua);
        Lerroa();
    }



    //========================================
    // Funtzioa HitzorduaSortu
    // Bezero berri baten hitzordua sortzen du
    //========================================

    static void HitzorduaSortu()
    {
        GarbituPantaila();
        Tituloa(" HITZORDU BERRIA ");

        Hitzordua c = new Hitzordua();
        c.Gehigarria = new List<string>();
        c.DataOrdua = DateTime.Now;

        Console.Write(" Zure izena sartu, mesedez: ");
        c.Izena = Console.ReadLine();

        c.Zerbitzua = ZerbitzuaAukeratu();
        c.Gehigarria = GehigarriaAukeratu();

        hitzorduaZerrenda.Add(c);

        Console.WriteLine("\n Hitzordua ondo sortu da! ");
    }


    //==============================
    // Funtzioa ZerbitzuaAukeratu()
    // Aukeratzeko zerbitzu nagusia
    //==============================

    static string ZerbitzuaAukeratu()
    {
        string z = "";

        do
        {
            Console.WriteLine("\nZerbitzua aukeratu: ");
            Console.WriteLine("a - Ilea moztu");
            Console.WriteLine("b - Bizarra moztu");
            Console.WriteLine("c - Ilea orraztu");
            Console.WriteLine("d - Ilearen diseinu berezia");
            Console.WriteLine("e - Aurpegiko tratamendua");
            Console.WriteLine("f - Ilea tintatu");
            Console.Write("Aukera: ");
            z = Console.ReadLine();
        }

        while (z != "a" && z != "b" && z != "c" && z != "d" && z != "e" && z != "f");

        switch (z)
        {
            case "a": return "Ilea moztu";

            case "b": return "Bizarra moztu";

            case "c": return "Ilea orraztu";

            case "d": return "Ilearen diseinu berezia";

            case "e": return "Aurpegiko tratamendua";

            case "f": return "Ilea tintatu";

            default: return "Ezezaguna";
        }
    }

    //==================================
    // Funtzioa GehigarriaAukeratu
    // Gehigarri zerbitzuak aukeratzeko
    //==================================

    static List<string> GehigarriaAukeratu()
    {
        List<string> GehigarriGuztiak = new List<string>()
        {
            "Bizarra forma profesionala",
            "Buruko masajea",
            "Ilea garbitzea",
            "Lepoko masajea",
            "Produktu naturalekin tratamendua",
            "Azalaren hidratazioa"
        };

        List<string> aukeratutakoa = new List<string>();

        Console.WriteLine("\nGehigarri zerbitzuak aukeratu, mesedez. ");

        foreach (string e in GehigarriGuztiak)
        {
            Console.Write("Gehitu '" + e + "'? (b/e): ");
            string erantzuna = Console.ReadLine();

            if (erantzuna == "b")
            {
                aukeratutakoa.Add(e);
            }
        }

        return aukeratutakoa;
    }

    //================================
    // Funtzioa HitzorduaIkusi
    // Hitzordu guztiak erakusten ditu
    //================================

    static void HitzorduaIkusi()
    {
        GarbituPantaila();
        Tituloa(" Erregistratutako hitzordu guztiak ");

        if (hitzorduaZerrenda.Count == 0)
        {
            Console.WriteLine(" Ez dago oraindik hitzordurik ");
        }
        else
        {
            foreach (Hitzordua c in hitzorduaZerrenda)
            {
                Console.WriteLine($"\nIzena: {c.Izena}");
                Console.WriteLine($"Zerbitzua: {c.Zerbitzua}");
                Console.WriteLine($"Data: {c.DataOrdua}");
                Console.WriteLine(" Gehigarri zerbitzuak: ");

                foreach (string e in c.Gehigarria)
                {
                    Console.WriteLine("- " + e);
                }
                Lerroa();
            }
        }
    }


    //==================================================
    // Funtzioa BezeroLaburpena
    // Bezero bakoitzak ze hitzordu dituen errakusten du
    //==================================================

    static void BezeroLaburpena()
    {
        GarbituPantaila();
        Tituloa(" Bezeroaren laburpena ");

        if (hitzorduaZerrenda.Count == 0)
        {
            Console.WriteLine(" Ez dago daturik ");
            return;
        }

        Dictionary<string, int> bezeroak = new Dictionary<string, int>();

        foreach (Hitzordua h in hitzorduaZerrenda)
        {
            if (bezeroak.ContainsKey(h.Izena))
                bezeroak[h.Izena]++;

            else
                bezeroak[h.Izena] = 1;
        }

        Console.WriteLine("\nBezero bakoitzak zenbat hitzordu dituen: ");

        foreach (var b in bezeroak)
        {
            Console.WriteLine($" - {b.Key}: {b.Value} hitzordu");
        }

        Lerroa();
    }


    //==========================
    // Funtzioa HitzorduaEzabatu
    // Hitzordu bat ezabatzeko
    //==========================


    static void HitzorduaEzabatu()
    {
        GarbituPantaila();
        Tituloa(" Hitzordu bat ezabatu ");

        if (hitzorduaZerrenda.Count == 0)
        {
            Console.WriteLine(" Ez dago hitzordurik ezabatzeko ");
            return;
        }

        Console.WriteLine(" Hitzordu zerrenda: ");
        Console.WriteLine();


        for (int i = 0; i < hitzorduaZerrenda.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + hitzorduaZerrenda[i].Izena
                + " - " + hitzorduaZerrenda[i].Zerbitzua
                + " (" + hitzorduaZerrenda[i].DataOrdua + ")");
        }

        Console.WriteLine();
        Console.WriteLine(" Zein hitzordu ezabatu nahi duzu? (1-" + hitzorduaZerrenda.Count + "): ");

        string sarrera = Console.ReadLine();
        int aukera = 0;
        int.TryParse(sarrera, out aukera);


        if (aukera < 1 || aukera > hitzorduaZerrenda.Count)
        {
            Console.WriteLine(" Aukera okerra, ez da ezer ezabatu. ");
            return;
                           
        }

        hitzorduaZerrenda.RemoveAt(aukera - 1);

        Console.WriteLine("\n   Hitzordua ondo ezabatu da. ");
    }

    //=================================
    // Funtzioa EditatuHitzordua
    // Hitzordu baten datuak aldatzeko
    //=================================


    static void EditatuHitzordua()
    {
        GarbituPantaila();
        Tituloa(" Hitzordu bat editatu ");

        if (hitzorduaZerrenda.Count == 0)
        {
            Console.WriteLine(" Ez dago hitzordurik editatzeko. ");
            return;
        }

        Console.WriteLine (" Hitzordu zerrenda: \n");

        for (int i = 0; i < hitzorduaZerrenda.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + hitzorduaZerrenda[i].Izena
            + " - " + hitzorduaZerrenda[i].Zerbitzua
            + " (" + hitzorduaZerrenda[i].DataOrdua + ")");
        }

        Console.WriteLine("\nAukeratu zein editatu nahi duzun (1-" + hitzorduaZerrenda.Count + "): ");
        string sarrera = Console.ReadLine();
        int aukera = 0;
        int.TryParse(sarrera, out aukera);

        if (aukera < 1 || aukera > hitzorduaZerrenda.Count)
        {
            Console.WriteLine(" Aukera okerra. ");
            return;
        }

        Hitzordua h = hitzorduaZerrenda[aukera - 1];

        Console.WriteLine("\nDatu zaharrak: ");
        Console.WriteLine("Izena: " + h.Izena);
        Console.WriteLine("Zerbitzua: " + h.Zerbitzua);

        Console.Write("\nIzen berria idatzi: ");
        string izenberria = Console.ReadLine();
        if (izenberria != "")
        {
            h.Izena = izenberria;
        }

        Console.WriteLine("\nZerbitzu berria aukeratu nahi duzu ?");
        Console.WriteLine("bai (b) / ez /(e): ");
        string er = Console.ReadLine();

        if (er == "b")
        {
            h.Zerbitzua = ZerbitzuaAukeratu();
        }

        Console.WriteLine("\nGehigarriak editatu nahi dituzu? ");
        Console.WriteLine(" bai (b) / ez (e): ");
        string er2 = Console.ReadLine();

        if (er2 == "b")
        {
            h.Gehigarria = GehigarriaAukeratu();
        }

        Console.WriteLine("\nHitzordua eguneratu da. ");
    }


    //=====================================
    // Funtzioa HitzorduKopurua
    // Zenbat hitzordu dauden erakusten du
    //=====================================

    static void HitzorduKopurua()
    {
            GarbituPantaila();
            Tituloa(" Hitzordu kopurua ");

            int kop = hitzorduaZerrenda.Count;

            Console.WriteLine(" Guztira " + kop + " hitzordu daude. ");
    }


    //======================================
    // Funtzioa GaurkoHitzorduak
    // Gaur dauden hitzorduak erakusten ditu
    //======================================

    static void GaurkoHitzorduak()
    {
        GarbituPantaila();
        Tituloa(" Gaurko hitzorduak ");

        DateTime gaur = DateTime.Today;
        bool aurkitu = false;

        foreach (Hitzordua h in hitzorduaZerrenda)
        {
            if (h.DataOrdua.Date == gaur)
            {
                aurkitu = true;

                Console.WriteLine("\nIzena: " + h.Izena);

                Console.WriteLine("Zerbitzua: " + h.Zerbitzua);

                Console.WriteLine("Data: " + h.DataOrdua);

                Console.WriteLine("Gehigarriak: ");

                foreach (string g in h.Gehigarria)
                {
                    Console.WriteLine(" - " + g);
                }
                Lerroa();
            }
        }
        
        if (!aurkitu)
        {
            Console.WriteLine(" Gaur ez dago hitzordurik. ");
        }
    }

}
