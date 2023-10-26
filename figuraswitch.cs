using System;

public class figuraswitch {
    public static void Main (string[] args) {
        double area_cuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
        
        double perimetro_cuadrado()
        {
            Console.WriteLine("Ingresa el valor del lado");
            double lado = Convert.ToDouble(Console.ReadLine());
            return lado * 4;
        }
        
        double area_triangulo(double bas, double altura)
        {
            return (bas*altura)/2;
        }
        
        double perimetro_triangulo()
        {
            Console.WriteLine("Ingresa el valor del lado 1");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del lado 2");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del lado 3");
            double lado3 = Convert.ToDouble(Console.ReadLine());
            return lado1 + lado2 + lado3;
        }
        
        double area_circulo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        
        double perimetro_circulo()
        {
            Console.WriteLine("Ingresa el valor del radio");
            double radio = Convert.ToDouble(Console.ReadLine());
            return 2 * Math.PI * radio;
        }
        
        double area_rectangulo(double recb, double rech)
        {
            return recb * rech;
        }
        
        double perimetro_rectangulo()
        {
            Console.WriteLine("Ingresa el valor del lado mas largo");
            double ladoa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del lado mas corto");
            double ladob = Convert.ToDouble(Console.ReadLine());
            return (ladoa * 2) + (ladob * 2);
        }
        
        double area_pentagono(double pentp, double pentap)
        {
            return (pentp * pentap)/2;
        }
        
        double perimetro_pentagono()
        {
            Console.WriteLine("Ingresa el valor del lado");
            double pentl = Convert.ToDouble(Console.ReadLine());
            return pentl * 5;
        }
        
        double area_hexagono(double hexp, double hexap)
        {
            return (hexp * hexap)/2;
        }
        
        double perimetro_hexagono()
        {
            Console.WriteLine("Ingresa el valor del lado");
            double hexl = Convert.ToDouble(Console.ReadLine());
            return hexl * 6;
        }
        Console.WriteLine("===CALCULADORA=DE=FIGURAS=== \n\r");
        string continuar = " ";
            do
            {
        Console.WriteLine("> Selecciona una opcion: ");
        Console.WriteLine("1.- Circulo \n\r2.- Triangulo \n\r3.- Cuadrado \n\r4.- Rectangulo \n\r5.- Pentagono \n\r6.- Hexagono");
        int op = Convert.ToInt32(Console.ReadLine());
        menu(op);
        
        void menu (int op)
        {
  
            string opcion = " ";
            double area, perimetro;
            switch(op)
            {
                case 1:
                    Console.WriteLine("Selecciona area o perimetro para calcular (a/p)");
                    opcion = Console.ReadLine();
                    if (opcion == "a" || opcion == "A")
                    {
                        Console.WriteLine("Ingresa el valor del radio");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        area = area_circulo(radio);
                        Console.WriteLine("El area del circulo es: " + area);
                    }
                    else if (opcion == "p" || opcion == "P")
                    {
                        perimetro = perimetro_circulo();
                        Console.WriteLine("El perimetro del circulo es: " + perimetro);
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida \n\r Favor de intentar de nuevo");
                    }
                    break;
                case 2:
                    Console.WriteLine("Selecciona area o perimetro para calcular (a/p)");
                    opcion = Console.ReadLine();
                    if (opcion == "a" || opcion == "A")
                    {
                        Console.WriteLine("Ingresa el valor de la base");
                        double bas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de la altura");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        area = area_triangulo(bas, altura);
                        Console.WriteLine("El area del triangulo es: " + area);
                    }
                    else if (opcion == "p" || opcion == "P")
                    {
                        perimetro = perimetro_triangulo();
                        Console.WriteLine("El perimetro del triangulo es: " + perimetro);
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida \n\r Favor de intentar de nuevo");
                    }
                    break;
                case 3:
                    Console.WriteLine("Selecciona area o perimetro para calcular (a/p)");
                    opcion = Console.ReadLine();
                    if (opcion == "a" || opcion == "A")
                    {
                        Console.WriteLine("Ingresa el valor del lado");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        area = area_cuadrado(lado);
                        Console.WriteLine("El area del cuadrado es: " + area);
                    }
                    else if (opcion == "p" || opcion == "P")
                    {
                        perimetro = perimetro_cuadrado();
                        Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida \n\r Favor de intentar de nuevo");
                    }
                    break;
                case 4:
                    Console.WriteLine("Selecciona area o perimetro para calcular (a/p)");
                    opcion = Console.ReadLine();
                    if (opcion == "a" || opcion == "A")
                    {
                        Console.WriteLine("Ingresa el valor de la base");
                        double recb = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de la altura");
                        double rech = Convert.ToDouble(Console.ReadLine());
                        area = area_rectangulo(recb, rech);
                        Console.WriteLine("El area del rectangulo es: " + area);
                    }
                    else if (opcion == "p" || opcion == "P")
                    {
                        perimetro = perimetro_rectangulo();
                        Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida \n\r Favor de intentar de nuevo");
                    }
                    break;
                case 5:
                    Console.WriteLine("Selecciona area o perimetro para calcular (a/p)");
                    opcion = Console.ReadLine();
                    if (opcion == "a" || opcion == "A")
                    {
                        Console.WriteLine("Ingresa el valor del lado");
                        double pentp = Convert.ToDouble(Console.ReadLine())*5;
                        Console.WriteLine("Ingresa el valor del apotema");
                        double pentap = Convert.ToDouble(Console.ReadLine());
                        area = area_pentagono(pentp, pentap);
                        Console.WriteLine("El area del pentagono es: " + area);
                    }
                    else if (opcion == "p" || opcion == "P")
                    {
                        perimetro = perimetro_pentagono();
                        Console.WriteLine("El perimetro del pentagono es: " + perimetro);
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida \n\r Favor de intentar de nuevo");
                    }
                    break;
                case 6:
                    Console.WriteLine("Selecciona area o perimetro para calcular (a/p)");
                    opcion = Console.ReadLine();
                    if (opcion == "a" || opcion == "A")
                    {
                        Console.WriteLine("Ingresa el valor del lado");
                        double hexp = Convert.ToDouble(Console.ReadLine())*6;
                        Console.WriteLine("Ingresa el valor del apotema");
                        double hexap = Convert.ToDouble(Console.ReadLine());
                        area = area_hexagono(hexp, hexap);
                        Console.WriteLine("El area del hexagono es: " + area);
                    }
                    else if (opcion == "p" || opcion == "P")
                    {
                        perimetro = perimetro_hexagono();
                        Console.WriteLine("El perimetro del hexagono es: " + perimetro);
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida \n\r Favor de intentar de nuevo");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida \n\rFavor de intentar de nuevo");
                    break;
                }
            }
            Console.WriteLine("Deseas seleccionar otra figura s/n");
            continuar = Console.ReadLine();
        }while (continuar == "S" || continuar == "s");
    }
}