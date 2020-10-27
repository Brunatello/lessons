using System;

namespace Day2
{
    class Program
    {
        static void Task2_1()
        {
            // Izveidot consoles aplikāciju, kura no lietotāja paprasa divas vērtības.
            // Programmā ir jāpanāk šo divu vērtību summēšana (nepieciešams izmantot int.Parse, vai Convert.ToInt32).
            
            Console.Write("Ievadiet vienu veselu skaitli: ");
                            // Šādi pārvēršam tekstuālo vērtību uz skaitli
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 0 || x > 20)
            {
                Console.WriteLine("Number is out of range. Please try again: ");
                
            }   else
            {
                Console.Write("Ievadiet otru veselu skaitli: ");
                int y = Convert.ToInt32(Console.ReadLine());
            }

            

            // Pirms vērtību summēšanas ir jāpanāk, ka vērtībai x ir jābūt robežās no 0 līdz 20. Vērtībai y ir jābūt robežās no 30 līdz 50. 
            // Ja ievadītais skaitlis nav šajās robežās uz ekrāna ir jāizvada atbilstošs paziņojums. 
            // Līdz ar to, ja skaitļi nav atbilstošās robežās, tad izvadam kļūdas paziņojumu, un tikai tad, ja abi skaitļi pareizi, izvadam summu.

           




        }




        static void Main(string[] args)
        {
            Task2_1();
        }
    }
}
