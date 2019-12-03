using System;
using System.Collections.Generic;

namespace error
{
    class NegativeIntergetException:Exception
    {
        public NegativeIntergetException():base("Es un error")
        {

        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Captura un entero positivo");
            int valor = 0;
            try
            {
                valor = int.Parse(Console.ReadLine());
                if (valor < 0 )             
                {
                    throw new NegativeIntergetException();
                }
                Console.WriteLine("El valor es:{0}", valor);
                Main();
            }
            catch ( StackOverflowException e)                                    //System.OverflowException e
            {
                Console.WriteLine("Hubo un error: ");
                Console.WriteLine(e.Message);
            }
            //
            finally
            {
                Console.WriteLine("Finally");
            }

        }
    }
}
