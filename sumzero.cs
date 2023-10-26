using System;

public class sumzero{
    public static void Main(string[] args){
        int sum = 0;
        int num = 1;
        
        while (num > 0 || num < 0){
            Console.WriteLine("Ingrese un numero para sumar");
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine(sum);
    }
}