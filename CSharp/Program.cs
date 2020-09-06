using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Same line");
            // comment
            /* long comment
                aeeeeea
            */
            int aNum = 50;
            string aWord = "word";
            double aDouble = 0.0;
            int adder = 10;
            Console.WriteLine("The sum is:"+ (aNum+adder));
            int x = 4, y = 94, z = 0;
            bool trueorfalse = true;
            Console.WriteLine(Convert.ToString(aNum));

            Console.WriteLine("Enter Namne:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: "+userName);

            Console.WriteLine("Enter Password:");
            int Password = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pass is: "+Password);

            Console.WriteLine(Math.Max(x,y));

            //String Interpolation
            string firstName = "John";
            string lastName = "Doe";
            String fullName = $"My full name is: {firstName}{lastName}";
            Console.WriteLine(fullName);

            if(x>y){
                Console.WriteLine("Bigger");
            }else{
                Console.WriteLine("Smaller");
            }

            int time = 20;
            string result = (time<10)?"Good day.": "Good evening.";
            //short form of a if else stateement
            Console.WriteLine(result);


        }
    }
}
