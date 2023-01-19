using System;
using FundamentosCSCHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using FundamentosCSCHARP.Service;
using FundamentosCSCHARP.Errors;

namespace FundamentosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var searcherBeer = new SearcherBeer();
                var cantidad = searcherBeer.GetCantidad("hahaha");
                Console.WriteLine("Todo bien");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine("Si te he cachado");
            }
            catch (BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Esto siempre se ejecuta");
            }
        }
    }
}
