using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_De_Recursividad
{
    public class Ejercicios
    {
        // Escriba una función recursiva que imprima los números desde un número n hasta otro número m descendentemente
        public static int Imprimir(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(n);
                return Imprimir(n - 1);
            }
        }

        // Escriba una función recursiva que reciba un número y retorne la cantidad de dígitos de este número
        public static int Cantidad(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return 1 + Cantidad(n / 10);
            }
        }

        // Escriba una función recursiva que sume los dígitos de un número dado
        public static int Suma_Digitos(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n%10 + Suma_Digitos(n/10);
            }
        }

        // Escriba una función recursiva que invierta un string dado
        public static string Invertir(string str)
        {
            if (str == "")
            {
                return str;
            }
            else
            {
                return Invertir(str.Substring(1)) + str[0];
            }
        }

    }
}
