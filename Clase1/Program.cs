using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //mostrar los numero impar entre el 0 al 100
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    return "Numero Impar " + i;
                }
            }
            //Console.WriteLine( Ejercicios.tarea1());
            //ingresar 2 numeros, imprima los numeros naturales
            /*int num1=2, num2=6,par =0,cont=0;
            for(int i=num1;i>=num1 && i<= num2; i++)
            {
                Console.WriteLine("numeros " + i);
                cont++;
                if (i % 2 == 0){
                    par++;
                }
            }
            Console.WriteLine("cantidad de numeros " + cont);
            Console.WriteLine("cantidad de numeros par " + par);
            */
            //Ingresar una frase no mas de 20 caracteres y mostrar cuantas vocales tiene
            /* string frase;
             int cont = 0;
             Console.WriteLine("Ingrese palabra");
             frase = Console.ReadLine();
             if (frase.Length <= 20)
             {
                 for(int i = 0; i < frase.Length; i++)
                 {
                     switch (frase[i])
                     {
                         case 'a':
                             cont += 1;
                             break;
                         case 'e':
                             cont += 1;
                             break;
                         case 'i':
                             cont += 1;
                             break;
                         case 'o':
                             cont += 1;
                             break;
                         case 'u':
                             cont += 1;
                             break;
                     }
                 }
                 Console.WriteLine("la palabra ingresada tiene "+ cont +" vocales");
             }
             else
             {
                 Console.WriteLine("Palabra muy larga solo hasta 20 caracteres");
             }
         
         */
            //Ingresar 3 datos y decir que clase de triandulo es
            /*int lado1, lado2, lado3;
            Console.WriteLine("Ingrese lado A");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese lado B");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese lado C");
            lado3 = Convert.ToInt32(Console.ReadLine());
            if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
            {
                Console.WriteLine("El triangulo es Equilatero");
            }
            else
            {
                if (lado1 == lado2 && lado2 != lado3)
                {
                    Console.WriteLine("El triangulo es Isoceles");
                }
                else
                {
                    Console.WriteLine("El Triangulo es Escaleno");
                }
            }
            */
            //mostrar los multiplos de 3 y de 2 entre el 0 y el 100
            /*int mul3 = 0;
            int mul2=0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    mul3 = i;
                    Console.WriteLine("numero multiplo de 3 es " + mul3);

                }
                
            }
            for(int j=0; j <= 100; j++)
            {
                if (j % 2 == 0)
                {
                    mul2 = j;
                    Console.WriteLine("numero multiplo de 2 es " + mul2);
                }
            }*/

        }

    }
}
