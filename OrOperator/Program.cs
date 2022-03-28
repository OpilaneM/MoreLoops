using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja siestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            // or (või) || (pipes)

            // true || true --> true
            //false || true--. true
            //true || false --> true
            // false || false --> false

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();
            if(userName != "admin" || userPassword!= "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
            
            Console.Read();
        }
    }
}
