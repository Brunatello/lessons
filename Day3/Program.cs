using System;

namespace Day3
{
    class Program
    {

        static void Task3_1()
        {
            // Izveidot consoles aplikāciju, kurā ir definēts int masīvs ar vērtībām 1,6,7,78,9,9. 
            int[] masivs = { 1, 6, 7, 78, 9, 9 };
            // Izvadīt šos elementus uz ekrāna (cikliski jāiet cauri) 
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine(masivs[i]);
            }
        }
        static void Task3_2()
        {
            // Izveidot console aplikāciju, kura paprasa lietotājam vai viņš grib pusdienas.
            // Ja lietotājs ir ievadījis TRUE, tad uz ekrāna izdrukāt "Jūsu pusdienas ir gatavas"
            // ja lietotājs ir ievadījis FALSE, tad "Jums pusdienas nebūs".
            // IF ELSE nosacījumā ir jāizmanto bool tipa mainīgais, nevis string tipa mainīgais.
            // Lai no lietotāja ievadītā teksta iegūtu bool tipa mainīgo ir jāizmanto bool.Parse, līdzīgi kā ar konvertēšanu uz veselu skaitli. 

            Console.WriteLine("Vai tu gribi pusdienas?");
            string pusdienas = Console.ReadLine();
            bool parveidot = bool.Parse(pusdienas);
            // parveidot = true
            if (parveidot)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            else
            {
                Console.WriteLine("Jums pusdienas nebūs");
            }
        }
        static void Task3_3()
        {
            // Deklarēt programmā bool tipa mainīgo, kura sākotnējā vērtība ir TRUE.
            // Izveidot while ciklu, kurš atkārtojas tik ilgi, kamēr mainīgā vērtība ir TRUE.
            // Mainīgā vērtību uz FALSE ir jānomaina, tad, kad cikls ir atkārtojies 20 reizes.
        }

        static void Main(string[] args)
        {
            Task3_1();
            Task3_2();
            Task3_3();
        }
    }
}
