using Carteleras_Peliculas.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carteleras_Peliculas.Client.Repositorio
{
    public interface IRepository
    {
      public List<Peliculas> pelicula (); 
    }
}
