using System;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{
    public static void Main(string[] args)
    {
        
        
        do
        {
            //initializing variable for discount
            decimal discount = 0;
            // taking input from user
            Console.WriteLine("Anzahl der Schrauben:");
            //converting string to int 
            int schrauben = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anzahl der Mutter:");
            int mutter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anzahl der Unterlegscheiben:");
            int unterlegscheiben = Convert.ToInt32(Console.ReadLine());

            if (schrauben == mutter)
            {
                Console.WriteLine("Die Bestellung ist okay");
                //calculating  discount
                discount = Convert.ToDecimal(schrauben * 0.5 + mutter * 0.3 + unterlegscheiben * 0.1);
                //Displaying output
                Console.WriteLine("Your discount is:" + discount.ToString());
            }
            else
            {
                //Messege to inform user to check the order
                Console.WriteLine("Controllieren Sie Ihre Bestellung");
                //calculating  discount
                discount = Convert.ToDecimal(schrauben * 0.5 + mutter * 0.3 + unterlegscheiben * 0.1);
                //Displaying output
                Console.WriteLine("Your discount is:" + discount.ToString()+ "$");
            }

        }
        while (Console.ReadKey().Key != ConsoleKey.X);
     
    }
}

