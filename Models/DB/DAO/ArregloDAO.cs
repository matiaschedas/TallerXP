using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerXP;

namespace Taller.Models.DB.DAO
{
    public class ArregloDAO
    {
        public static Arreglo AgregarArreglo(Arreglo nuevoArreglo, TallerEntity context)
        {
            context.Arreglos.Add(nuevoArreglo);
            context.SaveChanges();
            return nuevoArreglo;
        }
        public static List<Arreglo> BuscarArreglosCliente(int dni, TallerEntity context) {
            return context.Arreglos.Where(arreglo => arreglo.ClienteDNI == dni).ToList();
        }
        
        public static Arreglo BuscarArregloID(int id, TallerEntity context)
        {
            if (id >= 0)
                return context.Arreglos.SingleOrDefault(arreglo => arreglo.id == id);
            else
                return null;
        }
    }
}
