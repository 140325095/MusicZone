using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone.Models
{
    public class Repositorio

    {
        private static List<Banda> ListaBanda = new List<Banda>();

        public static List<Banda> VerBandas
        {
            get {

                return (ListaBanda);
            }
        } 
        
        public static void AdicionarBanda(Banda b)
        {
            ListaBanda.Add(b);
        }
    }
}
