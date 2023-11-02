using System;

public class romanos{
    public static void Main(string[] args){
        int numrom;
        
        void NumDec()
        {
            if (numrom >= 1000){
                numrom = numrom - 1000;
                Console.Write("M ");
            }
            else if (numrom >= 900){
                numrom = numrom - 900;
                Console.Write("C M ");
            }
            else if (numrom >= 500){
                numrom = numrom - 500;
                Console.Write("D ");
            }
            else if (numrom >= 400){
                numrom = numrom - 400;
                Console.Write("C D ");
            }
            else if (numrom >= 100){
                numrom = numrom - 100;
                Console.Write("C ");
            }
            else if (numrom >= 90){
                numrom = numrom - 90;
                Console.Write("X C ");
            }
            else if (numrom >= 50){
                numrom = numrom - 50;
                Console.Write("L ");
            }
            else if (numrom >= 40){
                numrom = numrom - 40;
                Console.Write("X L ");
            }
            else if (numrom >= 10){
                numrom = numrom - 20;
                Console.Write("X ");
            }
            else if (numrom >= 9){
                numrom = numrom - 9;
                Console.Write("I X ");
            }
            else if (numrom >= 5){
                numrom = numrom - 5;
                Console.Write("V ");
            }
            else if (numrom >= 4){
                numrom = numrom - 4;
                Console.Write("I V ");
            }
            else if (numrom >= 1){
                numrom = numrom - 1;
                Console.Write("I ");
            }
        }
        
        Console.WriteLine("Ingrese un numero decimal que desee convertir a numero romano");
        numrom = Convert.ToInt32(Console.ReadLine());
        while (numrom > 0){
            NumDec();
        }
    }
}