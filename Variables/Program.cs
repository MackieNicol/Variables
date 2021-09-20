using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Varibles");


            // ---------------------Intergers--------------------------

            //integer
            int score; // DECLAREING an interger variable named, "score"
            score = 0; // assign 0 to score

            Console.WriteLine(score); // accesing a Varible
            Console.WriteLine("score"); // NOT accesing a Varible

            // "=" means "set score to the value in code

            score = 100; // assinging 100 to score

            Console.WriteLine(score); // accesing a Varible
            score = score + 100;  // killed an enemy gain 100 points
            Console.WriteLine(score); // accesing a Varible
            score = score + 100;  // killed an enemy gain 100 points
            Console.WriteLine(score); // accesing a Varible
            score = score + 100;  // killed an enemy gain 100 points
            Console.WriteLine(score); // accesing a Varible
            score = score + 100;  // killed an enemy gain 100 points

            Console.ReadKey(true); // wait for key press before exiting

            //------------------Strings-------------------------------

            string Username; // DECLAREING a string varible named, "Username"
            Username = "Chad"; // Setting a string variable to whatever
            Console.WriteLine(Username);
            Username = "NotChad";
            Console.WriteLine(Username);

            string firstname;
            string lastname;
            string fullname;
            firstname = "Mackie";
            lastname = "Nicol";
            fullname = firstname + " " + lastname;
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(fullname);

            Console.ReadKey(true); // wait for keypress before exiting


            //---------------------------Floats-----------------------------

            // Float = "floating point" number = real numbers
            // 1000000.00000
            // 1000000000.00
            // 10000.0000000
            // 1.00000000000

            float speed; // in kph
            float distanceTravelled; // in kms
            speed = 100.0f; // kph
            distanceTravelled = 2345.35f; // kms

            Console.WriteLine("speedometer: " + speed);
            Console.WriteLine("odometer: " + distanceTravelled);



            //--------------INTS VS FLOATS---------------------------
            int intTest;
            float floatTest;
            float floatTest2;
            intTest = 10 / 3; // 3 ????
            floatTest = 10 / 3; // 3.333 Why????
            floatTest2 = 10.0f / 3.0f; // 3.333 ???
            Console.WriteLine(intTest); 
            Console.WriteLine(floatTest); 

            Console.ReadKey(true);
        }
    }
}
