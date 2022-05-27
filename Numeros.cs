using System;
using System.Collections.Generic;
using System.Text;
namespace ByronCalderon3A_Ejercicio4
{
    public class Numeros
    {
        private int numero { set; get; }
        public Numeros(int numero)
        {
            this.numero = numero;
        }
        public void Calcular()
        {
            if (numero < 1)
            {
                do
                {
                    Console.WriteLine(++numero);

                } while (numero != 0);
            }
            else
            {
                do
                {
                    Console.WriteLine(--numero);
                } while (numero != 0);
            }
            Console.ReadKey();
        }
    }
}
