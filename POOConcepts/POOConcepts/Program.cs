using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts!");
            Console.WriteLine("==============");
            //Date date = new Date(2022,03,15);
            //Console.WriteLine(date.ToString());

            try
            {
                Console.WriteLine(new Date(2024, 2, 29));
                Console.WriteLine(new Date(1974, 9, 23));
                Console.WriteLine(new Date(1985, 13, 30));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message); ;
            }

        }
    }
}
