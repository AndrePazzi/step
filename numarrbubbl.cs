 using System;

public class numarrbubbl {
    public static void Main (string[] args) {
        int sumf = 0;
        int posf = 0;
        int[] numeros = new int[10];
        void numfcap()
        {
            for(int i = 0; i<10;i++)
            {
                Console.WriteLine("Ingresa un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        void numfimp()
        {
            Console.WriteLine("Los elementos del arreglo son: ");
            for(int j = 0; j<=9;j++)
            {
                
                Console.WriteLine("> " + numeros[j] + " ");
                sumf = sumf + numeros[j];
            }
        }
        
        void numfsum()
        {
            for(int j = 0; j<=9;j++)
            {
                sumf = sumf + numeros[j];
            }
            Console.WriteLine("La sumatoria de los numeros es: " + sumf);
        }
        
        void numfsor()
        {
            int bubbl = 0;
            Console.WriteLine("Los elementos del arreglo de menor a mayor son: ");
            for (int ol = 0; ol < numeros.Length; ol++){
                for (int il = 0; il < numeros.Length - 1; il++){
                    if (numeros[il] > numeros[il + 1]){
                        bubbl = numeros[il + 1];
                        numeros[il + 1] = numeros[il];
                        numeros[il] = bubbl;
                    }
                }
            }
            for (int i = 0; i < numeros.Length; i++){
                Console.WriteLine("> " + numeros[i]);
            }
        }
        void numfpos()
        {
            Console.WriteLine("Ingrese una posicion");
            posf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero " + numeros[posf] + " se encuentra en la posicion " + posf + " del arreglo");
        }
        
        numfcap();
        numfimp();
        numfsum();
        numfsor();
        numfpos();
    }
}