using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnime
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem, kui 3 rida koodi

            Console.WriteLine("Sisesta oma eesnimi:");
            string UserName = Console.ReadLine();

            GetUserNameData(UserName);

        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene sümbol on {userInput[0]}");

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
