using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacFest10.Ejercicio1
{
    internal class Rectangulo
    {
        public Coordenada coordenada1 { get; set; }
        public Coordenada coordenada2 { get; set; }
        public Rectangulo(Coordenada c1, Coordenada c2) { 
            coordenada1 = c1;
            coordenada2 = c2;
        }
    }
}
