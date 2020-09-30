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
            Console.WriteLine("Hej! Jag heter Uwuwewewe onyetenwewe ugweuhem osas. Välkommen till mitt frågesport.");
            Console.WriteLine("Är du redo?");
            Svar = Console.ReadLine().ToLower();


            if (Svar == "ja")
            {
                Console.WriteLine();
                Console.WriteLine("Strålande!! Reglerna är enkla");
                Console.WriteLine("Jag ställer en fråga och du får 3 alternativ att välja mellan.");
                Console.WriteLine("Varje fråga ger olika mycket poäng beroende på frågans svårighetsnivå.");
                Console.WriteLine("Dessutom kommer fråga att visa hur mycket poäng man får.");
                Console.WriteLine("Dina antal poäng kommer i slutet att ge dig ett resultat i form av ett betyg A - F, då A är bäst och F för FALIUER.");
                Console.WriteLine("Got it?");
                Redo();
            }

            if (Svar == "nej")

            {
                Console.WriteLine();
                Console.WriteLine("Ok!! Bry mig inte om du är redo, vi sätter igång ändå.");
                Console.WriteLine("Reglerna är enkla, jag ställer en fråga och du får 3 alternativ att välja mellan.");
                Console.WriteLine("Frågorna ger olika mycket poäng beroende på frågans svårighet. Varje fråga kommer att visa hur mycket poäng man får");
                Console.WriteLine("Dina antal poäng kommer i slutet att ge dig ett resultat i form av ett betyg A - F, då A är bäst och F för FALIUER.");
                Console.WriteLine("Got it?");
                Redo();

                if (Svar == "ok")
                {
                    Console.WriteLine();
                    Console.WriteLine("Mmmm..........ok!!");
                    Console.WriteLine("Reglerna är enkla, jag ställer en fråga och du frå 3 alternativ. Rätt svar ger olika mycket poäng. Varje fråga kommer att visa hur mycket poöng man får.");
                    Console.WriteLine("Dina antal poäng kommer att ge dig ett resultat i form av ett betyg A - F, då A är bäst och F för FALIUER.");
                    Console.WriteLine("Got it?");
                    Redo();
                }

            }

            Console.ReadLine();

        }

        static void Redo()
        {

            int Hp;
            Hp = 5000;
            String Svar2;
            Svar2 = Console.ReadLine().ToLower();

            if (Svar2 == "ja")
            {
                Console.WriteLine();
                Console.WriteLine("Då kör vi.");
                betyg();
            }
            if (Svar2 == "nej")
            {
                Console.WriteLine();
                Console.WriteLine("Vi sätter igång ändå!!");
                betyg();
            }
            Console.ReadLine();
        }

        static void betyg()
        {

            int Hp;
            Hp = 5000;
            String Svar3;

            Console.WriteLine("Snabb fråga innan vi börjar vilket betyg tror du att du kommer få från A - F?");
            Console.WriteLine();
            Console.WriteLine("A = " + Hp + " p");
            Console.WriteLine("B = " + (Hp - 1250) + " p");
            Console.WriteLine("C = " + (Hp - 2500) + " p");
            Console.WriteLine("D = " + (Hp - 3250) + " p");
            Console.WriteLine("E = " + (Hp - 3750) + " p");
            Console.WriteLine("F = " + (Hp - 5000) + " p");

            Svar3 = Console.ReadLine().ToLower();

            if (Svar3 == "a")
            {
                Console.WriteLine();
                Console.WriteLine("Hahahahah!!!! DU TROR? Hahaha!! OK, OK");
                Console.WriteLine("Vi sätter igång.");
                Console.WriteLine("Tryck ENTER för att starta!");
                Fråga1();
            }

            if (Svar3 == "b")
            {
                Console.WriteLine();
                Console.WriteLine("Hahahaha!!! Du kommer knappt att klara första frågan!!");
                Console.WriteLine("Men vi kör, vi kör. Visa mig att jag har fel.");
                Console.WriteLine("Jag har ALDRIG fel!!");
                Console.WriteLine("Tryck ENTER för att starta!");
                Fråga1();
            }

            if (Svar3 == "c")
            {
                Console.WriteLine();
                Console.WriteLine("Ok, men varför inte ett A? Satsar du så lågt haha!!!");
                Console.WriteLine("Ok, ok vi sätter igång!");
                Console.WriteLine("Tryck ENTER för att starta!");
                Fråga1();
            }

            if (Svar3 == "d")
            {
                Console.WriteLine();
                Console.WriteLine("Ok, någon satsar lågt.");
                Console.WriteLine("Det kanske går bättre än vad man förväntar sig");
                Console.WriteLine("Tryck ENTER för att starta!");
                Fråga1();
            }

            if (Svar3 == "e")
            {
                Console.WriteLine();
                Console.WriteLine("Varför satsar du så lågt? Man ska satsa högt.");
                Console.WriteLine("Man ska sikta på molnen");
                Console.WriteLine("Men ok, Vi kör.");
                Console.WriteLine("Tryck ENTER för att starta!");
                Fråga1();
            }

            if (Svar3 == "f")
            {
                Console.WriteLine();
                Console.WriteLine("Mmm........:/");
                Console.WriteLine("Aha starta ok. Det var väll det du sa ok. Vi sätter igång.");
                Console.WriteLine("Tryck ENTER för att starta!");
                Fråga1();
            }

            Console.ReadLine();
        }

        static void Fråga1()
        {

            int Hp;
            Hp = 500;

            String Svar4;

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Fråga1:" + Hp + " Poäng");
            Console.WriteLine();
            Console.WriteLine("Vad heter USAs första president?");
            Console.WriteLine("1. George Washington");
            Console.WriteLine("X. Geogre Washington");
            Console.WriteLine("2. George Wasington");
            Svar4 = Console.ReadLine().ToLower();

            if (Svar4 == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Korrekt Svar.");
                Console.WriteLine(Hp + " p");
            }

            else if (Svar4 != "1")
            {
                Console.WriteLine();
                Console.WriteLine("Felaktigt Svar");
                Console.WriteLine("Hahah!!");

                Console.WriteLine(Hp - 500 + " p");

            }

            Console.ReadLine();

        }

        static void Fråga2()
        {
            string svar5;

            Console.WriteLine("Fråga 2: XX Poäng");
            Console.WriteLine();
            Console.WriteLine();


            svar5 = Console.ReadLine().ToLower();



        }
    }
}

