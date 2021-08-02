using System;
namespace Gato
{
    class Program
    {
        static int TirosJ1 = 0,TirosJ2 =0, TirosT = 0;
        static bool HayGanador=false,Jugador1Win= false,Jugador2Win= false;
        static Jugador jugador1 = new Jugador(TirosJ1, NumJugador.Primero);
        static Jugador jugador2 = new Jugador(TirosJ2, NumJugador.Segundo);
       static Procedimientos procedimientos;
        static string[,] Tablero = new string[3, 3]
        {
             {"1","2","3"},
             {"4","5","6"},
             {"7","8","9"}
        };
        static void Main(string[] args)
        {
            procedimientos = new Procedimientos();
            string Repetir = "";
            do
            {
                Console.Clear();
               procedimientos.Imprimir(Tablero);
                while (TirosT != 9 || HayGanador != false)
                {
                    if (TurnoJ1())
                    {
                        break;
                    }
                    if (TurnoJ2())
                    {
                        break;
                    }


                }
                if (Jugador1Win == true && Jugador2Win == false)
                {
                    Console.WriteLine("Jugador1 Gano!!!!!!! ");
                    Console.Read();
                }
                else if (Jugador2Win == true && Jugador1Win == false)
                {
                    Console.WriteLine("Jugador2 Gano!!!!!!! ");
                    Console.Read();
                }
                else if (TirosT == 9 && HayGanador == false)
                {
                    Console.WriteLine("No hay ganador");
                    Console.Read();
                }
                while (Repetir != "S" && Repetir!="N")
                {
                    Console.Clear();
                    Console.WriteLine("¿Quieres volver a jugar?");
                    Console.WriteLine("Escribe 'S' para si y 'N' para no");
                    Repetir = Console.ReadLine().ToUpper();
                }
                Limpiar();
            } while (Repetir!="N");
            
        }
        static void BuscarPos(string[,] Tablero, string valor, Jugador jugador)
        {
            bool FirstPlayer;
            switch (valor)
            {
                case "1":
                    Tablero[0, 0] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "2":
                    Tablero[0, 1] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "3":
                    Tablero[0, 2] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "4":
                    Tablero[1, 0] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "5":
                    Tablero[1, 1] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "6":
                    Tablero[1, 2] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "7":
                    Tablero[2, 0] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "8":
                    Tablero[2, 1] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "9":
                    Tablero[2, 2] = jugador.Status == NumJugador.Primero ? "X" : "O";
                    break;
                case "X":
                    Console.WriteLine("Valor ingresado invalido");
                    FirstPlayer = jugador.Status == NumJugador.Primero ? true : false;
                    Repetir(FirstPlayer, jugador);
                    break;
                case "O":
                    Console.WriteLine("Valor ingresado invalido");
                    FirstPlayer = jugador.Status == NumJugador.Primero ? true : false;
                    Repetir(FirstPlayer, jugador);
                    break;
                case "x":
                    Console.WriteLine("Valor ingresado invalido");
                    FirstPlayer = jugador.Status == NumJugador.Primero ? true : false;
                    Repetir(FirstPlayer, jugador);
                    break;
                case "o":
                    Console.WriteLine("Valor ingresado invalido");
                    FirstPlayer = jugador.Status == NumJugador.Primero ? true : false;
                    Repetir(FirstPlayer, jugador);
                    break;
                default:
                        Console.WriteLine("Valor ingresado no contenido en la tabla");
                        FirstPlayer = jugador.Status == NumJugador.Primero ? true : false;
                    Repetir(FirstPlayer, jugador);
                    break;
            }
            Console.Clear();
           procedimientos.Imprimir(Tablero);
            
        }

        static bool TurnoJ1()
        {
            string Valor;
            bool Finished=false;
            Console.WriteLine("Turno Jugador1");
            Console.WriteLine("Ingresa un numero del tablero");
            Valor = Console.ReadLine();
            BuscarPos(Tablero, Valor, jugador1);
            if (Validaciones(jugador1))
            {
                Finished = true;
            }
            return Finished;
        }
        static bool TurnoJ2()
        {
            string Valor; 
            bool Finished = false;
            Console.WriteLine("Turno Jugador2");
            Console.WriteLine("Ingresa un numero del tablero");
            Valor = Console.ReadLine();
            BuscarPos(Tablero, Valor, jugador2);
            if (Validaciones(jugador2))
            {
                Finished = true;
            }
            return Finished;
        }
        static bool Validaciones(Jugador jugador)
        {
            bool Win=false;
            string variable = jugador.Status == NumJugador.Primero ? "X" : "O";
            if (Tablero[0, 0] == variable && Tablero[1, 1] == variable && Tablero[2, 2] == variable)//DiagonalIz
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            
            }
            else if (Tablero[0, 0] == variable && Tablero[1, 0] == variable && Tablero[2, 0] == variable)//ColumIz
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            }
            else if (Tablero[0, 1] == variable && Tablero[1, 1] == variable && Tablero[2, 1] == variable)//ColumCen
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            }
            else if (Tablero[0, 2] == variable && Tablero[1, 2] == variable && Tablero[2, 2] == variable)//ColumDer
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;

            }
            else if (Tablero[2, 0] == variable && Tablero[1, 1] == variable && Tablero[0, 2] == variable)//DiagonalDer
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            }
            else if (Tablero[0, 0] == variable && Tablero[0, 1] == variable && Tablero[0, 2] == variable)//Fila1
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            }
            else if (Tablero[1, 0] == variable && Tablero[1, 1] == variable && Tablero[1, 2] == variable)//Fila2
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            }
            else if (Tablero[2, 0] == variable && Tablero[2, 1] == variable && Tablero[2, 2] == variable)//Fila2
            {
                if (variable.Equals("X"))
                    Jugador1Win = true;
                else
                    Jugador2Win = true;
                HayGanador = true;
            }
            else
            {
                if (variable.Equals("X"))
                    jugador1.Tiros += 1;
                else
                    jugador2.Tiros += 1;
                TirosT = jugador1.Tiros + jugador2.Tiros;
                if (TirosT==9)
                {
                    return true;
                }
            }
            if (HayGanador == true)
            {
                Win = true;
            }
            return Win;
        }
        static void Limpiar()
        {
            jugador1.Tiros = 0;
            jugador2.Tiros = 0;
            TirosT = 0;
            HayGanador = false;
            Jugador1Win = false;
            Jugador2Win = false;
            Tablero= new string[3, 3]
            {
                 {"1","2","3"},
                 {"4","5","6"},
                 {"7","8","9"}
            };
        }
        static void Repetir(bool FirstPlayer,Jugador jugador )
        {
            if (FirstPlayer)
            {
                if (jugador.Tiros > 1)
                {
                    jugador.Tiros--;
                }
                
                TurnoJ1();
            }
            else
            {
                if (jugador.Tiros > 1)
                {
                    jugador.Tiros--;
                }
                TurnoJ2();
            }
        }
    }
}
