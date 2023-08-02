using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSperanza2
{
    internal class Entrada
    {

        public Pelicula Pelicula { get; set; }
        public TipoSala TipoSala { get; set; }
        public bool EsJubilado { get; set; }

        public Entrada(Pelicula pelicula, TipoSala tipoSala, bool esJubilado)
        {
            Pelicula = pelicula;
            TipoSala = tipoSala;
            EsJubilado = esJubilado;
        }
        public decimal CalcularPrecioEntrada()
        {
            decimal precioBase = 10;
            if (EsJubilado)
            {
                precioBase *= 0.6m; // -60% del precio para jubilados
            }
            return precioBase;

        }

    }
}