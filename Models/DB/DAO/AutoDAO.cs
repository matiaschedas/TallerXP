using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerXP;

namespace Taller.Models.DB.DAO
{
    public class AutoDAO
    {
        public static Auto AgregarAuto(Auto nuevoAuto, TallerEntity context)
        {
            context.Autos.Add(nuevoAuto);
            context.SaveChanges();
            return nuevoAuto;
        }
        public static List<Auto> BuscarTodosAutos (TallerEntity context)
        {
            return context.Autos.Where(auto => auto.Patente != null).ToList();
        }
        public static List<Auto> BuscarAutosCliente (int dni, TallerEntity context)
        {
            return context.Autos.Where(auto => auto.ClienteDNI == dni).ToList();
        }
        public static Auto BuscarAutoPatente (string patente, TallerEntity context) {
           Auto buscado = context.Autos.SingleOrDefault(auto => auto.Patente == patente);
           return buscado;
        }
        public static Auto BorrarAutoPatente(string patente, TallerEntity context)
        {
            List<Auto> autos = context.Autos.Where(auto => auto.Patente != null).ToList();

            patente = patente.Trim().Replace(" ", "");
            Auto buscado = context.Autos.SingleOrDefault(auto => auto.Patente == patente);
            if(buscado != null)
                context.Autos.Remove(buscado);
            context.SaveChanges();
            return buscado;
        }
    }
}
