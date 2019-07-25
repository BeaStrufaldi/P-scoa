using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascoa02
{
    class Sorteio
    {
        public Pessoas Sorteado { get; set; }
        public Pessoas Comprador { get; set; }

        // Inicio do Construtor da Classe
        public Sorteio(Pessoas a, Pessoas b)
        {
            Sorteado = a;
            Comprador = b;
        }

    }
}
