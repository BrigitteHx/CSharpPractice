using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //try
            //{
            //    var number2 = "1234";
            //    byte b = Convert.ToByte(number2);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted.");
            //}


            try
            {
                string str = "true"; 
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not be converted.");
            }

        }
    }
}