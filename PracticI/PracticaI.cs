using System;
using System.Collections.Generic;


namespace PracticaI
{
    class PracticaI
    {
        public static void Main()
        {
            //PracticaII.MenuPracticaII();
            MenuGeneral();
        }


        //Muestra el Menú general de Seleccion de Practicas
        public static void MenuGeneral()
        {
            Console.Clear();

            Console.WriteLine("PROGRAMACION ORIENTADA A OBJETO");
            Console.WriteLine();

            Console.WriteLine("1: Practica 1.");
            Console.WriteLine("2: Practica 2.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Inserte numero de las practicas a visualizar: ");
            string numPracticas = Console.ReadLine();


            switch (numPracticas)
            {
                case "1":
                    {
                        MenuPracticaI();                        
                    }
                    break;

                case "2":
                    {
                        PracticaII.MenuPracticaII();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("La opcion seleccionada no es valida. Intente de nuevo.");
                        Console.ReadKey();
                        MenuGeneral();
                    }
                    break;
            }

        }


        //--------------------------------------------------------------------------------------//
        //----------------DESDE AQUÍ EN ADELANTE SE ENCUENTRAN LOS METODOS----------------------//
        //--------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------//


        //Muestra el Menú de la practica I
        public static void MenuPracticaI()
        {
            Console.Clear();

            Console.WriteLine("*** Practica I: Programacion Orientada a Objeto ***");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1: Programa Muestra resultado de multiplicar 2 numeros.");
            Console.WriteLine("2: recibe numero y dice si es par o impar.");
            Console.WriteLine("3: Solicita edad y dices si es niño, adolescente, joven o  adulto.");
            Console.WriteLine("4: Suma el valor de 3 variables.");
            Console.WriteLine("5: Genera el promedio de 3 valores.");
            Console.WriteLine("6: Multiplica dos numeros.");
            Console.WriteLine("7: Divide 2 numeros.");
            Console.WriteLine("8: Muestra el resto de una división.");
            Console.WriteLine("9: Pide un numero y dice si es par, hasta que el numero introducido sea cero.");
            Console.WriteLine("10: Pide a usuario introducir numeros hasta que el numero sea cero luego imprime la sumatoria de estos.");
            Console.WriteLine("11: Recibe numero y muestra la tabla de Multiplicar de este.");
            Console.WriteLine("");
            Console.WriteLine("0: Ir al menú principal.");
            Console.WriteLine("00: Cerrar el programa.");
            Console.WriteLine("");

            Console.Write("Seleccione una de las opciones que desea ejecutar: ");
            string seleccion = Console.ReadLine();

            if (string.IsNullOrEmpty(seleccion))
            {
                MenuPracticaI();
            }
            else
            {
                Seleccion(seleccion);
                Console.ReadKey();
            }
        }

        
        public static void Seleccion(string valor)
        {
            switch (valor)
            {
                case "1":
                    {
                        Primero();
                    }
                    break;
                case "2":
                    {
                        Segundo();
                    }
                    break;
                case "3":
                    {
                        Tercero();
                    }
                    break;
                case "4":
                    {
                        Cuarto();
                    }
                    break;
                case "5":
                    {
                        Quinto();
                    }
                    break;
                case "6":
                    {
                        Sexto();
                    }
                    break;
                case "7":
                    {
                        Septimo();
                    }
                    break;
                case "8":
                    {
                        Octavo();
                    }
                    break;
                case "9":
                    {
                        Noveno();
                    }
                    break;
                case "10":
                    {
                        Decimo();
                    }
                    break;
                case "11":
                    {
                        DecimoPrimero();
                    }
                    break;
                case "0":
                    {
                        Console.Clear();
                        MenuGeneral();
                    }
                    break;
                case "00":
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("El valor ingresado no es valido.");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPracticaI();
                    }                        
                    break;
            }
        }

        
        public static void Primero()
        {
            Console.Clear();

            Console.WriteLine("1: Programa Muestra resultado de multiplicar 2 Numeros.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int producto = valor1 * valor2;

            Console.WriteLine("El Producto de multiplicar {0} y {1} es {2}",valor1, valor2, producto);
            Console.WriteLine();

            //------------------------//

            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");
            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Primero();
            }
            else
            {
                MenuPracticaI();
            }
            

        }

        public static void Segundo()
        {
            Console.Clear();

            Console.WriteLine("2: recibe numero y dice si es par o impar.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese valor: ");
            int valor = int.Parse(Console.ReadLine());


            int esPar = valor%2;

            if (esPar == 0)
            {
                Console.WriteLine("El numero {0} es un numero Par.", valor);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero {0} es un numero Impar.", valor);
                Console.ReadKey();
            }

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Segundo();
            }
            else
            {
                MenuPracticaI();
            }

        }

        public static void Tercero()
        {
            Console.Clear();

            Console.WriteLine("3: Solicita edad y decir si es: Niño, Adolescente, Joven o Adulto.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor > 18)
            {
                Console.WriteLine("La edad ingresada es de una persona Adulta.");
            }
            else if (valor > 12)
            {
                Console.WriteLine("La edad ingresada es de un Adolescente.");
            }
            else if (valor > 7)
            {
                Console.WriteLine("La edad ingresada es de una persona Joven.");
            }
            else 
            {
                Console.WriteLine("La edad ingresada es de un Niño.");
            }

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            //------------------------//

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Tercero();
            }
            else
            {
                MenuPracticaI();
            }
        }


        public static void Cuarto()
        {
            Console.Clear();

            Console.WriteLine("4: Suma el valor de 3 variables.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese tercer valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int suma = valor1 + valor2 + valor3;

            Console.WriteLine();
            Console.WriteLine("El resultado de sumar: {0} + {1} + {2} es {3}.", valor1, valor2, valor3, suma);

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Cuarto();
            }
            else
            {
                MenuPracticaI();
            }
        }



        public static void Quinto()
        {
            Console.Clear();

            Console.WriteLine("5: Genera el promedio de 3 valores.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese tercer valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int promedio = (valor1 + valor2 + valor3);

            Console.WriteLine();
            Console.WriteLine("El promedio de: {0}, {1}, {2} es {3}.", valor1, valor2, valor3, promedio);

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Quinto();
            }
            else
            {
                MenuPracticaI();
            }
        }


        public static void Sexto()
        {
            Console.Clear();

            Console.WriteLine("6: Multiplica dos numeros.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());


            int multiplica = valor1 + valor2;

            Console.WriteLine();
            Console.WriteLine("El resultado de Multiplicar: {0} X {1} es {2}.", valor1, valor2, multiplica);

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Sexto();
            }
            else
            {
                MenuPracticaI();
            }
        }


        public static void Septimo()
        {
            Console.Clear();

            decimal dividir = 0;
            Console.WriteLine("7: Divide 2 numeros.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese primer valor: ");
            decimal valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            decimal valor2 = int.Parse(Console.ReadLine());

            if (valor2 == 0)
            {
                Console.WriteLine("No se pueden realizar divisiones por cero (0).");
                Console.ReadKey();
                Septimo();
            }
            else
            {
                dividir = valor1 / valor2;
            }
            

            Console.WriteLine();
            Console.WriteLine("El resultado de Dividir: {0} / {1} es {2}.", valor1, valor2, dividir);

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Septimo();
            }
            else
            {
                MenuPracticaI();
            }
        }


        public static void Octavo()
        {
            decimal resto = 0;

            Console.Clear();

            Console.WriteLine("8: Muestra el resto de una división.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese primer valor: ");
            decimal valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            decimal valor2 = int.Parse(Console.ReadLine());

            if (valor2 == 0)
            {
                Console.WriteLine("No se pueden realizar divisiones por cero (0).");
                Console.ReadKey();
                Septimo();
            }
            else
            {
                resto = valor1 % valor2;
            }


            Console.WriteLine();
            Console.WriteLine("El Resto de Dividir: {0} / {1} es {2}.", valor1, valor2, resto);

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Octavo();
            }
            else
            {
                MenuPracticaI();
            }
        }

        public static void Noveno()
        {
            Console.Clear();

            Console.WriteLine("9: Pide un numero y dice si es par, hasta que el numero introducido sea cero.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("El valor introducido es cero (0), el programa finalizará.");
                Console.ReadKey();
                MenuPracticaI();
            }
            else if (valor%2 == 0)
            {
                Console.WriteLine("El numero {0} es Par.", valor);
                Console.ReadKey();
                Noveno();
            }
            else
            {
                Console.WriteLine("El numero {0} es Impar.", valor);
                Console.ReadKey();
                Noveno();
            }
        }


        public static void Decimo()
        {
            bool pregunta = true;
            int valor = 0;
            int sumatoria = 0;
            List<int> lista = new List<int>();

            Console.Clear();

            Console.WriteLine("10: Pide a usuario introducir numeros hasta que el numero sea cero luego imprime la sumatoria de estos.");
            Console.WriteLine();
            
            while (pregunta)
            {

                Console.Write("Ingrese valor: ");
                valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("El valor introducido es cero (0), el programa Procederá a calcular la sumatoria de los valores introducidos.");
                    Console.ReadKey();

                    foreach (int valores in lista)
                    {
                        sumatoria = sumatoria + valores;
                    }
                    Console.WriteLine("El resultado de sumar los {0} valores es: {1}.", lista.Count, sumatoria);
                    Console.ReadKey();

                    MenuPracticaI();
                }
                else
                {
                    lista.Add(valor);                    
                }
            }
            
        }


        public static void DecimoPrimero()
        {
            Console.Clear();

            Console.WriteLine("11: Recibe numero y muestra la tabla de Multiplicar de este.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("El valor introducido es cero (0), el programa finalizará.");
                Console.ReadKey();
                DecimoPrimero();
            }
            else
            {
                for (int i = 1; i <= valor; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int j = 1; j < 12; j++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", i, j, i*j);
                    }
                }

                //------------------------//

                Console.WriteLine();
                Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    DecimoPrimero();
                }
                else
                {
                    MenuPracticaI();
                }

            }

        }
    }
}