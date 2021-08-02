using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato
{
    public class Procedimientos
    {
        public void Imprimir(string[,] Tablero)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("   " + "--|---|--");
                }

                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.Write(Tablero[i, j]);
                    }
                    else if (j == 0)
                    {
                        Console.Write("   " + Tablero[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(Tablero[i, j] + " | ");
                    }

                }
            }
            Console.WriteLine();
        }

    }
}
