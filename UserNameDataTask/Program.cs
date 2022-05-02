using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada oma eesnime
            //programm küsib kasutajal sisestada number 1-3
            //kui sisestab 1, kuvatakse kasutaja eesnimi tagurpidi
            //kui sisestab 2, kuvatakse kasutaja eesnime esimest tähte
            //kui sisestab 3, kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta arv 1-3:");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            if (UserNumber == 1)
            {
                UserNumber1(UserName);
            }
            else if (UserNumber == 2)
            {
                UserNumber2(UserName);
            }
            else if (UserNumber == 3)
            {
                UserNumber3(UserName);
            }
            else
            {
                Console.WriteLine("Sisestasid vale numbri.");
            }
        }

        public static void UserNumber1(string UserInput)
        {
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Console.Write(UserInput[i]);
            }
        }
        public static void UserNumber2(string UserInput)
        {
            Console.WriteLine($"Sinu eesnime esimene sümbol on {UserInput[0]}");
        }
        public static void UserNumber3(string UserInput)
        {
            Console.WriteLine($"Sinu nimi on {UserInput.Length} sümbolit pikk.");
        }
    }
}
