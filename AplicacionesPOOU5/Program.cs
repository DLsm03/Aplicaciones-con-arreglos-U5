using System;

namespace EjercicioUno 
{
    //Clase Numero que contiene todos los metodos que necesitamos para la ejecución de este programa 
    class Numeros
    {
        //Arreglo para poder capturar los 10 números que nos introducira el usuario 
        private int[] dato;
        //Atributos para poder realizar la suma, el promedio y los que contendran el número mayor y menor
        private int numero, resultadoSuma, mayor, menor;
        private double resultadoProm;
        //Propiedades publicas que nos serviran para evaluar (SET) y retornar (GET) y poder usarlos en todo el programa con el mismo espacio de nombre 
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set { resultadoSuma = value; }
        }
        public double ResultadoProm
        {
            get { return resultadoProm; }
            set { resultadoProm = value; }
        }
        public int Mayor
        {
            get { return mayor; }
            set { mayor = value; }
        }
        public int Menor
        {
            get { return menor; }
            set { menor = value; }
        }
        //METODOS
        public void CalcularSuma()//Metodo para calcular la suma
        {
            dato = new int[10];
            ResultadoSuma += Numero;
        }
        public void CalcularPromedio()//Metodo para obtener el promedio 
        {
            dato = new int[10];
            ResultadoProm = ResultadoSuma / 10;

        }
        public void CalcularMayor()//Metodo para determinar el número mayor a partir de la posción en la que se encuentra el arreglo
        {
            dato = new int[10];
            //int v;
            /*  for(int i=0; i < 10; i++)
              {
                  dato[i] = Numero;

              }
              Mayor = dato[0]; Menor = dato[0];*/

            for (int i = 0; i < 10; i++)
            {
                dato[i] = Numero;
                if (dato[i] > Mayor)
                {
                    Mayor = dato[i];
                }
                /* if (dato [i]<Menor)
                 {
                     Menor = dato[i];
                 }*/

            }
        }
        public void CalcularMenor()//Metodo para determinar el número menor a partir de la posción en la que se encuentra el arreglo
        {
            dato = new int[10];

            for (int i = 0; i < 10; i++)
            {
                dato[i] = Numero;
                if (dato[i] < Menor)
                {
                    Menor = dato[i];
                }
                /* if (dato [i]<Menor)
                 {
                     Menor = dato[i];
                 }*/

            }
        }
    }
    //Clase program 
    class Program
    {
        //Numeros areegloNum = new Numeros();
        static void Main(string[] args)
        {
            //Creación del objeto
            Numeros areegloNum = new Numeros();
            //Captura de datos
            Console.WriteLine("Aplicación que recibe 10 números enteros y genere: ");
            Console.WriteLine("        1.- La sumatoria de todos los números");
            Console.WriteLine("        2.- El promedio");
            Console.WriteLine("        3.- El número mayor");
            Console.WriteLine("        4.- El número menor");
            Console.WriteLine("__________________");
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    //Ciclo para capturar los datos del ususario 
                    Console.Write("Introduce el número " + (i + 1) + ": ");
                    areegloNum.Numero = int.Parse(Console.ReadLine());

                } while (areegloNum.Numero <= 0);
                //Mandar llamar a los metodos de la clase Numeros 
                areegloNum.CalcularSuma();
                areegloNum.CalcularPromedio();
                areegloNum.CalcularMayor();
                areegloNum.CalcularMenor();
            }
            //areegloNum.Imprimir();
            //Mostrar e imprimir resultados obtenidos 
            Console.WriteLine("__________________");
            Console.WriteLine("> La suma de los números es: " + areegloNum.ResultadoSuma);
            Console.WriteLine("> El promedio es: " + Convert.ToDouble(areegloNum.ResultadoProm));
            Console.WriteLine("> El número mayor es el: " + areegloNum.Mayor);
            Console.WriteLine("> El número menor es el: " + areegloNum.Menor);
            Console.ReadKey();
        }
    }
}
