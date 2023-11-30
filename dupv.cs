using System;

public class dupv {
    static double duplicarValor(double v){
        v = v * 2;
        return v;
    }
    
    public static void Main (string[] args) {
        double valor;
        Console.WriteLine("=========DUPLICADOR=DE=VALORES=========");
        Console.WriteLine("Ingrese un valor para duplicar:");
        valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("El doble del valor ingresado es: " + duplicarValor(valor));
    }
}