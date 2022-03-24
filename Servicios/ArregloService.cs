using System;
using System.Collections.Generic;
using System.Text;
using Taller.Models.DB;
using Taller.Models.DB.DAO;
using TallerXP;

namespace Taller.Servicios
{
    public class ArregloService
    {
        public static void NuevoArreglo (int dni, List<LineaArreglo> arreglos, TallerEntity context)
        {
            Arreglo nuevoArreglo = new Arreglo();
            List<LineaArreglo> lineas = new List<LineaArreglo>();
            Double? total = 0; 
            foreach(LineaArreglo itemArreglo in arreglos)
            {
               total+= itemArreglo.Subtotal;
            }
            nuevoArreglo.ClienteDNI = dni;
            nuevoArreglo.Fecha = DateTime.Today;
            nuevoArreglo.Total = total;

            ArregloDAO.AgregarArreglo(nuevoArreglo, context);

            foreach(LineaArreglo itemArreglo in arreglos)
            {
                itemArreglo.idArreglo = nuevoArreglo.id;
                LineaArregloDAO.AgregarLineaArreglo(itemArreglo, context);
            }
        } 


    }
}
