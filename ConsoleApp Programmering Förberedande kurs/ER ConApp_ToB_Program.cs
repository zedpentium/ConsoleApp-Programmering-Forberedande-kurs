using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_Programmering_Förberedande_kurs
{
    class ERConMain
    {
        private static bool ValdFarg = true;

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menyn();
            }

        }
        private static bool Menyn()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---< Välkommen till Eric Rönnhults T&B ConApp >---:");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;

            if (ValdFarg == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("Menyval för funktioner:");
            Console.WriteLine();
            Console.WriteLine("1) Skriv ut Hello World");
            Console.WriteLine("2) Mata in Namn, Efternamn, Ålder, och skriv ut");
            Console.WriteLine("3) Byt textfärg. Om du sedan väljer detta igen så ändras färgen tillbaka");
            Console.WriteLine("4) Skriv ut dagens datum");
            Console.WriteLine("5) Mata in 2 värden, och skriva ut vilket som är störst");
            Console.WriteLine("6) Genererar ett slumptal mellan 1 & 100. Gissa talet");
            Console.WriteLine("7) Skriv in en textrad som sparas ner i en fil");
            Console.WriteLine("8) Läs in fil från 7 OM den existerar och skriv ut innehåll");
            Console.WriteLine("9) Skriv in decimaltal, få roten ur, upphöjt till 2 och 10");
            Console.WriteLine("10) Skriv ut multiplikationstabell 1 till 10");
            Console.WriteLine("11) Skapa 2 arrayer, första med slumpmässiga tal, den andra med dessa tal o stigande ordning");
            Console.WriteLine("12) Skriv in något, och kollar om det är en palindrom (vändbart ord, så som abba)");
            Console.WriteLine("13) Skriv in 2 tal mellan 1 och 30, och skriver ut alla tal emellan");
            Console.WriteLine("14) EJ FÄRDIG ! Skriv in ett antal komma-separerade siffror, som sorteras & skrivs ut som udda och jämna värden");
            Console.WriteLine("15) EJ GJORT ! Skriv in ett antal komma-separerade siffror, som adderas, summeras & skrivs ut");
            Console.WriteLine("16) Ange namn på din karaktär & motståndare. Genererar slumptals-värden för Hälsa, Styrka & Tur.");
            Console.WriteLine("0) Avsluta programmet");

            Console.Write("\r\nSkriv in NR på menyval & tryck enter: ");

            switch (Console.ReadLine())
            {
                case "1":
                    HelloCon();
                    return true;
                case "2":
                    SkrivutInput();
                    return true;
                case "3":
                    TextFargByte();
                    return true;
                case "4":
                    SkrivutDd();
                    return true;
                case "5":
                    VemStorst();
                    return true;
                case "6":
                    RandGuessGame();
                    return true;
                case "7":
                    TextTillFil();
                    return true;
                case "8":
                    LasinFil();
                    return true;
                case "9":
                    DecRoten();
                    return true;
                case "10":
                    Multi10();
                    return true;
                case "11":
                    TvaArray();
                    return true;
                case "12":
                    Palin();
                    return true;
                case "13":
                    NumSpann();
                    return true;
                case "14":
                    KommaUddaJamn();
                    return true;
                case "15":
                    KommaPlussa();
                    return true; 
                case "16":
                    RollspelStats();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }
        private static void HelloCon() // Funktion 1
        {
            Console.Clear();
            Console.WriteLine("Hello World");

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
        private static void SkrivutInput() // Funktion 2
        {
            Console.Clear();
            // Input av sträng, ingen inmatningsvalidering
            Console.WriteLine("Skriv in Förnamn, Efternamn, Ålder:");

            Console.WriteLine("Förnamn:");
            string fNamn = Console.ReadLine();

            Console.WriteLine("Efternamn:");
            string eNamn = Console.ReadLine();

            Console.WriteLine("Ålder:");
            bool inteOk = false;
            int yAge = 0;
            while (inteOk == false)
            {
                try
                {
                    yAge = Convert.ToInt32(Console.ReadLine());
                    //string yAge = Console.ReadLine();
                    inteOk = true;
                }
                catch
                {
                    Console.WriteLine("Detta är inte ett heltal(ej decimaltal), var god ange ålder i heltal:");
                    inteOk = false;
                }
            }
            Console.Clear();

            // skriver ut i konsoll vad vad användaren skrev
            Console.WriteLine("--- Detta skrev du in: ---");
            Console.WriteLine("Förnamn: " + fNamn);
            Console.WriteLine("Efternamn: " + eNamn);
            Console.WriteLine("Ålder: " + yAge);


            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { 
            } 
        }
        private static void TextFargByte()// Funktion 3
        {
            if (ValdFarg == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                ValdFarg = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                ValdFarg = true;
            }
            Console.Clear();

            Console.WriteLine("Har nu ändrat textfärg.");

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
        private static void SkrivutDd() // Funktion 4
        {
            DateTime dagensDatum = DateTime.Today;

            Console.Clear();
            Console.WriteLine("Dagens datum i eget valt format (med bindesstreck emellan), år, månad & dag:");
            Console.WriteLine(dagensDatum.ToString("yyyy-MM-dd"));


            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void VemStorst() // Funktion 5
        {

            int talv1;
            int talv2;
            int hogst;

            Console.Clear();

            Console.Write("Skriv första talet: ");
            //kontroll att användaren skriver in ett tal
            var talsomStrang1 = Console.ReadLine();
            while (!int.TryParse(talsomStrang1, out talv1))
            {
                Console.WriteLine("Det är inte ett tal. Var god skriv in ett tal!:");
                talsomStrang1 = Console.ReadLine();
            }


            Console.Write("Skriv andra talet: ");
            //kontroll att användaren skriver in ett tal
            var talsomStrang2 = Console.ReadLine();
            while (!int.TryParse(talsomStrang2, out talv2))
            {
                Console.WriteLine("Det är inte ett tal. Var god skriv in ett tal!:");
                talsomStrang2 = Console.ReadLine();
            }


            //vilket är högst med if-else
            if (talv1 > talv2)
                hogst = talv1;
            else
                hogst = talv2;


            Console.Clear();
            Console.WriteLine("Högsta talet av dom du skrev in är: {0}", hogst);

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void RandGuessGame() // Funktion 6
        {
            Random rdtal = new Random();

            int SlumpTal = rdtal.Next(1,100); //generera slumptal mellan 1 och 100

            Console.Clear();
            Console.Write("Gissa talet. Mellan 1 och 100: ");

            int gissaTal = 0; // talet som skrevs in
            int forsok = 0; // hur många gissningar

            while (gissaTal != SlumpTal)
            {
                try
                {
                    gissaTal = Convert.ToInt32(Console.ReadLine());

                    if (gissaTal > 100 || gissaTal < 1)

                    {
                        Console.WriteLine("Talet du gissa är inte 1 till 100. Gissa igen:");
                        // gissningen är inte ett nummer mellan 1 och 100, minskar forsok med 1
                        forsok = forsok - 1;
                    }
                    // gissning för hög
                    else if (gissaTal > SlumpTal)
                    {
                        Console.WriteLine(gissaTal + " är för högt, gissa lägre:");
                    }
                    // gissning för låg
                    else if (gissaTal < SlumpTal)
                    {
                        Console.WriteLine(gissaTal + " är för lågt, gissa högre:");
                    }

                }

                catch
                {
                    //användaren skrev ej in siffra
                    Console.WriteLine("Gissning måste var ett nummer:");
                    
                    // gissningen är inte ett nummer minskar forsok med 1
                    forsok = forsok - 1;
                }
                // gissat 1 gång och ökar forsok med 1
                forsok = forsok + 1;
            }

            // rätt gissning
            Console.Clear();
            Console.WriteLine(SlumpTal + " är korrekt! Grattis :).");
            Console.WriteLine("Du gissade " + forsok + " gånger.");

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }

        private static void TextTillFil() // Funktion 7
        {

            Console.Clear();
            Console.Write("Skriv in en text & tryck sedan enter, för att spara till en fil: ");
            string textsparFil = Console.ReadLine();

            //Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            // Sätt variable med Filsökväg.
            string filPathsave = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Spara texten i en namngett txt-fil under "Den här datorn/Dokument" på windows. Skriv över automatiskt om filen existerar.
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(filPathsave, "ER_T&B_ConApp_textfil.txt")))
            outputFile.WriteLine(textsparFil);

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Texten du skrev är nu sparad i filen ER_T & B_ConApp_textfil.txt under " + filPathsave);

            Console.ResetColor();

            if (ValdFarg == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }


            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void LasinFil() // Funktion 8
        {

            Console.Clear();
            Console.Write("Laddar in text från fil, om filen existerar...\n");

            Console.WriteLine();

            string textlasFil = "Tomt";
            // Sätt variable med Filsökväg.
            string filPathRead = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Läs in filen OM den existerar, else meddelande att filen ej kan läsas/hittas under "Den här datorn/Dokument" på windows.
            try
            {
                using (StreamReader inputFile = new StreamReader(Path.Combine(filPathRead, "ER_T&B_ConApp_textfil.txt")))
                    textlasFil = inputFile.ReadToEnd();

                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("\nLäsning av fil lyckad!");

                Console.ResetColor();

                if (ValdFarg == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine();
                Console.WriteLine("Detta är texten från filen ER_T & B_ConApp_textfil.txt under " + filPathRead + ":");
                Console.WriteLine(textlasFil);
            }
            catch (IOException e)

            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("Ett fel uppstod. Felet är följande: ");
                Console.WriteLine(e.Message);

                Console.ResetColor();

                if (ValdFarg == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void DecRoten() // Funktion 9
        {

            Console.Clear();
            Console.Write("Skriv in ett positivt decimaltal, så räknas talet med ROTEN UR, upphöjt till 2 och till 10. Och visar dig resultatet: ");

            double deciTal = 0;
            //double deciConv = 0;
            bool inputNoE;// är input tomt?
            bool inputTest = false; //input test false till den klarat kraven

            var anvInput = Console.ReadLine();

            while (inputTest == false)
            {
                inputNoE = string.IsNullOrEmpty(anvInput);

                try
                {
                    double.TryParse(anvInput, out double deciConv);

                    if (inputNoE == true) // om blankt
                    {
                        Console.Write("\nDet är tomt! skriv ett positivt decimaltal med komma:");
                        anvInput = Console.ReadLine();
                    }
                    else if (deciConv == 0) // koll om 0 eller annan input än tal
                    {
                        Console.Write("\nDu har skrivit fel! Skriv ett positivt decimaltal med komma:");
                        anvInput = Console.ReadLine();
                    }
                    else if (deciConv < 0) // kolla om mindre än noll
                    {
                        Console.Write("\nDu har skrivit ett negativt tal! Var lite positivt och skriv ett positivt decimaltal med komma ;):");
                        anvInput = Console.ReadLine();
                    }
                    else if (Math.Truncate(deciConv) == deciConv) // kolla om det är decimaltal
                    {
                        Console.Write("\nDet är inte ett decimaltal! skriv ett decimaltal med komma:");
                        anvInput = Console.ReadLine();
                    }
                    else
                    {
                        // all koll ok. Överför input till annan variabel, och sätt true för while-loopen för att gå vidare i programmet
                        deciTal = deciConv;
                        inputTest = true;
                    }
                }
                catch
                {
                    //nedan 2 rader behövs inte längre
                // Console.Write("\nDet är inte ett decimaltal! skriv ett decimaltal.");
                // anvInput = Console.ReadLine();
                }
            }

            double rotUr = Math.Sqrt(deciTal);
            double upphojt2 = rotUr * rotUr;
            double upphojt10 = Math.Pow(rotUr, 10);

            Console.Clear();
            Console.WriteLine("Här är resultat av beräkningarna avrundat till 5 decimaler:\n");
            Console.WriteLine("Roten ur " + deciTal + " är = " +(Math.Round(rotUr, 5)));
            Console.WriteLine("Roten ur " + deciTal + " och upphöjt till 2 är = " + (Math.Round(upphojt2, 5)) + ".");
            Console.WriteLine("Roten ur " + deciTal + " och upphöjt till 10 är = " + (Math.Round(upphojt10, 5)));

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
                Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }   
            
        }
        private static void Multi10() // Funktion 10
        {
            int v, l, uppTill;
            Console.Clear();
            Console.Write("\n----< Multiplikationstabell 1 till 10 uppstakad som en oldschool tabell >----\n\n");
            uppTill = Convert.ToInt32(10);
 
            for (v = 0; v <= uppTill; v++) // för att få översta raden med punkter, så det blir tabellforms-utseende
            {
                Console.ForegroundColor = ConsoleColor.Red; // ge färg på övre raden sedan återställ till sparad färginställning 
                //Console.BackgroundColor = ConsoleColor.White;
                Console.Write(v + ".");
                Console.ResetColor();
                if (ValdFarg == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write("\t ");
            }


            Console.Write("\n\n\n");

                for (v = 1; v <= 10; v++)
            {
                Console.ForegroundColor = ConsoleColor.Red; // ge färg på övre raden sedan återställ till sparad färginställning 
                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("\n" + v + ".");
                Console.ResetColor();
                if (ValdFarg == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.Write("\t");

                for (l = 1; l <= 10; l++)
                {
                    Console.Write(" {0}" , (v * l));
                    if (l != 10)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void TvaArray() // Funktion 11
        {
            Console.Clear();
            int antalTal = 10;
            int[] antNr = new int[antalTal];
            Random slump = new Random();

            Console.Write("Genererar " + antalTal + " unika slupmässiga tal mellan 1 och 52, sparar i en array. Sorterar stigande och sparar i en annan array.\n");

            int kort;
            for (kort = 0; kort < antNr.Length; kort++)
            {
                var next = 0;
                while (true)
                {
                    next = slump.Next(52);
                    if (!Contains(antNr, next)) break;
                }

                antNr[kort] = next;
                // Console.WriteLine("antNr[{0}] = {1}", kort, antNr[kort]);
            }
        
            
            static bool Contains(int[] array, int value)
            {
                for (int kort = 0; kort < array.Length; kort++)
                {
                    if (array[kort] == value) return true;
                }
                return false;
            }

            Console.Write("\nDom unika slumptalen sparade i första arrayen blev: ");
            for (kort = 0; kort < antNr.Length; kort++)
            {
                Console.Write("{0}  ", antNr[kort]);
            }
            Console.Write("\n");

            int[] arraySorted = new int[10];

            antNr.CopyTo(arraySorted, 0); //kopierar första arrayen in till en ny array

            Array.Sort(arraySorted); // sorterar denna array i stigande


            Console.Write("\nDom unika slumptalen kopierat från första array till andra array, och sorterat i stigande ordning: ");
            for (kort = 0; kort < arraySorted.Length; kort++)
            {
                Console.Write("{0}  ", arraySorted[kort]);
            }
            Console.Write("\n");


            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }

        private static void Palin() // Funktion 12
        {
            Console.Clear();
            Console.Write("Skriv in ett ord eller siffror och kolla om det är vändbart (palindrom): ");
            string ordInput = Console.ReadLine();

            
            bool svar = arVandbart(ordInput); // Ja eller Nej om det är vändbart från metoden "arVandbart" och ge meddelande

            if (svar == true)
            {
                Console.Write("\nJA, " + ordInput + " ÄR en palindrom(vändbart).");
            }
            else if (svar == false)
            {
                Console.Write("\nNEJ, " + ordInput + " är INTE en palindrom(vändbart).");
            }

            // metod som tar strängen från användaren "ordInput", och tecken för tecken bakifrån bygger upp baklänges.
            // sparar detta i en ny sträng "tvartOm" och jämnför om "tvartOm" är samma bakifrån som "ordInput".
            // och sedan ger tillbaka svaret som true eller false, som sedan ovan sparas i bool-variabeln "svar" som sedan kollar i en If-loop
            // Ignorerar stora eller små bokstäver 
            static bool arVandbart(string ordInput)
            {
                string tempCopy = ordInput;
                string tvartOm = null;
                while (ordInput.Length > 0)
                {
                    tvartOm = string.Concat(tvartOm, ordInput.LastOrDefault());
                    ordInput = ordInput.Remove(ordInput.Length - 1);
                }
                return tempCopy.Equals(tvartOm, StringComparison.OrdinalIgnoreCase); // kollar om samma, ignorerar små & stora bokstäver, ger svar som boolean

            }

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            
        }
        private static void NumSpann() // Funktion 13
        {
            Console.Clear();
            int lagaTalet = 7;
            int hogaTalet = 43;

            Console.WriteLine("Skriv in 2st olika positiva heltal(ej decimaltal) från " + lagaTalet + " till " + hogaTalet + ", så listar jag alla nummer EMELLAN, i stigande ordning:");

            int phelTal1 = 0;
            int phelTal2 = 0;
            bool kollConvLoop = false;
            bool kollConvLoop2 = false;

            while (kollConvLoop == false)
            {
                try
                {
                    Console.WriteLine("\nTal 1:");
                    int anvInput = Convert.ToInt32(Console.ReadLine());

                    if (anvInput < 0)
                    {
                        Console.Write("\nDu har skrivit ett negativt tal. Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop = false;
                    }
                    else if (anvInput < lagaTalet)
                    {
                        Console.Write("\nDu har skrivit ett för långt tal. Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop = false;
                    }
                    else if (anvInput > hogaTalet)
                    {
                        Console.Write("\nDu har skrivit ett för högt tal. Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop = false;
                    }
                    else
                    {
                        phelTal1 = anvInput;
                        kollConvLoop = true;
                    }      
                }
                catch
                {
                    Console.Write("\nDu har skrivit fel! Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                    kollConvLoop = false;
                }

            }

            Console.Clear();

            while (kollConvLoop2 == false)
            {
                try
                {
                    Console.WriteLine("\nTal 2:");

                    int anvInput2 = Convert.ToInt32(Console.ReadLine());
                    
                    if (anvInput2 < 0)
                    {
                        Console.Write("\nDu har skrivit ett negativt tal. Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop2 = false;
                    }
                    else if (anvInput2 < lagaTalet)
                    {
                        Console.Write("\nDu har skrivit ett för långt tal. Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop2 = false;
                    }
                    else if (anvInput2 == phelTal1)
                    {
                        Console.Write("\nDu har skrivit samma tal som du skrev på Tal1. Skriv ett unikt positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop2 = false;
                    }
                    else if (anvInput2 > hogaTalet)
                    {
                        Console.Write("\nDu har skrivit ett för högt tal. Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                        kollConvLoop2 = false;
                    }
                    else
                    {
                        phelTal2 = anvInput2;
                        kollConvLoop2 = true;
                    }
                }
                catch
                {
                    Console.Write("\nDu har skrivit fel! Skriv ett positivt heltal från " + lagaTalet + " till " + hogaTalet + ":\n");
                    kollConvLoop2 = false;
                }

            }
            /* debug testning
            Console.Clear();
            Console.Write("\nTal 1 är: " + phelTal1);
            Console.Write("\n");
            Console.Write("\nTal 2 är: " + phelTal2);
            Console.Write("\n\n"); */

            int lagstaNr;

            if (phelTal1 < phelTal2)
                {
                lagstaNr = phelTal1;
                }
            else
                {
                lagstaNr = phelTal2;
                }

            int antmellanNren = (phelTal1 - phelTal2);

            if (antmellanNren < 0)
            {
                antmellanNren = -antmellanNren;
            }

            antmellanNren = antmellanNren - 1;

            Console.Clear();

            Console.Write("\nAntal nummer emellan " + phelTal1 + " & " + phelTal2 + " är " + antmellanNren + ".");

            var mellanNrarray = Enumerable.Range(lagstaNr+1, antmellanNren).ToArray();

            Console.Write("\n\n\nAlla talen emellan, här i stigande ordning: ");
            int nummren;
            for (nummren = 0; nummren < mellanNrarray.Length; nummren++)
            {
                Console.Write("{0}  ", mellanNrarray[nummren]);
            }
            Console.Write("\n");


            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void KommaUddaJamn() // Funktion 14
        {


            Console.Clear();
            Console.Write("\nOBS!!! EJ helt färdig funktion! Och fick inte till det med input kontrollen, om det är korrekt skrivet. Så just nu VID FEL så skippar den, och avslutar funktionen. /ER\n");
            Console.Write("\nSkriv in några komma-separerade tal. Ex. 3,57,14,29 utan mellanslag:\n");
            string inputkomSep = Console.ReadLine();
            //string inputkomSep = "1,3,2,5,4";

            //bool inTesting = false;

            /*while (inTesting == false)
            {*/
                //try
                //{
                    
                    int[] minintArray = StringToIntArray(inputkomSep);
                    int mangdTal;
                    for (mangdTal = 0; mangdTal < minintArray.Length; mangdTal++)
                    {
                        Console.Write("{0}  ", minintArray[mangdTal]);
                        //inTesting = true;
                    }

                //}
                //catch
                //{
                //Console.Write("\nCatch utlöstes!");
                //inputkomSep = Console.ReadLine();
                //inTesting = false;
                //}

            //}

            //Console.WriteLine(" { 0}" , minintArray);  //.ToString());

            
            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }

        // method att kalla på för komma-separerad tal i stränginput, till int-array för behandling
        private static int[] StringToIntArray(string inputkomSep) 
        {
            List<int> myIntegers = new List<int>();
            Array.ForEach(inputkomSep.Split(",".ToCharArray()), s =>
            {
                int currentInt;
            if (Int32.TryParse(s, out currentInt))
                myIntegers.Add(currentInt);
            });

            return myIntegers.ToArray();
        }

        private static void KommaPlussa() // Funktion 15
        {
            //placeholder
            Console.Clear();
            Console.Write("\nFunktion ej gjord. Detta är en placeholder... /ER");

            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
        private static void RollspelStats() // Funktion 16
        {
            Console.Clear();
            Console.Write("\nHär skriver du in ett namn på din karaktär och sedan ett namn på en motståndare,");
            Console.Write("\nSedan slumpas egenskaperna: Hälsa, Styrka & Tur, med ett kast av 1T20 + 1T4 (benämning av tärningstyp) vardera.");

            Console.Write("\n\nAnge namnet på din karaktär:");
            string karakNamn = Console.ReadLine();

            Console.Write("\nAnge namnet på din motståndare:");
            string motstandNamn = Console.ReadLine();

            static int tarningsKast()
            {
            Random rnd = new Random();
            int t20 = rnd.Next(1, 20);
            int t4 = rnd.Next(1, 4);
            int statsSumma = t20 + t4;
            return statsSumma;
            }

            int halsa1 = tarningsKast();
            int styrka1 = tarningsKast();
            int turen1 = tarningsKast();
            int halsa2 = tarningsKast();
            int styrka2 = tarningsKast();
            int turen2 = tarningsKast();
            Console.Write("\n");

            //nedan oútput testkod
            /* Console.Write("Hälsa: " + halsa);
            Console.Write("\n");
            Console.Write("Styrka: " + styrka);
            Console.Write("\n");
            Console.Write("Tur: " + turen);
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            */

            Rollspel karaktar1 = new Rollspel(karakNamn, halsa1, styrka1, turen1);

            Rollspel karaktar2 = new Rollspel(motstandNamn, halsa2, styrka2, turen2);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Karaktärer & Stats\n");
            Console.ResetColor();

            if (ValdFarg == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("\nDin hjälte: {0}", karaktar1.RollspelNamn);
            Console.WriteLine("Hälsa \t{0} \nStyrka \t{1} \nTur \t{2}", karaktar1.RollspelHp, karaktar1.RollspelSty, karaktar1.RollspelTur);
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("\nMotståndaren: {0}", karaktar2.RollspelNamn);
            Console.WriteLine("Hälsa \t{0} \nStyrka \t{1} \nTur \t{2}", karaktar2.RollspelHp, karaktar2.RollspelSty, karaktar2.RollspelTur);


            // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }

        }
    }

    //Objekt att spara karaktärer och stats i, för att senare hämta ifrån. Lägger denna klass i samma cs. för det är så litet program
    public class Rollspel 
    {
        public string Name { get; set; }
        public string RollspelNamn { get; set; }
        public int RollspelHp { get; set; }
        public int RollspelSty { get; set; }
        public int RollspelTur { get; set; }
        public Rollspel(string karNamn, int hp, int sty, int tur)
        {
            RollspelNamn = karNamn;
            RollspelHp = hp;
            RollspelSty = sty;
            RollspelTur = tur;
        }

    }
}
