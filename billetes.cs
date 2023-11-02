using System;

public class billetes{
    public static void Main(string[] args){
        int cantidad;
        int Mx = 0, Dx = 0, CCx = 0, Cx = 0, Lx = 0, XXx = 0;
        
        void CantiAlt()
        {
            if (cantidad >= 1000){
                cantidad = cantidad - 1000;
                Mx = Mx + 1;
            }
            else if (cantidad >= 500){
                cantidad = cantidad - 500;
                Dx = Dx + 1;
            }
            else if (cantidad >= 200){
                cantidad = cantidad - 200;
                CCx = CCx + 1;
            }
            else if (cantidad >= 100){
                cantidad = cantidad - 100;
                Cx = Cx + 1;
            }
            else if (cantidad >= 50){
                cantidad = cantidad - 50;
                Lx = Lx + 1;
            }
            else if (cantidad >= 20){
                cantidad = cantidad - 20;
                XXx = XXx + 1;
            }
        }
        
        Console.WriteLine("Ingrese una cantidad para sacar en billetes");
        cantidad = Convert.ToInt32(Console.ReadLine());
        while (cantidad >= 20){
            CantiAlt();
        }
        Console.WriteLine("La cantidad se imprimira en:\n\r" + Mx + " billetes de $1000\n\r" + Dx + " billetes de $500\n\r" + CCx + " billetes de $200\n\r" + Cx + " billetes de $100\n\r" + Lx + " billetes de $50\n\r" + XXx + " billetes de $20\n\rTiene $" + cantidad + " de cambio");
    }
}