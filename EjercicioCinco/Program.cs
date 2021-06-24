using System;

namespace EjercicioCinco
{
    class Taller
    {
        //atributos 
        string placas, propietario, respuesta1, respuesta2;
        int capacidadTaller, salida;
        double tarifa, tarifaTotal;
        string[] PlacaAuto;
        string[] NombreDueño;
        double[] Cobro;
        //Metodo con sobrecarga de nombre
        public override string ToString()
        {
            return this.placas + " del propietario " + this.propietario;
        }
        //Clase servicios para determinar la tarifa que tendra que pagar un auto al salir del taller
        class Servicios
        {
            private Taller carroReparado;
            private double tarifa;
            public override string ToString()
            {
                //------------------------------------------------------------------------
                //mensaje que se le mostrara al ususario 
                //------------------------------------------------------------------------
                return this.carroReparado.ToString() + " pagado a $" + tarifa.ToString();
            }
        }
        //-------------------------------------------------------------------
        //metodo que captura los datos necesarios para ingresar al taller las placas y el nombre del propietario
        //-------------------------------------------------------------------
        public void CapturarDatos()
        {
            Console.Write("> Introduce el número de placa: ");
            placas = Console.ReadLine().ToString();
            Console.Write("> Introduce el nombre del propietario: ");
            propietario = Console.ReadLine().ToString();
            Console.WriteLine("---------------------------------------------------------------------");
            capacidadTaller += 1;
        }
        //-------------------------------------------------------------------
        //metodo para determinar si un auto ingresara al taller y si el taller ya se encuentra en su capacidad maxima 
        //-------------------------------------------------------------------
        public void MeterAuto()
        {
            do
            {
                Console.Write("¿Ingresa un auto al taller? ");
                respuesta1 = Console.ReadLine().ToLower();
                if (respuesta1 == "si")
                {
                    CapturarDatos();
                }
                else Console.WriteLine("Esperando un auto...");
            } while (capacidadTaller < 7);
            Console.WriteLine("El taller se encuentra en su máxima capadicad de 5 autos");
            SacarAuto();
        }
        //-------------------------------------------------------------------
        //metodo que saca un auto del taller y pregunta la tarifa que deben pagar por reparación
        //-------------------------------------------------------------------
        public void SacarAuto()
        {
            Console.WriteLine("¿Sale un auto del taller? ");
            respuesta2 = Console.ReadLine().ToLower();
            if (respuesta2 == "si")
            {
                salida = capacidadTaller - 1;
                Console.Write("Tarifa cobrada: " + "$");
                tarifa = double.Parse(Console.ReadLine());
                tarifaTotal += tarifa;
                // CapturarDatos();
            }
            else
            {
                Console.WriteLine("Siga esperando...");
            }
        }
    }
    class Datos
    {
        //-------------------------------------------------------------------
        //Arreglos para almacenar todos los datos que se registraron durante el dia 
        //-------------------------------------------------------------------
        private Taller[] dato;
        private int indice;
        private int limite;
        //--- métodos

        public Datos(int tamanio)
        {
            this.dato = new Taller[tamanio];
            this.indice = -1;
            this.limite = tamanio;
        }
        //-------------------------------------------------------------------
        //metodo para sacar un auto del taller
        //-------------------------------------------------------------------
        public int Push(Taller data)
        {
            int exito = 0;
            if (indice < this.limite - 1)
                this.dato[++indice] = data;
            else exito = 1; // stack overflow

            //int[] meter = new int[5];


            return exito;
        }
        //-------------------------------------------------------------------
        //metodo para sacar un auto del taller
        //-------------------------------------------------------------------
        public Taller Pop()
        {
            Taller data = new Taller();
            if (indice != -1)
                data = this.dato[indice--];

            return data;
        }
        public Boolean Pila_vacia()
        {
            return this.indice == -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Taller mecanico = new Taller();
            Console.WriteLine(" _________________________");
            Console.WriteLine("|                          TALLER MECANICO                                  |");
            Console.WriteLine("|  Programa que captura, almacena y muestra los autos atendidos del taller  |");
            Console.WriteLine("|_________________________|");
            mecanico.MeterAuto();
        }
    }
}
