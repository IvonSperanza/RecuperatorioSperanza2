using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSperanza2
{
    internal class RepositorioSala
    {
        private List<Sala> salas = new List<Sala>();
        int CapacidadMaxima = 5;
        public void AgregarSala(Sala sala)
        {
            salas.Add(sala);
        }  

        public List<Sala> ObtenerTodasLasSalas()
        {
            return salas;
        }
    }    
}
