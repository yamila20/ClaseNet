using System;

namespace ClaseNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el numero del ejercicio:");
            int frase = Convert.ToInt16(Console.ReadLine());
            switch (frase)
            {
                case 1:
                    //mostrar los numero impar entre el 0 al 100
                    for (int i = 0; i <= 100; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine("Numero impar" + i);
                        }
                    }
                    break;
                case 2:
                    //ingresar 2 numeros, imprima los numeros naturales
                    int cont = 0,par=0;
                    Console.WriteLine("Ingrese el numero de inicio");
                    int num1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("ingrese el numero que quiere llegar");
                    int num2 = Convert.ToInt16(Console.ReadLine());
                    if (num1 < num2)
                    {
                        for (int i = num1; i >= num1 && i <= num2; i++)
                        {
                            Console.WriteLine("numeros " + i);
                            cont++;
                            if (i % 2 == 0)
                            {
                                par++;
                            }
                        }
                        Console.WriteLine("cantidad de numeros " + cont);
                        Console.WriteLine("cantidad de numeros par " + par);
                    }
                    else{ Console.WriteLine("El primer numero debe ser menor que el segundo numero"); }
                    break;
                case 3:
                    //Ingresar una frase no mas de 20 caracteres y mostrar cuantas vocales tiene
                     string palabra;
                     int conta = 0;
                     Console.WriteLine("Ingrese palabra");
                     palabra = Console.ReadLine();
                     if (palabra.Length <= 20)
                     {
                         for(int i = 0; i < palabra.Length; i++)
                         {
                             switch (palabra[i])
                             {
                                 case 'a':
                                     conta += 1;
                                     break;
                                 case 'e':
                                     conta += 1;
                                     break;
                                 case 'i':
                                     conta += 1;
                                     break;
                                 case 'o':
                                     conta += 1;
                                     break;
                                 case 'u':
                                     conta += 1;
                                     break;
                             }
                         }
                         Console.WriteLine("la palabra ingresada tiene "+ conta +" vocales");
                     }
                     else
                     {
                         Console.WriteLine("Palabra muy larga solo hasta 20 caracteres");
                     }
                    break;
                case 4:
                    //Ingresar 3 datos y decir que clase de triangulo es
                    int lado1, lado2, lado3;
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
                    break;
                case 5:
                    //mostrar los multiplos de 3 y de 2 entre el 0 y el 100
                    int mul3 = 0;
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
                    }
                    break;
            }




        }
    }
}
