using System;

namespace EjercicioTres
{
    class Numero
    {
        //Arrelgo que almacenara los numeros introudcidos por el usuario 
        private int[] numeros;
        //Atributos 
        private int num, x;
        //Metodo para capturar datos 
        public void CapturarNumeros()
        {
            numeros = new int[20];
            for (int i = 0; i < numeros.Length; i++)//Ciclo for para determinar cada numero
            {
                Console.Write("Ingrese numero " + (i + 1) + ": ");
                num = int.Parse(Console.ReadLine());
                numeros[i] = num;//Se almacena en el arreglo 
            }
        }
        //Metodo para ordenar los números 
        public void OrdenarNumeros()
        {
            for (int i = 0; i < 19; i++)//ciclo for 
            {
                for (int l = 0; l < 19 - i; l++)//ciclo for anidado 
                {
                    if (numeros[l] > numeros[l + 1])//condición para almacenar en un estpacio del arreglo determinado numero introducido 
                    {
                        x = numeros[l];// se almacena el la variable x cada numero en la posición l
                        numeros[l] = numeros[l + 1];//se almance en el atributo numero lo que se introudcio en la posición l 
                        numeros[l + 1] = x;
                    }
                }
            }
        }
        //Metodo para mostrar el ordenamiento al usuario 
        public void ImprimirNumeros()
        {
            Console.WriteLine("______________");
            Console.WriteLine("Números ordenadas de forma ascendente");
            Console.WriteLine("______________");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " - ");//Mensaje que se le mostrara 
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numero ordemaniento = new Numero();//Instancia del objeto 
            Console.WriteLine("                     ORDENAMIENTO DE NÚMEROS                          ");
            Console.WriteLine("________________________");
            Console.WriteLine("Programa que captura 20 números enteros y los ordena de menor a mayor");
            Console.WriteLine("________________________");
            //Se mandan llamar a los metodos 
            ordemaniento.CapturarNumeros();

            ordemaniento.OrdenarNumeros();
            ordemaniento.ImprimirNumeros();
            Console.ReadKey();

        }
    }
}
