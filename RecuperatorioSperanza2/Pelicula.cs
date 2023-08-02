using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSperanza2
{
    internal class Pelicula
    {
        public string Nombre { get; set; }
        public TipoSala TipoSala { get; set; }

        public Pelicula(string nombre, TipoSala tipoSala)
        {
            Nombre = nombre;
            TipoSala = tipoSala;
        }
    }
}
