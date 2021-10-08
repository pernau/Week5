using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "vale kasutaatunnus või salasõna, Proovi uuesti"

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            //AND (&&) või OR

            //"admin" and "admin1234" --> true
            //"admin1" and "admin1234" --> false
            //"admin" and "admin12345" --> false
            //"admin1" and "admin123" --> false

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");

            }
            else
            {
                Console.WriteLine("Vale kasutajanimi või salasõna. Proovi uuesti.");
            }
        }
    }
}
