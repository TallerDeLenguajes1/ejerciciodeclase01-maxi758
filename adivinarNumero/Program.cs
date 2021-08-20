using System;

namespace adivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {   var rand = new Random();
            int randomNumber = rand.Next(101);
            int userNumber;
            try
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entre 0 y 100");
                    userNumber = Convert.ToInt32(Console.ReadLine());

                    if (userNumber > randomNumber)
                        Console.WriteLine("elija un numero mas pequeño");
                    else
                        Console.WriteLine("elija un numero mas grande");

                } while (userNumber != randomNumber);
                Console.WriteLine($"Felicitaciones!!! El valor es {randomNumber}");

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor fuera del rango permitido");
            }

            Console.ReadKey();
            
        }
    }
}
