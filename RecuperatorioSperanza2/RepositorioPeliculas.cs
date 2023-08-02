using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioSperanza2
{
    internal class RepositorioPeliculas
    {
        private List<Pelicula> peliculas = new List<Pelicula>();

        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
          
        }

        public List<Pelicula> ObtenerTodasLasPeliculas()
        {
            return peliculas;
        }
    }
}
