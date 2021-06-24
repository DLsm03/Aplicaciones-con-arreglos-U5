using System;

namespace EjercicioDos
{
    //Clase Cadena 
    class Cadena
    {
        //Atributos de tipo cadena
        string mensaje, reemplazo;
        //Propiedades publicas que nos serviran para evaluar (SET) y retornar (GET) y poder usarlos en todo el programa con el mismo espacio de nombre 
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public string Reemplazo
        {
            get { return reemplazo; }
            set { reemplazo = value; }
        }
        //Metodo para invertir el mensaje 
        public void Invertir()
        {
            //Propiedad Replace para modificar ciertos caracteres
            Reemplazo = Mensaje;
            Reemplazo = Reemplazo.Replace("A", "4");
            Reemplazo = Reemplazo.Replace("I", "1");
            Reemplazo = Reemplazo.Replace("S", "5");
            Reemplazo = Reemplazo.Replace("B", "8");
            Reemplazo = Reemplazo.Replace("E", "3");
            Reemplazo = Reemplazo.Replace("T", "7");
        }
        //Metodo para invertir el mensaje 
        public string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
    //Clase progran
    class Program
    {
        static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();//Arreglo para almacenar los caracteres e investirlos 
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            Cadena textoCad = new Cadena();//Creación del objeto 
            //Captura de datos
            Console.WriteLine("Progrma que a partir de un mensaje genera");
            Console.WriteLine("<< La cadena escrita al reves>>");
            Console.WriteLine("<<  La cadena en mayusculas  >>");
            Console.WriteLine("<<   La cadena modificada    >>");
            Console.WriteLine("___________");
            Console.WriteLine("Introduce un mensaje: ");
            string mensaje = Console.ReadLine().ToUpper();//convertir el mensaje en mayusculas
            string reversed = Reverse(mensaje);
            String reversa = mensaje;
            //Propiedad Replace para cambiar un caracter introducido por otro
            reversa = reversa.Replace("A", "4");
            reversa = reversa.Replace("I", "1");
            reversa = reversa.Replace("S", "5");
            reversa = reversa.Replace("B", "8");
            reversa = reversa.Replace("E", "3");
            reversa = reversa.Replace("T", "7");
            //Mostrar e imprimeri datos al usuario 
            Console.WriteLine("___________");
            Console.WriteLine("Mensaje al reves: " + reversed);
            Console.WriteLine("Mensaje en mayusculas: " + mensaje);
            Console.WriteLine("Mensaje modificado: " + reversa);
            Console.ReadKey();
        }
    }
}
