using Carteleras_Peliculas.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carteleras_Peliculas.Client.Repositorio
{
    public class Repository : IRepository
    {
        public List<Peliculas> pelicula()
        {
            return new List<Peliculas>()
            {
                new Peliculas() {titulo = "Spider-Man Far From Home", FechaLanzamiento = new DateTime(2019, 6, 26),
                    Poster = "https://images-na.ssl-images-amazon.com/images/I/81OQS7d19UL._AC_SL1500_.jpg"  },

                new Peliculas() {titulo = "batman v superman dawn of justice", FechaLanzamiento = new DateTime(2016, 5, 19),
                 Poster = "https://images-na.ssl-images-amazon.com/images/I/71NFoHsSQLL._AC_SL1500_.jpg" },

                new Peliculas() {titulo = "Captain America The Winter Soldier", FechaLanzamiento = new DateTime(2014, 5, 13),
                 Poster = "https://images-na.ssl-images-amazon.com/images/I/71FXNj0ER5L._AC_SL1500_.jpg"}
                
            };
        }
    }
}
