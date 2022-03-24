using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerXP;

namespace Taller.Models.DB.DAO
{
    public class LineaArregloDAO
    {
        public static LineaArreglo AgregarLineaArreglo(LineaArreglo linea, TallerEntity context)
        {
            if (linea.Descripcion.Length > 100)
                throw new Exception("Supera el maximo de caracteres");
            context.LineaArreglos.Add(linea);
            context.SaveChanges();
            return linea;

        }
        public static List<LineaArreglo> BuscarLineasPorId(int id, TallerEntity context)
        {
            return context.LineaArreglos.Where(linea => linea.idArreglo == id).ToList();
        }
    }
}
