using System;

namespace Day1
{
    class Program
    {
        static void Task1()
        {
            // Uzdevums 1
            // Izveidot konsoles aplikāciju, kura uz ekrāna izdrukā vārdu un uzvārdu.
            // Nav nepieciešams neko ievadīt no konsoles.
            string vards = "Agnese", uzvards = "Siksna";
            Console.WriteLine(vards + " " + uzvards);
        }

        static void Task2()
        {
            // Uzdevums 2
            // Deklarēt 4 mainīgos (katru ar savu datu tipu = int, double, bool, string). 
            int x = 2;
            double y = 8.9876;
            bool something;
            string vards;
            // Diviem piešķirt vērtību uzreiz pēc deklarēšanas, diviem vēlāk programmā.
            something = true;
            vards = "Kaķis";
            // Izdrukāt vērtības.
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(something);
            Console.WriteLine(vards);
        }

        static void Task3()
        {
            // Deklarēt programmā divus int tipa mainīgos x un y.
            // Piešķirt mainīgajiem vērtības 10 un 15.
            // Deklarēt mainīgo z un piešķirt tam mainīgo x un y summu.
            // Izdrukāt uz ekrāna mainīgā z vērtību.

            int x = 10, y = 15;
            int z = x + y;
            Console.WriteLine(z);
        }

        static void Task4()
        {
            // Izveidot Console aplikāciju, kura paprasa lietotājam vārdu un izvada to uz ekrāna.
            Console.Write("Ievadiet kādu vārdu: ");
            string vards = Console.ReadLine();
            Console.WriteLine("Ievadītais vārds ir: " + vards);
        }

        static void Task5()
        {
            // Izveidot consoles aplikāciju, kura lietotājam paprasa vārdu un uzvārdu.
            // Izdrukāt vārdu un uzvārdu formātā “Vārds Uzvārds”.
            // Modificēt programmu tā, lai vārds un uzvārds tiktu izdrukāts formātā “V.Uzvārds”.
            // Lai iegūtu tikai vārda pirmo burtu ir jāizmanto name.Substring(0, 1).name ir mainīgais, kurā glabājas jūsu vārds."
            Console.Write("Ievadiet savu vārdu: ");
            string vards = Console.ReadLine();
            Console.Write("Ievadiet savu uzvārdu: ");
            string uzvards = Console.ReadLine();
            Console.WriteLine(vards + " " + uzvards);
            Console.WriteLine(vards.Substring(0, 1).ToUpper() + ". " + uzvards);
        }

        static void Main(string[] args)
        {
            // Papilduzdevums ar "Switch" metodi
            // Pieprasām no lietotāja ievadīt uzdevuma numuru
            // Izpildām attiecīgo uzdevumu
            Console.Write("Ievadiet uzdevuma numuru no 1 līdz 5: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            // varēja rakstīt arī vienkārši "string taskNr = Cosole.ReadLine();", bet tad pie "case" būtu jāpārraksta ar pēdiņām "1" utt. 

            switch(taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                default:
                    Console.WriteLine("Šāda uzdevuma nav.");
                    break;
            }

           /* Task1();
            Task2();
            Task3();
            Task4();
            Task5();*/
        }
    }
}
