using System;

namespace EjercicioSeis
{
    //Clase
    class Sala
    {
        //Atributos
        double seleccion;
        char tecla;
        String em1, emp2, emp3, dia1, dia2, dia3, h1, h2, h3;
        string respuesta, respuesta2;

        //Metodo
        public void SeleccionarSala()
        {

            //  do//Ciclo do-while
            //  {
            Console.Clear();//limpiar consola 
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("HORARIO OFICINA");
            Console.SetCursorPosition(13, 1);
            Console.WriteLine("Programa que agenda una cita en alguna de las 3 salas dispoibles");
            do
            {
                //-------------------------------------------------------------------------------------------------------------------------
                //Aqui se crea un menu de selección para que el usuario selecciona la sala en la que desea agendar la cita
                //se utilizan propiedades para cambiar el color cuando el usuario tecle una flecha de dirección 
                //Dentro de la cual cuando se sellecciona se despligara otro menu para crear el horario y dia en la que se le creara la cita
                //-------------------------------------------------------------------------------------------------------------------------
                Console.SetCursorPosition(1, 2);
                if (seleccion == 1)
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("sala 1");

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 2);
                if (seleccion == 2)
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("sala 2");

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(60, 2);
                if (seleccion == 3)
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("sala 3");

                Console.ForegroundColor = ConsoleColor.White;
                tecla = (char)Console.ReadKey().Key;
                switch (tecla)
                {
                    case (char)ConsoleKey.LeftArrow:
                        if (seleccion == 1) seleccion = 3; else seleccion--;
                        break;
                    case (char)ConsoleKey.RightArrow:
                        if (seleccion == 3) seleccion = 1; else seleccion++;
                        break;
                }
            } while (tecla != (char)ConsoleKey.Escape && tecla != (char)ConsoleKey.Enter);
            if (tecla == (char)ConsoleKey.Escape)
                seleccion = 0;
            Console.WriteLine("" + seleccion);


            //  } while (respuesta2 == "si");

        }
        //Metodo
        public void CrearHorario()
        {
            //---------------------------------------------------------------------------------------------------------------------------------------------
            //Aqui en dodne el usuario podra hacer su horario dependiendo de la sala que haya seleccionado
            //y al final se le preguntara si desea agendar otra cita
            //si el horario y sala que selecciono no esta disponible se le dara a conocer por medio de un mensaje
            //---------------------------------------------------------------------------------------------------------------------------------------------
            do
            {

                if (seleccion == 1)
                {
                    Console.WriteLine("ingreso a sala 1");
                    Console.WriteLine("Registre su empresa: ");
                    em1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("HORA citada: ");
                    h1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("DIA citado: ");
                    dia1 = Convert.ToString(Console.ReadLine());
                    if (dia1 == "domingo")
                    {
                        Console.WriteLine("“La sala sobrepaso el horario de servicio");
                    }
                    Console.WriteLine("aqui puede ver los horario horarios DE LAS CITAS INTRODUZCA -horario-");
                    respuesta = Convert.ToString(Console.ReadLine());
                    if (respuesta == "horario")
                    {
                        Console.WriteLine(" ------------------------------------------------------------------");
                        Console.WriteLine(" sala 1 agenda");
                        Console.WriteLine("EMPRESA :" + em1);
                        Console.WriteLine("HORA :" + h1);
                        Console.WriteLine("DIA :" + dia1);
                        Console.WriteLine(" ------------------------------------------------------------------");
                    }
                    Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                    respuesta2 = Convert.ToString(Console.ReadLine());
                }
                else if (seleccion == 2)
                {
                    Console.WriteLine("ingreso a la sala 2");
                    Console.WriteLine("registre su empresa: ");
                    emp2 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("HORA  citado: ");
                    h2 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("DIA citado: ");
                    dia2 = Convert.ToString(Console.ReadLine());
                    if (dia2 == "domingo")
                    {
                        Console.WriteLine("“La sala sobrepasa el horario de servicio");
                    }
                    Console.WriteLine("aqui puede ver los horario horario DE LAS CITAS INTRODUZCA -horario-");
                    respuesta = Convert.ToString(Console.ReadLine());
                    if (respuesta == "horario")
                    {
                        Console.WriteLine(" ------------------------------------------------------------------");
                        Console.WriteLine(" sala 2 agenda");
                        Console.WriteLine("EMPRESA :" + emp2);
                        Console.WriteLine("HORA :" + h2);
                        Console.WriteLine("DIA :" + dia2);
                        Console.WriteLine(" ------------------------------------------------------------------");
                    }
                    Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                    respuesta2 = Convert.ToString(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("ingresaste a la sala 3");
                    Console.WriteLine("registre su EMPRESA: ");
                    emp3 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("HORA citada: ");
                    h3 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("DIA citado: ");
                    dia3 = Convert.ToString(Console.ReadLine());
                    if (dia3 == "domingo")
                    {
                        Console.WriteLine("“La sala sobrepasa el  horario de servicio");
                    }
                    Console.WriteLine("aqui puede ver los horario DE LAS CITAS INTRODUZCA -horario-");
                    respuesta = Convert.ToString(Console.ReadLine());
                    if (respuesta == "horario")
                    {
                        Console.WriteLine(" ------------------------------------------------------------------");
                        Console.WriteLine(" sala 1 agenda");
                        Console.WriteLine("EMPRESA :" + emp3);
                        Console.WriteLine("HORA :" + h3);
                        Console.WriteLine("DIA :" + dia3);
                        Console.WriteLine(" ------------------------------------------------------------------");
                    }
                    Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                    respuesta2 = Convert.ToString(Console.ReadLine());
                }
            } while (respuesta2 == "si");

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Sala agenda = new Sala();
            agenda.SeleccionarSala();
            agenda.CrearHorario();
        }

    }
}
