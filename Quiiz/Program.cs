﻿
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
            Hp = 5000;
            String Svar3;

            Typewrite("Snabb fråga innan vi börjar vilket betyg tror du att du kommer få från A - F?");
            Console.WriteLine();
            Typewrite("A = " + Hp + " p");
            Console.WriteLine();
            Typewrite("B = " + (Hp - 1250) + " p");
            Console.WriteLine();

            Typewrite("C = " + (Hp - 2500) + " p");
            Console.WriteLine();

            Typewrite("D = " + (Hp - 3250) + " p");
            Console.WriteLine();

            Typewrite("E = " + (Hp - 3750) + " p");
            Console.WriteLine();

            Typewrite("F = " + (Hp - 5000) + " p");
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
                    Typewrite("Ok, någon satsar lågt.");
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
            int score = number.Next(1, 150);
            int Hp;
            Hp = 500;

            String Svar4;

            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga1:" + Hp + " Poäng");
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

                    Typewrite("Dina poäng: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Fråga2();

                    break;
                }

                if (Svar4 == "x")
                {
                    Console.ForegroundColor
                                     = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Felaktigt Svar");
                    Console.WriteLine();

                    Typewrite("Hahah!!");
                    Console.WriteLine();

                    Typewrite(Hp - 500 + " p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    Fråga2();
                    break;
                }


                if (Svar4 == "2")
                {
                    Console.ForegroundColor
                                     = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Felaktigt Svar");
                    Console.WriteLine();

                    Typewrite("Hahah!!");
                    Console.WriteLine();

                    Typewrite(Hp - 500 + " p");
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

            int Hp;
            Hp = 2000;
            string svar5;

            Console.ForegroundColor
                = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 2: XX Poäng");
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
                if (svar5 == "1")
                {

                    Console.ForegroundColor
                    = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Felaktigt Svar");
                    Console.WriteLine();

                    Typewrite("Hahah!!");
                    Console.WriteLine();

                    Typewrite("0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine();
                    fråga3();
                    break;
                }

                if (svar5 == "x")
                {
                    Console.ForegroundColor
                               = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Felaktigt Svar");
                    Console.WriteLine();

                    Typewrite("Hahah!!");
                    Console.WriteLine();

                    Typewrite("0 p");
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

                    Typewrite("Dina poäng: ");
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

            Console.ForegroundColor
                                = ConsoleColor.Yellow;

            string svar6;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 3: XX p");
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
                    Typewrite("0 p");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("0 p");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("0 p");
                    Console.WriteLine();
                    Console.ResetColor();
                    fråga4();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vad är meningen med livet?");
                Console.WriteLine();
                Typewrite("1. Att leva så gott man kan.");
                Console.ReadLine();
                Typewrite("X. Jag vet inte");
                Console.WriteLine("");
                Typewrite("2. Du vet.");
                Console.WriteLine();
                continue;
            }

        }

        static void fråga4()
        {

            string svar7;

            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 4: XX p");
            Console.WriteLine();
            Typewrite("Vem har mest hår?");
            Console.WriteLine();
            Typewrite("En Apa eller Människa?");
            Console.WriteLine();
            Typewrite("1. Apa.");
            Console.WriteLine();
            Typewrite("X. Människa.");
            Console.WriteLine();
            Typewrite("2. De har lika mycket.");
            Console.WriteLine();

            while (true)
            {

                svar7 = Console.ReadLine().ToLower();

                if (svar7 == "1")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahah!!");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
                    fråga5();
                    break;
                }

                if (svar7 == "x")
                {
                    Console.ForegroundColor
      = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("Hahah!!");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!");
                    Console.WriteLine();
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("Dina poäng: ");
                    Console.ReadLine();
                    Console.ResetColor();
                    fråga5();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
                Console.WriteLine();
                Typewrite("Vem har mest hår?");
                Console.WriteLine();
                Typewrite("En Apa eller Människa?");
                Console.WriteLine();
                Typewrite("1. Apa.");
                Console.WriteLine();
                Typewrite("X. Människa.");
                Console.WriteLine();
                Typewrite("2. De har lika mycket.");
                Console.WriteLine();
                continue;

            }

        }

        static void fråga5()
        {

            string svar8;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 5: XX p");
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("Kommer du att svara sådär på alla frågor?");
                    Console.WriteLine();
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("Dina poäng: ");
                    Console.ReadLine();
                    Console.ResetColor();
                    fråga6();
                    break;
                }

                Console.WriteLine();
                Typewrite("Svara med 1, X eller 2!");
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

            string svar9;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 6: XX p");
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
                    fråga7();
                    break;

                }

                if (svar9 == "2")
                {
                    Console.ForegroundColor
                          = ConsoleColor.Red;
                    Console.WriteLine();
                    Typewrite("........................................");
                    Console.WriteLine();
                    Typewrite("FELAKTIGT SVAR!!!");
                    Console.WriteLine();
                    Typewrite("Dina poäng: ");
                    Console.ReadLine();
                    Console.ResetColor();
                    fråga7();
                    break;
                }


            }

        }

        static void fråga7()
        {

            string svar10;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 7: XX p");
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
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
                    Typewrite("Dina poäng: ");
                    Console.ReadLine();
                    Console.ResetColor();
                    fråga8();
                    break;
                }


            }

        }

        static void fråga8()
        {

            string svar11;

            Console.ForegroundColor
                      = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.WriteLine();
            Typewrite("Fråga 7: XX p");
            Console.WriteLine();
            Typewrite("När du v");
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

                svar11 = Console.ReadLine().ToLower();

                if (svar11 == "1")
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
                    fråga8();
                    break;
                }

                if (svar11 == "x")
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
                    Typewrite("Dina poäng: ");
                    Console.WriteLine();
                    Console.ResetColor();
                    fråga8();
                    break;

                }

                if (svar11 == "2")
                {
                    Console.ForegroundColor
                          = ConsoleColor.Green;
                    Console.WriteLine();
                    Typewrite("Jag skapades för ett par veckor sen");
                    Console.WriteLine();
                    Typewrite("Korrekt svar!!!");
                    Console.WriteLine();
                    Typewrite("Dina poäng: ");
                    Console.ReadLine();
                    Console.ResetColor();
                    fråga8();
                    break;
                }


            }

        }

        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
