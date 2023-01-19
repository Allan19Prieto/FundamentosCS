using FundamentosCSCHARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using FundamentosCSCHARP.Errors;

namespace FundamentosCSCHARP.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
            new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
            new Cerveza(){ Alcohol=9, Cantidad=8, Nombre="Stout", Marca="Minerva"}
        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                        where d.Nombre == Nombre
                        select d).FirstOrDefault();
            if (cerveza == null)
            {
                throw new BeerNotFoundException("La Cerveza se ha terminado");
            }
            return cerveza.Cantidad;
        }
    }
}
