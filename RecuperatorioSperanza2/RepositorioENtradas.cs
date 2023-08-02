using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSperanza2
{
    internal class RepositorioEntradas
    {
        private List<Entrada> entradasVendidas = new List<Entrada>();
        public void VenderEntrada(Entrada entrada)
        {
            entradasVendidas.Add(entrada);
        }
        
        public List<Entrada> ObtenerTodasLasEntradasVendidas()
        {
            return entradasVendidas;
        }
        public int ContarAsistentesJubilados()
        {
            return entradasVendidas.Count(e => e.EsJubilado);
        }

        public decimal CalcularRecaudadoPorSala(TipoSala tipoSala)
        {
            return entradasVendidas
                .Where(e => e.TipoSala == tipoSala)
                .Sum(e => e.CalcularPrecioEntrada());
        }

        public decimal CalcularRecaudadoTotal()
        {
            return entradasVendidas.Sum(e => e.CalcularPrecioEntrada());
        }
    }
}
