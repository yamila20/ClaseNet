using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseNet
{
    public class Ejercicios
    {
        public string tarea1()
        {
            //mostrar los numero impar entre el 0 al 100
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    return "Numero Impar " + i;
                }
            }
        }
    }
}
