using System;
using PracticaI;
using System.Collections.Generic;

namespace PracticaI
{
    public class PracticaII
    {
        public static void MenuPracticaII()
        {
            Console.Clear();

            Console.WriteLine("*** Practica II: Programacion Orientada a Objeto ***");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1: Recibe Numero de Mes y Muestra en pantalla nombre del mes.");
            Console.WriteLine("2: Reciba 3 numeros por teclado y los imprima de menor a mayor.");
            Console.WriteLine("3: Reciba 3 numeros por teclado y confirma si el tercero resulta de multiplicar los 2 primeros.");
            Console.WriteLine("4: Recibe Salario Empleado y realiza calculos: Impuestos, AFP, Seguro, Neto.");
            Console.WriteLine("5: Reciba usuario y contraseña, si ingresa datos mal 3 veces, contactar Administrador.");
            Console.WriteLine("6: Que reciba un numero y genere todas las tablas desde el 1 hasta ese numero.");
            Console.WriteLine("7: Programa que funciona como cajero.");
            Console.WriteLine("");
            Console.WriteLine("0: Ir al Menu Principal.");
            Console.WriteLine("00: Cerrar el programa.");
            Console.WriteLine("");

            Console.Write("Seleccione una de las opciones que desea ejecutar: ");
            string selector = Console.ReadLine();

            if (string.IsNullOrEmpty(selector))
            {
                MenuPracticaII();
            }
            else
            {
                SeleccionPracticaII(selector);
                Console.ReadKey();
            }
        }

        public static void SeleccionPracticaII(string valor)
        {
            switch (valor)
            {
                case "1":
                {
                    MuestraNombreMes();
                }
                    break;
                case "2":
                {
                    OrganizaMenorMayor();
                }
                    break;
                case "3":
                {
                    ResultaDeMultiplicar();
                }
                    break;
                case "4":
                {
                    CalculaSalario();
                }
                    break;
                case "5":
                {
                    UsuarioContrasenaMal();
                }
                    break;
                case "6":
                {
                    Creatabla();
                }
                    break;
                case "7":
                {
                    ProgramaCajero();
                }
                    break;
                case "0":
                    {
                        Console.Clear();
                        PracticaI.MenuGeneral();
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
                        MenuPracticaII();
                    }
                    break;
            }

            Console.ReadKey();
        }

        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//


        private static void MuestraNombreMes()
        {
            Console.Clear();

            Console.WriteLine("###Recibe un numero de mes y muestra en pantalla el nombre del mes###");
            Console.WriteLine();

            Console.Write("Inserte numero del mes: ");
            string diaMes = Console.ReadLine();

            switch (diaMes)
            {
                case "1":
                {
                    Console.WriteLine("El numero 1 es el equivalente al mes de Enero.");
                }
                    break;
                case "2":
                {
                    Console.WriteLine("El numero 2 es el equivalente al mes de Febrero.");
                }
                    break;
                case "3":
                {
                    Console.WriteLine("El numero 3 es el equivalente al mes de Marzo.");
                }
                    break;
                case "4":
                {
                    Console.WriteLine("El numero 4 es el equivalente al mes de Abril.");
                }
                    break;
                case "5":
                {
                    Console.WriteLine("El numero 5 es el equivalente al mes de Mayo.");
                }
                    break;
                case "6":
                {
                    Console.WriteLine("El numero 6 es el equivalente al mes de Junio.");
                }
                    break;
                case "7":
                {
                    Console.WriteLine("El numero 7 es el equivalente al mes de Julio.");
                }
                    break;
                case "8":
                {
                    Console.WriteLine("El numero 8 es el equivalente al mes de Agosto.");
                }
                    break;
                case "9":
                {
                    Console.WriteLine("El numero 9 es el equivalente al mes de Septiembre.");
                }
                    break;
                case "10":
                {
                    Console.WriteLine("El numero 10 es el equivalente al mes de Octubre.");
                }
                    break;
                case "11":
                {
                    Console.WriteLine("El numero 11 es el equivalente al mes de Noviembre.");
                }
                    break;
                case "12":
                {
                    Console.WriteLine("El numero 12 es el equivalente al mes de Diciembre.");
                }
                    break;
                default:
                {
                    Console.WriteLine("El valor ingresado no pertenece a un mes valido.");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPracticaII();
                }
                    break;
            }

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                MuestraNombreMes();
            }
            else
            {
                MenuPracticaII();
            }
        }


        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//


        private static void OrganizaMenorMayor()
        {
            List<int> orderList = new List<int>();

            Console.Clear();

            Console.WriteLine("2: Reciba 3 numeros por teclado y los imprima de menor a mayor.");
            Console.WriteLine();

            Console.Write("Inserte numero 1: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Inserte numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Inserte numero 3: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1< numero2)
            {
                if (numero1<numero3)
                {
                    orderList.Add(numero1);
                    if (numero2<numero3)
                    {
                        orderList.Add(numero2);
                        orderList.Add(numero3);
                    }
                    else
                    {
                        orderList.Add(numero3);
                        orderList.Add(numero2);
                    }
                }
                else
                {
                    orderList.Add(numero3);
                }
            }
            else if (numero2 < numero3)
            {
                orderList.Add(numero2);
                if (numero1<numero3)
                {
                    orderList.Add(numero1);
                    orderList.Add(numero3);
                }
                else
                {
                    orderList.Add(numero3);
                    orderList.Add(numero1);
                }
            }
            else
            {
                orderList.Add(numero3);
                if (numero1 < numero2)
                {
                    orderList.Add(numero1);
                    orderList.Add(numero2);
                }
                else
                {
                    orderList.Add(numero2);
                    orderList.Add(numero1);
                }
            }
            
            Console.WriteLine("Los numeros insertados de menor a mayor son: ");
            Console.WriteLine();

            foreach (int i in orderList)
            {
                Console.WriteLine(i);
            }

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                OrganizaMenorMayor();
            }
            else
            {
                MenuPracticaII();
            }
        }


        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//


        private static void ResultaDeMultiplicar()
        {
            Console.Clear();

            Console.WriteLine("3: Reciba 3 numeros por teclado y confirma si el tercero resulta de multiplicar los 2 primeros.");
            Console.WriteLine();

            Console.Write("Inserte numero 1: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Inserte numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Inserte numero 3: ");
            int numero3 = int.Parse(Console.ReadLine());

            int multiplica = numero1*numero2;

            if (multiplica == numero3)
            {
                Console.WriteLine("El numero {0}, SI resulta de multiplicar los numeros {1} y {2} anteriores.",numero3, numero1, numero2);
                Console.WriteLine("El resultado de multiplicar los 3 valores es: {0}",multiplica*numero3);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero {0}, NO resulta de multiplicar los numeros {1} y {2} anteriores.", numero3, numero1, numero2);
                Console.WriteLine("El resultado de multiplicar los 3 valores es: {0}", multiplica * numero3);
                Console.ReadKey();
            }
            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                ResultaDeMultiplicar();
            }
            else
            {
                MenuPracticaII();
            }
        }


        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//


        private static void CalculaSalario()
        {
            Console.Clear();

            Console.WriteLine("4: Recibe Salario Empleado y realiza calculos: Impuestos, AFP, Seguro, Neto.");
            Console.WriteLine();

            Console.Write("Inserte Sueldo Bruto: ");
            double sueldoBruto = Convert.ToDouble(Console.ReadLine());

            double retencionDGII = CalculaRetencion(sueldoBruto);
            double cAFP = sueldoBruto * 0.0287;
            double seguroFamilar = sueldoBruto * 0.0304;
            double totalDeduccion = retencionDGII + cAFP + seguroFamilar;
            double sueldoNeto = sueldoBruto - totalDeduccion;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Salario Neto del empleado:");
            Console.WriteLine("Sueldo Bruto: {0}",sueldoBruto);
            Console.WriteLine("ISR: {0}",retencionDGII);
            Console.WriteLine("SFS: {0}",seguroFamilar);
            Console.WriteLine("AFP: {0}",cAFP);
            Console.WriteLine("Sueldo Neto: {0}",sueldoNeto);
            Console.WriteLine();

            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                CalculaSalario();
            }
            else
            {
                MenuPracticaII();
            }
        }

        public static double CalculaRetencion(double sBruto)
        {
            double retencion = 0, subRetencion = 0;
            double sueldoAnual = sBruto * 12;

            if (sueldoAnual > 867123)
            {
                subRetencion = ((sueldoAnual - 867123) * 0.25)/12;

                retencion = 6648 + subRetencion;
            }
            else if (sueldoAnual > 624329)
            {
                subRetencion = ((sueldoAnual - 624329) * 0.20) / 12;

                retencion = 2601.33 + subRetencion;
            }
            else if (sueldoAnual > 416220)
            {
                retencion = ((sueldoAnual - 416220) * 0.15) / 12;
            }
            else
            {
                retencion = 0;
            }
            return retencion;
        }

        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//


        private static void UsuarioContrasenaMal()
        {
            int contador = 0;
            bool ciclo = true;
            string usuario = "yonatan";
            string contrasena = "123456";


            Console.Clear();

            while (ciclo)
            {
                Console.WriteLine("5: Recibe usuario y contraseña, si ingresa datos mal 3 veces, contactar Administrador.");
                Console.WriteLine();

                Console.Write("Ingrese Usuario: ");
                string userEnt = Console.ReadLine();

                if (userEnt==usuario)
                {
                    Console.Write("Ingrese Contrasena: ");
                    string passEnt = Console.ReadLine();

                    if (passEnt==contrasena)
                    {
                        Console.WriteLine("Bienvenido al Sistemas {0}.",usuario);
                        ciclo = false;
                    }
                    else
                    {
                        contador = contador + 1;
                        if (contador == 3)
                        {
                            ciclo = false;
                            Console.WriteLine("Por favor contactar al Administrador.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Intente nuevamente.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    contador = contador + 1;
                    if (contador == 3)
                    {
                        ciclo = false;
                        Console.WriteLine("Por favor contactar al Administrador.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }


            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                UsuarioContrasenaMal();
            }
            else
            {
                MenuPracticaII();
            }
        }


        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//

        public static void Creatabla()
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
                Creatabla();
            }
            else
            {
                for (int i = 1; i <= valor; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int j = 1; j < 12; j++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                    }
                }

                //------------------------//

                Console.WriteLine();
                Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Creatabla();
                }
                else
                {
                    MenuPracticaII();
                }

            }

        }

        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------//

        public static void ProgramaCajero()
        {
            Console.Clear();

            int miles = 0;
            int quinientos = 0;
            int cientos = 0;
            int sobrante = 0;
            int cantidad = 0;
            int residuo = 0;

            //Diccionario de Billetes (nombre(key), valor)
            var billetes = new Dictionary<int, int>
            {
                { 1000,100},
                { 500, 200},
                { 100, 500}
            };

            Console.WriteLine("11: Recibe numero y muestra la tabla de Multiplicar de este.");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese Monto a Retirar: ");
            int montoRetiro = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Evaluando los montos de 1000
            if (montoRetiro > 1000)
            {
                cantidad = int.Parse((montoRetiro / 1000).ToString().Split('.')[0]); //tomo la parte entera
                miles = cantidad;
                sobrante = montoRetiro - (1000 * cantidad);

                if (sobrante > 500)
                {
                    cantidad = int.Parse((sobrante / 500).ToString().Split('.')[0]); //tomo la parte entera
                    quinientos = cantidad;
                    sobrante = sobrante - (500 * cantidad);

                    if (sobrante > 100)
                    {
                        cantidad = int.Parse((sobrante / 100).ToString().Split('.')[0]); //tomo la parte entera
                        residuo = int.Parse((sobrante / 100).ToString().Split('.')[1]); //tomo la parte entera.
                        cientos = cantidad;
                        sobrante = sobrante - (100 * cantidad);

                        if (residuo > 0)
                        {
                            Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                            Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                            Console.ReadKey();
                            ProgramaCajero();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                        Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                        Console.ReadKey();
                        ProgramaCajero();
                    }
                }
                else
                {
                    if (sobrante > 100)
                    {
                        cantidad = int.Parse((sobrante / 100).ToString().Split('.')[0]); //tomo la parte entera
                        residuo = int.Parse((sobrante / 100).ToString().Split('.')[1]); //tomo la parte entera.
                        cientos = cantidad;
                        sobrante = sobrante - (100 * cantidad);

                        if (residuo > 0)
                        {
                            Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                            Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                            Console.ReadKey();
                            ProgramaCajero();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                        Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                        Console.ReadKey();
                        ProgramaCajero();
                    }
                }
            }
            else
            {
                if (sobrante > 500)
                {
                    cantidad = int.Parse((sobrante / 500).ToString().Split('.')[0]); //tomo la parte entera
                    quinientos = cantidad;
                    sobrante = sobrante - (500 * cantidad);

                    if (sobrante > 100)
                    {
                        cantidad = int.Parse((sobrante / 100).ToString().Split('.')[0]); //tomo la parte entera
                        residuo = int.Parse((sobrante / 100).ToString().Split('.')[1]); //tomo la parte entera.
                        cientos = cantidad;
                        sobrante = sobrante - (100 * cantidad);

                        if (residuo > 0)
                        {
                            Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                            Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                            Console.ReadKey();
                            ProgramaCajero();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                        Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                        Console.ReadKey();
                        ProgramaCajero();
                    }
                }
                else
                {
                    if (sobrante > 100)
                    {
                        cantidad = int.Parse((sobrante / 100).ToString().Split('.')[0]); //tomo la parte entera.
                        residuo = int.Parse((sobrante / 100).ToString().Split('.')[1]); //tomo la parte entera.
                        cientos = cantidad;
                        sobrante = sobrante - (100 * cantidad);

                        if (residuo>0)
                        {
                            Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                            Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                            Console.ReadKey();
                            ProgramaCajero();
                        }

                    }
                    else
                    {
                        Console.WriteLine("La cantidad solicitada no puede ser entregada, los montos deben ser multiplos de: 1000, 500 y 100.");
                        Console.WriteLine("Por favor intentelo nuevamente más tarde.");
                        Console.ReadKey();
                        ProgramaCajero();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0} Billetes de 1000.", miles);
            Console.WriteLine("{0} Billetes de 500.", quinientos);
            Console.WriteLine("{0} Billetes de 100.", cientos);



            //------------------------//

            Console.WriteLine();
            Console.Write("Desea hacer un nuevo calculo? 1: Si, 2: No: ");

            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                ProgramaCajero();
            }
            else
            {
                MenuPracticaII();
            }

        }

        }
    }

