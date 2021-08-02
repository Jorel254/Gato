using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato
{
    public class Jugador
    {

        public NumJugador Status;
        public int Tiros { get; set; }
        public Jugador(int Tiros, NumJugador numJugador)
        {
            this.Tiros = Tiros;
            this.Status = numJugador;
        }
    }
}
