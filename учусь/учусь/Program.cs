using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Reflection.Metadata;


namespace учусь
{
    class учусь
    {

        static void Main()
        {
            short user_input = Convert.ToInt16(Console.ReadLine());



            switch (user_input)
            {
                case 5 : Console.WriteLine("number is 5"); break;
                case 1: Console.WriteLine("number is 1"); break;
                case 3: Console.WriteLine("number is 3"); break;

              default: Console.WriteLine("nema tagogo"); break;
            }
           

           
        }
    }
}