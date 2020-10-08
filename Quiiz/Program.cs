
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
            Typewrite("Hej! Jag heter Walsta G. Välkommen till mitt frågesport.");
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
            }

            if (Svar3 == "e")
            {
                Console.WriteLine();
                Typewrite("Varför satsar du så lågt? Man ska satsa högt.");
                Console.WriteLine();

                Typewrite("Man ska sikta på molnen");
                Console.WriteLine();

                Typewrite("Men ok, Vi kör.");
                Console.WriteLine();

                Typewrite("Tryck ENTER för att starta!");
                Console.WriteLine();

                Fråga1();
            }

            if (Svar3 == "f")
            {
                Console.WriteLine();
                Typewrite("Mmm........:/");
                Console.WriteLine();

                Typewrite("Aha starta ok. Det var väll det du sa ok. Vi sätter igång.");
                Console.WriteLine();

                Typewrite("Tryck ENTER för att starta!");
                Console.WriteLine();

                Fråga1();
            }

            Console.ReadLine();
        }

        static void Fråga1()
        {


            Random number = new Random();
            int score = number.Next(1, 1000);
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

            Svar4 = Console.ReadLine().ToLower();

            if (Svar4 == "1")
            {
                Console.ForegroundColor
                         = ConsoleColor.Green;
                Console.WriteLine();
                Typewrite("Korrekt Svar!");
                Console.WriteLine();

                Typewrite("Your score:");
                Console.ResetColor();
            }

            else if (Svar4 != "1")
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

            }

            Console.ReadLine();

        }

        static void Fråga2()
        {
            string svar5;


            Typewrite("Fråga 2: XX Poäng");
            Console.WriteLine();
            Typewrite("Fråga inte tillgänlig");


            svar5 = Console.ReadLine().ToLower();



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