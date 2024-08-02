using System;

namespace LesVariabelen
{
    class Variabelen
    {
        static void Main()
        {

            // Variables

            int number1 = 10;
            double number2 = 3.141542;
            float number3 = 5.0f;
            decimal number4 = 100.5m;
            bool yesNo = false;
            string text = "davies";
            char character1 = 'a';



            // Escape sequences

            // Single Quoates
            Console.WriteLine("\'a\'");

            // Double Quotes
            Console.WriteLine("\"a\"");

            // Using backslash
            Console.WriteLine("C:user\\");

            // The yellow highlight backslahses means a escape sequence is used
            Console.WriteLine("\\server\notes\name.txt");

            // Use of escape sequence
            Console.WriteLine("\\\\server\\notes\\name.txt");

            // This will escape make the text a string 
            Console.WriteLine(@"\\server\notes\name.txt");

            // Casting 

            // Here we are placing a number that is in the range of the datatype int
            int intVal1 = 12345678;

            // This will give a error because we are placing a intger which has a bigger data range into a short with les data range

            //char intVal2 = intVal1;

            // Casting: We can do this by force (Placing a bigger value into a smaller value) this is called casting.
            // But this will cause a data los
            char inVal3 = (char)intVal1;

            // Asking for the range of a datatype
            Console.WriteLine($"maxium value of the datatype int {int.MaxValue}");
            Console.WriteLine($"minimum value of the datatype int {int.MinValue}");
            Console.WriteLine($"Max value of the datatype double {float.MaxValue}");
            Console.WriteLine($"Min value of the datatype double {float.MinValue}");

            // Convering userinfo
            int value1, value2;
            Console.Write("Gelieve een getal 1 in te geven: ");
            value1 = int.Parse(Console.ReadLine());

            Console.Write("Gelieve een getal 2 in te geven: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Getallen: {value1} {value2}");


        }
    }
}
