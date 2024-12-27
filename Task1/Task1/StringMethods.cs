using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class StringMethods
    {
        string Fullname = "Sai Kutthalingam S";

        string Greetmsg = "Good Afternoon ";

        string City = "Tirunelveli";

        string Username;

        public void showStringMethods()
        {
            Console.WriteLine("Actual String:" + Fullname);

            Console.WriteLine("Actual String:" + Greetmsg.Trim());

            Console.WriteLine(Fullname.ToLower());

            Console.WriteLine(Fullname.ToUpper());

            Console.WriteLine(Fullname[0]);

            Console.WriteLine(Fullname.IndexOf("a"));

            Console.WriteLine(Fullname.Substring(0));

            Console.WriteLine(Fullname.Substring(0, 5));

            Console.WriteLine(Fullname.Remove(1, 3));

            Console.WriteLine(Fullname.StartsWith("Sai"));

            Console.WriteLine(Fullname.EndsWith(" S"));

            Console.WriteLine(Fullname.Contains("sk"));

            Console.WriteLine(Fullname.Equals(Greetmsg));

            Console.WriteLine(Fullname.IndexOf(" "));

            Console.WriteLine(Fullname.LastIndexOf(" "));

            Console.WriteLine(Fullname.IndexOf(" ", 5));

            Console.WriteLine(string.Format("{0} {1}", Greetmsg, Fullname));

            char[] characters = City.ToCharArray();
            foreach (char c in characters)
            {
                Console.WriteLine(c);

            }

            string[] nameArray = Fullname.Split(" ");
            foreach (string name in nameArray) {
                Console.WriteLine(name);
            }

            Console.WriteLine(string.Join(" ", nameArray));

            Console.Write("Enter Your Name: ");
            Username = Console.ReadLine();

            Username = Username.ToLower();


            string[] capitalizeName = Username.Split(" ");
            if (Username != "")
            {
                

                for (int i = 0;  i < capitalizeName.Length; i++){
                    capitalizeName[i] = char.ToUpper(capitalizeName[i][0]) + capitalizeName[i].Substring(1);

                }

                
            }
            string capitalizedUsername = string.Join(" ", capitalizeName); 
            Console.WriteLine("Capitalized Name: " + capitalizedUsername);


            char[] reverseCity = City.ToCharArray();
            string city = "";

            /*
             
            for(int i=reverseCity.Length-1;i>=0;i--)
            {
                city += reverseCity[i];
                
            }
            Console.WriteLine(city);

            */


            for (int i = 1; i<=reverseCity.Length; i++)
            {
                city += reverseCity[^i];

            }
            Console.WriteLine(city);

            /*

            foreach (char c in reverseCity)
            {
                city = c + city;
            }
            Console.WriteLine(city);

            */

        }
    }
}
