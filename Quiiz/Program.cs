
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            String Svar;

            Console.ForegroundColor
                                 = ConsoleColor.Yellow;
            Typewrite("Hej! Jag heter Walsta G. West. Välkommen till min frågesport.");
            Console.WriteLine();
            Typewrite("Är du redo?");
            Console.WriteLine();

            while (true)
            {
                Svar = Console.ReadLine().ToLower();
                if (Svar == "ja")
                {
                    Console.WriteLine();
                    Typewrite("Strålande!! Reglerna är enkla");
                    Console.WriteLine();

                    Typewrite("Jag ställer en fråga och du får 3 alternativ att välja mellan.");
                    Console.WriteLine();

                    Typewrite("Varje fråga ger olika mycket poäng beroende på frågans svårighetsnivå.");
                    Console.WriteLine();

                    Typewrite("Dessutom kommer fråga att visa hur mycket poäng man får.");
                    Console.WriteLine();

                    Typewrite("Dina antal poäng kommer i slutet att ge dig ett resultat i form av ett betyg A - F, då A är bäst och F för FALIUER.");
                    Console.WriteLine();

                    Typewrite("Efter att du har svarat på en fråga trycker du" + " (ENTER) för nästa.");
                    Console.WriteLine();

                    Typewrite("Got it?");
                    Console.WriteLine();
                    Redo();
                    break;
                }

                if (Svar == "nej")
                {
                    Console.WriteLine();
                    Typewrite("Ok!! Bry mig inte om du är redo, vi sätter igång ändå.");
                    Console.WriteLine();

                    Typewrite("Reglerna är enkla, jag ställer en fråga och du får 3 alternativ att välja mellan.");
                    Console.WriteLine();

                    Typewrite("Frågorna ger olika mycket poäng beroende på frågans svårighet. Varje fråga kommer att visa hur mycket poäng man får");
                    Console.WriteLine();

                    Typewrite("Dina antal poäng kommer i slutet att ge dig ett resultat i form av ett betyg A - F, då A är bäst och F för FALIUER.");
                    Console.WriteLine();

                    Typewrite("Efter att du har svarat på en fråga trycker du" + " (ENTER) för nästa.");
                    Console.WriteLine();

                    Typewrite("Got it?");
                    Console.WriteLine();
                    Redo();
                    break;

                }

                Console.WriteLine();
                Typewrite("Svara ja eller nej!!");
                Console.WriteLine();
                Typewrite("Är du redo?");
                Console.WriteLine();
                continue;
            }


        }

        static void Redo()
        {

            String Svar2;

            while (true)
            {
                Svar2 = Console.ReadLine().ToLower();

                if (Svar2 == "ja")
                {
                    Console.WriteLine();
                    Typewrite("Då kör vi.");
                    Console.WriteLine();
                    betyg();
                    break;
                }
                if (Svar2 == "nej")
                {
                    Console.WriteLine();
                    Typewrite("Vi sätter igång ändå!!");
                    Console.WriteLine();
                    betyg();
                    break;
                }

                Console.WriteLine();
                Typewrite("Ja eller Nej!!");
                Console.WriteLine();
                Typewrite("Got it?");
                Console.WriteLine();
                continue;
            }

        }

        static void betyg()
        {

            int Hp;
            Hp = 10000;
            String Svar3;

            Typewrite("Snabb fråga innan vi börjar vilket betyg tror du att du kommer få från A - F?");
            Console.WriteLine();
            Typewrite("A = " + Hp + " p");
            Console.WriteLine();
            Typewrite("B = " + (Hp - 2500) + " p");
            Console.WriteLine();

            Typewrite("C = " + (Hp - 3500) + " p");
            Console.WriteLine();

            Typewrite("D = " + (Hp - 4500) + " p");
            Console.WriteLine();

            Typewrite("E = " + (Hp - 5500) + " p");
            Console.WriteLine();

            Typewrite("F = " + (Hp - 6500) + " p");
            Console.WriteLine();


            while (true)
            {
                Svar3 = Console.ReadLine().ToLower();

                if (Svar3 == "a")
                {
                    Console.WriteLine();
                    Typewrite("Hahahahah!!!! DU TROR? Hahaha!! OK, OK");
                    Console.WriteLine();

                    Typewrite("Vi sätter igång.");
                    Console.WriteLine();

                    Typewrite("Tryck ENTER för att starta!");
                    Console.WriteLine();

                    Fråga1();
                    break;
                }

                if (Svar3 == "b")
                {
                    Console.WriteLine();
                    Typewrite("Hahahaha!!! Du kommer knappt att klara första frågan!!");
                    Console.WriteLine();

                    Typewrite("Men vi kör, vi kör. Visa mig att jag har fel.");
                    Console.WriteLine();

                    Typewrite("Jag har ALDRIG fel!!");
                    Console.WriteLine();

                    Typewrite("Tryck ENTER för att starta!");
                    Console.WriteLine();

                    Fråga1();
                    break;
                }

                if (Svar3 == "c")
                {
                    Console.WriteLine();
                    Typewrite("Ok, men varför inte ett A?");
                    Console.WriteLine();

                    Typewrite("Ok, ok vi sätter igång!");
                    Console.WriteLine();

                    Typewrite("Tryck ENTER för att starta!");
                    Console.WriteLine();

                    Fråga1();
                    break;
                }

                if (Svar3 == "d")
                {
                    Console.WriteLine();
                    Typewrite("Ok, någon satsar ganska lågt.");
                    Console.WriteLine();

                    Typewrite("Det kanske går bättre än vad man förväntar sig");
                    Console.WriteLine();

                    Typewrite("Tryck ENTER för att starta!");
                    Console.WriteLine();

                    Fråga1();
                    break;
                }

                if (Svar3 == "e")
                {
                    Console.WriteLine();
                    Typewrite("Varför satsar du så lågt? Man ska satsa högt.");
                    Console.WriteLine();

                    Typewrite("Man ska sikta på molnen.");
                    Console.WriteLine();

                    Typewrite("Men ok, Vi kör.");
                    Console.WriteLine();

                    Typewrite("Tryck ENTER för att starta!");
                    Console.WriteLine();

                    Fråga1();
                    break;
                }

                if (Svar3 == "f")
                {
                    Console.WriteLine();
                    Typewrite("Mmm........:/");
                    Console.WriteLine();

                    Typewrite("Aha starta ok. Det var väl det du sa ok. Vi sätter igång.");
                    Console.WriteLine();

                    Typewrite("Tryck ENTER för att starta!");
                    Console.WriteLine();

                    Fråga1();
                    break;
                }

                Console.WriteLine();
                Typewrite("Vilket betyg tror du att du kommer få från A - F?");
                Console.WriteLine();
                Typewrite("A, B, C, D, E eller F?");
                Console.WriteLine();
                continue;
            }
        }

        static void Fråga1()
        {


            Random number = new Random();
            int score = number.Next(80, 150);

            String Svar4;

            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 1: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Vad heter USAs första president?");
            Console.WriteLine();

            Typewrite("1. George Washington");
            Console.WriteLine();

            Typewrite("X. Geogre Washington");
            Console.WriteLine();

            Typewrite("2. George Wasington");
            Console.WriteLine();

            while (true)
            {

                Svar4 = Console.ReadLine().ToLower();

                if (Svar4 == "1")
                {
                    Console.ForegroundColor
                             = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Korrekt Svar!");
                    Console.WriteLine();

                    Console.ForegroundColor
                                                = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    Fråga2();
                    break;
                }

                if (Svar4 == "x" || Svar4 == "2")
                {
                    Console.ForegroundColor
                                     = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Felaktigt Svar");
                    Console.WriteLine();

                    Typewrite("Hahah!!");
                    Console.WriteLine();

                    Console.ForegroundColor
                                 = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    Fråga2();
                    break;
                }

                Console.ForegroundColor
                                                   = ConsoleColor.Yellow;
                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vad heter USAs första president?");
                Console.WriteLine();
                Typewrite("1. George Washington");
                Console.WriteLine();
                Typewrite("X. Geogre Washington");
                Console.WriteLine();
                Typewrite("2. George Wasington");
                Console.WriteLine();
                continue;
            }


        }

        static void Fråga2()
        {

            Random number = new Random();
            int score = number.Next(50, 90);

            string svar5;

            Console.ForegroundColor
                = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 2: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Heter det “en rak kurva” eller heter det “ett rak kurva”?");
            Console.WriteLine();
            Typewrite("1. En rak kurva.");
            Console.WriteLine();
            Typewrite("X. Ett rak kurva.");
            Console.WriteLine();
            Typewrite("2. Det finns inga raka kurvor");
            Console.WriteLine();

            while (true)
            {

                svar5 = Console.ReadLine().ToLower();

                if (svar5 == "1" || svar5 == "x")
                {

                    Console.ForegroundColor
                    = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Felaktigt Svar");
                    Console.WriteLine();

                    Typewrite("Hahah!!");
                    Console.WriteLine();

                    Console.ForegroundColor
                    = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga3();
                    break;
                }

                if (svar5 == "2")
                {

                    Console.ForegroundColor
                               = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Korrekt Svar!");
                    Console.WriteLine();

                    Console.ForegroundColor
                                      = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga3();
                    break;
                }

                Console.ForegroundColor
                      = ConsoleColor.Yellow;
                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Heter det “en rak kurva” eller heter det “ett rak kurva”?");
                Console.WriteLine();
                Typewrite("1. En rak kurva.");
                Console.WriteLine();
                Typewrite("X. Ett rak kurva.");
                Console.WriteLine();
                Typewrite("2. Det finns inga raka kurvor");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga3()
        {

            Random number = new Random();
            int score = number.Next(1345, 2422);

            Console.ForegroundColor
                                = ConsoleColor.Yellow;

            string svar6;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 3: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Vad är meningen med livet?");
            Console.WriteLine();
            Typewrite("1. Att leva så gott man kan.");
            Console.WriteLine();
            Typewrite("X. Jag vet inte");
            Console.WriteLine();
            Typewrite("2. Du vet.");
            Console.WriteLine();

            while (true)
            {

                svar6 = Console.ReadLine().ToLower();

                if (svar6 == "1")
                {

                    Console.ForegroundColor
                    = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahaha!! det säger alla");
                    Console.WriteLine();
                    Typewrite("Bara för att får du fel på frågan, Hahaha!");
                    Console.WriteLine();


                    Console.ForegroundColor
                    = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga4();
                    break;
                }

                if (svar6 == "x")
                {

                    Console.ForegroundColor
                    = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("?????????");
                    Console.WriteLine();
                    Typewrite("Om inte du vet, vem ska då veta?");
                    Console.WriteLine();
                    Typewrite("Vad vet du?");
                    Console.WriteLine();
                    Typewrite("Vi får se hur det går i nästa fråga.");
                    Console.WriteLine();

                    Console.ForegroundColor
               = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga4();
                    break;
                }

                if (svar6 == "2")
                {

                    Console.ForegroundColor
                    = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hur ska jag veta det??");
                    Console.WriteLine();
                    Typewrite("Jag finns inte!!");
                    Console.WriteLine();

                    Console.ForegroundColor
               = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga4();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vad är meningen med livet?");
                Console.WriteLine();
                Typewrite("1. Att leva så gott man kan.");
                Console.WriteLine();
                Typewrite("X. Jag vet inte");
                Console.WriteLine("");
                Typewrite("2. Du vet.");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga4()
        {

            Random number = new Random();
            int score = number.Next(500, 800);

            string svar7;

            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 4: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Hur många sekunder har det gått mellan åren 2000 - 2019?");
            Console.WriteLine();
            Typewrite("1. 713 547 000s");
            Console.WriteLine();
            Typewrite("X. 459 854 000s");
            Console.WriteLine();
            Typewrite("2. 631 065 600s");
            Console.WriteLine();

            while (true)
            {

                svar7 = Console.ReadLine().ToLower();

                if (svar7 == "1" || svar7 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahah!!");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
= ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga5();
                    break;
                }

                if (svar7 == "2")
                {
                    Console.ForegroundColor
                          = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Korrekt svar!!");
                    Console.WriteLine();
                    Typewrite("Grattis!!");
                    Console.WriteLine();

                    Console.ForegroundColor
                                              = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga5();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Hur många sekunder har det gått mellan åren 2000 - 2019?");
                Console.WriteLine();
                Typewrite("1. 713 547 000s");
                Console.WriteLine();
                Typewrite("X. 459 854 000s");
                Console.WriteLine();
                Typewrite("2. 631 065 600s");
                Console.WriteLine();
                continue;

            }

        }

        static void fråga5()
        {

            Random number = new Random();
            int score = number.Next(300, 500);

            string svar8;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 5: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Vilken färg har spegeln?");
            Console.WriteLine();
            Typewrite("1. Har spegeln färg?.");
            Console.WriteLine();
            Typewrite("X. Vet inte.");
            Console.WriteLine();
            Typewrite("2. Spegeln har ingen färg .");
            Console.WriteLine();

            while (true)
            {

                svar8 = Console.ReadLine().ToLower();

                if (svar8 == "1")
                {
                    Console.ForegroundColor
      = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Bra där!!!");
                    Console.WriteLine();
                    Typewrite("HELT RÄTT!!");
                    Console.WriteLine();

                    Console.ForegroundColor
     = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga6();
                    break;
                }

                if (svar8 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahah!!");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();
                    Typewrite("Kommer du att svara så där på alla frågor?");
                    Console.WriteLine();

                    Console.ForegroundColor
   = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga6();
                    break;

                }

                if (svar8 == "2")
                {
                    Console.ForegroundColor
                          = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Spegeln har visst en färg!");
                    Console.WriteLine();
                    Typewrite("Den har får färgen av omgivningen.");
                    Console.WriteLine();
                    Typewrite("Om du vinklar spegeln på en röd matta blir spegeln röd.");
                    Console.WriteLine();

                    Console.ForegroundColor
      = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga6();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vilken färg har spegeln?");
                Console.WriteLine();
                Typewrite("1. Har spegeln färg?.");
                Console.WriteLine();
                Typewrite("X. Vet inte.");
                Console.WriteLine();
                Typewrite("2. Spegeln har ingen färg .");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga6()
        {

            Random number = new Random();
            int score = number.Next(1500, 2500);

            string svar9;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 6: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Är det här en bra fråga?");
            Console.WriteLine();
            Typewrite("1. Ja.");
            Console.WriteLine();
            Typewrite("X. Är det här ett bra svar?");
            Console.WriteLine();
            Typewrite("2. Jag vet inte.");
            Console.WriteLine();

            while (true)
            {

                svar9 = Console.ReadLine().ToLower();

                if (svar9 == "1")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hur vet du det?");
                    Console.WriteLine();
                    Typewrite("Felaktigt SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
      = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga7();
                    break;
                }

                if (svar9 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Sen när blev du en psykolog?");
                    Console.WriteLine();
                    Typewrite("JAG är den som ställer frågorna här!!");
                    Console.WriteLine();

                    Console.ForegroundColor
 = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga7();
                    break;

                }

                if (svar9 == "2")
                {
                    Console.ForegroundColor
                          = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("........................................:/");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!!");
                    Console.WriteLine();

                    Console.ForegroundColor
 = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga7();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Är det här en bra fråga?");
                Console.WriteLine();
                Typewrite("1. Ja.");
                Console.WriteLine();
                Typewrite("X. Är det här ett bra svar?");
                Console.WriteLine();
                Typewrite("2. Jag vet inte.");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga7()
        {

            Random number = new Random();
            int score = number.Next(230, 545);

            string svar10;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 7: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("När du var i min ålder kunde du inte prata.");
            Console.WriteLine();
            Typewrite("Hur gammar är jag?");
            Console.WriteLine();
            Typewrite("1. 11 månader gammal.");
            Console.WriteLine();
            Typewrite("X. Jag fanns inte.");
            Console.WriteLine();
            Typewrite("2. Du fanns inte.");
            Console.WriteLine();

            while (true)
            {

                svar10 = Console.ReadLine().ToLower();

                if (svar10 == "1")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahaha!! Jag har aldrig kunnat prata.");
                    Console.WriteLine();
                    Typewrite("Finns jag ens?");
                    Console.WriteLine();
                    Typewrite("Felaktigt SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
          = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga8();
                    break;
                }

                if (svar10 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Vad menar du med att du inte fanns?");
                    Console.WriteLine();
                    Typewrite("What??");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
                       = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga8();
                    break;

                }

                if (svar10 == "2")
                {
                    Console.ForegroundColor
                          = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Jag skapades för ett par veckor sen");
                    Console.WriteLine();
                    Typewrite("Korrekt svar!!!");
                    Console.WriteLine();

                    Console.ForegroundColor
                         = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng:" + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga8();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("När du var i min ålder kunde du inte prata.");
                Console.WriteLine();
                Typewrite("Hur gammar är jag?");
                Console.WriteLine();
                Typewrite("1. 11 månader gammal.");
                Console.WriteLine();
                Typewrite("X. Jag fanns inte.");
                Console.WriteLine();
                Typewrite("2. Du fanns inte.");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga8()
        {

            Random number = new Random();
            int score = number.Next(400, 800);
            string svar11;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 8: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Om du njuter av att slösa tid, är den tiden bortkastad?");
            Console.WriteLine();
            Typewrite("1. Ja");
            Console.WriteLine();
            Typewrite("X. Det är upp till än själv att bestämma.");
            Console.WriteLine();
            Typewrite("2. Nej");
            Console.WriteLine();

            while (true)
            {

                svar11 = Console.ReadLine().ToLower();

                if (svar11 == "1" || svar11 == "2")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahahah!!!");
                    Console.WriteLine();
                    Typewrite("Felaktigt SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
      = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga9();
                    break;
                }

                if (svar11 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Korrekt Svar!!");
                    Console.WriteLine();

                    Console.ForegroundColor
   = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga9();
                    break;

                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Fråga 8: XX p");
                Console.WriteLine();
                Typewrite("Om du njuter av att slösa tid, är den tiden bortkastad?");
                Console.WriteLine();
                Typewrite("1. Ja");
                Console.WriteLine();
                Typewrite("X. Det är upp till än själv att bestämma.");
                Console.WriteLine();
                Typewrite("2. Nej");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga9()
        {

            Random number = new Random();
            int score = number.Next(100, 350);
            string svar12;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 9: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Vad är 1-800 273 8255?");
            Console.WriteLine();
            Typewrite("1. En låt");
            Console.WriteLine();
            Typewrite("X. Koordinater");
            Console.WriteLine();
            Typewrite("2. Nej");
            Console.WriteLine();

            while (true)
            {

                svar12 = Console.ReadLine().ToLower();

                if (svar12 == "1")
                {
                    Console.ForegroundColor
      = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Korrekt svar!!");
                    Console.WriteLine();

                    Console.ForegroundColor
     = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga10();
                    break;
                }

                if (svar12 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Koordinater till vad?");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
     = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga10();
                    break;

                }

                if (svar12 == "2")
                {
                    Console.ForegroundColor
    = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Vad menar du med NEJ??");
                    Console.WriteLine();
                    Typewrite("Felaktigt SVAR!!");
                    Console.WriteLine();

                    Console.ForegroundColor
        = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga10();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vad är 1-800 273 8255?");
                Console.WriteLine();
                Typewrite("1. En låt");
                Console.WriteLine();
                Typewrite("X. Koordinater");
                Console.WriteLine();
                Typewrite("2. Nej");
                Console.WriteLine();
                continue;

            }

        }
        static void fråga10()
        {

            Random number = new Random();
            int score = number.Next(500, 900);
            string svar13;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 10: " + score + " Poäng");
            Console.WriteLine();
            Typewrite("Sista frågan.");
            Console.WriteLine();
            Typewrite("Vad är 56 024 498 248 094 m/s i km/h?");
            Console.WriteLine();
            Typewrite("1. 342 658 345 235 642 km/h");
            Console.WriteLine();
            Typewrite("X. 201 688 193 693 138 km/h");
            Console.WriteLine();
            Typewrite("2. 453 552 235 756 352 km/h");
            Console.WriteLine();

            while (true)
            {

                svar13 = Console.ReadLine().ToLower();

                if (svar13 == "1" || svar13 == "2")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();
                    Typewrite("Hahaha!!!");
                    Console.WriteLine();

                    Console.ForegroundColor
        = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: 0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    resultat();
                    break;
                }

                if (svar13 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Du hade bara tur.");
                    Console.WriteLine();
                    Typewrite("Grattis!!");
                    Console.WriteLine();
                    Typewrite("Korrekt svar!!");
                    Console.WriteLine();

                    Console.ForegroundColor
      = ConsoleColor.Cyan;
                    Typewrite("InFörskaffade Poäng: " + score + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    resultat();
                    break;

                }

                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vad är 56 024 498 248 094 m/s i km/h?");
                Console.WriteLine();
                Typewrite("1. 342 658 345 235 642 km/h");
                Console.WriteLine();
                Typewrite("X. 201 688 193 693 138 km/h");
                Console.WriteLine();
                Typewrite("2. 453 552 235 756 352 km/h");
                Console.WriteLine();
                continue;

            }
        }

        static void resultat()
        {

            int Hp;
            Hp = 10000;

            Console.ForegroundColor
        = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Tryck på ENTER för att se ditt resultat!");
            Console.WriteLine();
            Console.ReadLine();

            Typewrite("A = " + Hp + " p");
            Console.WriteLine();

            Typewrite("B = " + (Hp - 2500) + " p");
            Console.WriteLine();

            Typewrite("C = " + (Hp - 3500) + " p");
            Console.WriteLine();

            Typewrite("D = " + (Hp - 4500) + " p");
            Console.WriteLine();

            Typewrite("E = " + (Hp - 5500) + " p");
            Console.WriteLine();

            Typewrite("F = " + (Hp - 6500) + " p");
            Console.WriteLine();
            Console.WriteLine();

            Typewrite("Tryck ENTER för att beräkna ditt resultat!");
            Console.WriteLine();
            Console.ReadLine();

            Console.ForegroundColor
                            = ConsoleColor.Green;
            Typewrite2("Beräknar resultat:.........2%..........14%...........24%............32%...............47%.................55%....");
            Console.WriteLine();
            Typewrite2("................61%................72%..........89%.............96%...........100%");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor
                = ConsoleColor.Yellow;

            Typewrite3("#Quiiz" + "(Walsta,G)");
            Console.WriteLine();
            Typewrite3("#Includera Frågor" + "'FrÅGa 1-10'");
            Console.WriteLine();
            Typewrite3("All Function[] {");
            Console.WriteLine();
            Typewrite3("System Svar = HuvudSystem:::Svar_Korrekt!!%¤[]:");
            Console.WriteLine();
            Typewrite3("Q -> Visning [Tillfärlig_encrypterings_nyckel[] ]");
            Console.WriteLine();
            Typewrite3("Q -> Kalkylerar: Analyserar[LDFEIH242&434]");
            Console.WriteLine();
            Typewrite3("HuvudSystem:::Tillgång[Tillfärlig_encrypterings_nyckel[[[]]]]");
            Console.WriteLine();
            Typewrite3("HuvudSystem:::SvarTillgång ->Öppnar[IOAND03E30FE]");
            Console.WriteLine();
            Typewrite3("Använder HuvudSystem:::LightControl;");
            Console.WriteLine();
            Typewrite3("Ljus*i = hämtar_inställningar_Regler[Nurvarande[]]i");
            Console.WriteLine();
            Typewrite3("}");
            Console.WriteLine();
            Console.WriteLine();
            Typewrite3("Gör {");
            Console.WriteLine();
            Typewrite3("TillåtTillträde_Vem->Spelare[HP-DATOR]");
            Console.WriteLine();
            Typewrite3("D7EJNI9394. PRIO1::[HIGHEST]:");
            Console.WriteLine();
            Typewrite3("!->[00.769]");
            Console.WriteLine();
            Typewrite3("!->Färg[rgb(240,255,240)]");
            Console.WriteLine();
            Typewrite3("}");
            Console.WriteLine();
            Console.WriteLine();
            Typewrite3("Hämta {");
            Console.WriteLine();
            Typewrite3("Tillträde->WALSTA.G:::[SystemUppdaterar0.34542M");
            Console.WriteLine();
            Typewrite3("#Fråga 1 - Fråga 3->Svar:::********");
            Console.WriteLine();
            Typewrite3("#Fråga 4 - Fråga 7->Svar:::********");
            Console.WriteLine();
            Typewrite3("#Fråga 8 - Fråga 10->Svar:::********");
            Console.WriteLine();
            Typewrite3("System:::Tillträde 1File[3VQEEDWN]");
            Console.WriteLine();
            Typewrite3("System:::Tillträde 2File[9EDCRCE5]");
            Console.WriteLine();
            Typewrite3("System:::Tillträde 3File[QYFQ8DST]");
            Console.WriteLine();
            Typewrite3("System:::Tillträde 4File[DCJAUC52]");
            Console.WriteLine();
            Typewrite3("}");
            Console.WriteLine();
            Console.WriteLine();
            Typewrite3("Funktion Huvud2[] {");
            Console.WriteLine();
            Typewrite3("Tillträde[Tillfärlig_encrypterings_nyckel]");
            Console.WriteLine();
            Typewrite3("Resultat:::Överför[]");
            Console.WriteLine();
            Typewrite3("FW_UnBind[]");
            Console.WriteLine();
            Typewrite3("FW::QUIIZ_Backdörr_Kopplar");
            Console.WriteLine();
            Typewrite3("Tillåt_TILLTRÄDE_WALSTA.G[LÅSER UPP]");
            Console.WriteLine();
            Typewrite3("4K-KALKYLERAR");
            Console.WriteLine();
            Typewrite3("}");
            Console.WriteLine();
            Console.WriteLine();
            Typewrite3("System ->> Analysera meny[INNEHÅLL]");
            Console.WriteLine();
            Typewrite3("File-Innehåll[[ÖPPNA]]");
            Console.WriteLine();
            Typewrite3("Spelar:ID[2D*******5R]");
            Console.WriteLine();
            Typewrite3("DatorBattery[[***%]]");
            Console.WriteLine();
            Typewrite3("Språk[Svenska]");
            Console.WriteLine();
            Typewrite3("Skärm[Länkar]");
            Console.WriteLine();
            Typewrite3("WI-FI.TN_***********");
            Console.WriteLine();
            Typewrite3("System[X45O]::AI[¤]");
            Console.WriteLine();
            Typewrite3("AI [1]");
            Console.WriteLine();
            Typewrite3("AI [2]");
            Console.WriteLine();
            Typewrite3("AI [3]");
            Console.WriteLine();
            Typewrite3("AI [4]");
            Console.WriteLine();
            Typewrite3("AI...:...WALSTA.G[WEST]");
            Console.WriteLine();
            Typewrite3("TextT[¤5%] <= [STORLEK] Z-9]]");
            Console.WriteLine();
            Typewrite3("Svar[$]0,56344 GB=> 000000,234");
            Console.WriteLine();

            Console.ForegroundColor
                = ConsoleColor.Red;
            Typewrite2("ERROR:!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();


            Console.ForegroundColor
                = ConsoleColor.Yellow;
            Typewrite("Tyvär gick det inte att få fram ditt resultat:(");
            Console.WriteLine();
            Typewrite("Hej då!");
            Console.ReadLine();

        }

        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(10);
            }
        }

        static void Typewrite2(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(80);
            }
        }

        static void Typewrite3(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}