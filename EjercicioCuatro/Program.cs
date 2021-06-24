using System;

namespace EjercicioCuatro
{
    class Automovil
    {
        //atributos
        string placas, dueño, respuesta, respuestas;
        int capadidadTaller, vacio;
        double tarifa, tarifaTotal;
        //arreglos 
        string[] PlacaAuto;
        string[] NombreDueño;
        double[] Cobro;
        //-----------------------------------------------------------------------------------------------------
        //Propiedades para retornar (GET) y para evaluar los valores que contendran los atributos
        //-----------------------------------------------------------------------------------------------------
        public double Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        public double TarifaTotal
        {
            get { return tarifaTotal; }
            set { tarifaTotal = value; }
        }
        public string Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
        public string Placas
        {
            get { return placas; }
            set { placas = value; }
        }
        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
        public string RespuestaS
        {
            get { return respuestas; }
            set { respuestas = value; }
        }
        public int CapacidadTaller
        {
            get { return capadidadTaller; }
            set { capadidadTaller = value; }
        }
        public int Vacio
        {
            get { return vacio; }
            set { vacio = value; }
        }
        //-----------------------------------------------------------------------------------------------------
        //Metodo de entrada al taller donde se capturan los datos 
        //-----------------------------------------------------------------------------------------------------
        public void Entrada()
        {

            for (int i = 0; i < 5; i++)
            {
                //------------------------------------------------------------------------
                //mensaje que se le mostrara al ususario y que introduzca las placas y nombre del dueño
                //------------------------------------------------------------------------
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Introudce las placas: ");
                Placas = Console.ReadLine().ToString();
                Console.Write("Dueño / propietario: ");
                Dueño = Console.ReadLine().ToString();
                CapacidadTaller += 1;
                Vacio += 1;
                // taller.MeterAuto();
                // taller.SacarAuto();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //Propiedades de salida del taller para mostrar si el taller se encuentra en su capacidad maxima o no 
        //-----------------------------------------------------------------------------------------------------
        public void Salida()
        {
            Console.WriteLine("Capacidad taller: " + CapacidadTaller);
            Console.WriteLine("El taller esta en su capacidad máxima. Espere por favor...");
            // Console.WriteLine(taller.Placas);
            //do
            //{
            do
            {
                Console.Write("¿Sale un auto del taller? ");
                Respuesta = Console.ReadLine().ToLower();
                if (Respuesta == "si")
                {
                    //Vacio = CapacidadTaller-1;
                    Vacio -= 1;
                    Console.Write("Tarifa a cobrar por la reparación: " + "$");
                    Tarifa = double.Parse(Console.ReadLine());
                    TarifaTotal += Tarifa;
                    Console.Write("¿Ingresa un nuevo auto al taller? ");
                    Respuesta = Console.ReadLine().ToLower();
                    if (Respuesta == "si")
                    {
                        Console.WriteLine("---------------------------------------------------------");
                        Console.Write("Introudce las placas: ");
                        Placas = Console.ReadLine().ToString();
                        Console.Write("Dueño / propietario: ");
                        Dueño = Console.ReadLine().ToString();

                        CapacidadTaller = CapacidadTaller + 1;
                        Vacio = Vacio + 1;
                        Console.WriteLine("----------" + CapacidadTaller);
                        Console.WriteLine("----------" + Vacio);
                    }
                    else
                    {

                        Console.WriteLine("Siga esperando...");
                        Console.ReadLine();
                    }


                }
                else
                {

                    Console.WriteLine("Siga esperando...");
                    Console.ReadLine();
                }

            } while (Vacio > 0);

            // Console.Write("¿Ya es el final del día? ");
            // RespuestaS = Console.ReadLine().ToLower();
            // } while (Respuesta =="no");

            //  taller.SacarAuto();
            //taller.MeterAuto();
        }
        public void MeterAuto()
        {
            Console.WriteLine("Total de autos atendidos en el dia: " + CapacidadTaller);
            PlacaAuto = new string[CapacidadTaller];
            NombreDueño = new string[CapacidadTaller];
            Cobro = new double[CapacidadTaller];
            for (int i = 0; i < CapacidadTaller; i++)
            {
                PlacaAuto[i] = Placas;
                NombreDueño[i] = Dueño;
                Cobro[i] = Tarifa;
            }
            Console.WriteLine("Ganancia al final del día: " + "$" + TarifaTotal);

        }
        public void SacarAuto()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Automovil taller = new Automovil();//Instancia del objeto
            Console.WriteLine(" ___________________________________________________________________________");
            Console.WriteLine("|                          TALLER MECANICO                                  |");
            Console.WriteLine("|  Programa que captura, almacena y muestra los autos atendidos del taller  |");
            Console.WriteLine("|___________________________________________________________________________|");
            taller.Entrada();
            taller.Salida();
            taller.MeterAuto();

        }


    }
}
