using System;
using System.Collections.Generic;
using System.Text;
using Taller.Models.DB;
using Taller.Models.DB.DAO;
using TallerXP;

namespace Taller.Servicios
{
    public class AutoService
    {
        public static Auto AgregarAuto(String patente, String modelo, String Marca, int anio, int dni, TallerEntity context)
        {
            if (Marca.Length > 100 || modelo.Length > 100 || patente.Length > 100)
                throw new Exception("Muchos caracteres");
            Auto buscado = AutoDAO.BuscarAutoPatente(patente.Trim().Replace(" ", ""), context);
            Auto nuevo = new Auto();
            if (buscado!= null)
                throw new Exception("Patente ya existente");
            try
            {
                nuevo.Patente = patente.Trim().Replace(" ", "");
                nuevo.Modelo = modelo;
                nuevo.anio = anio;
                nuevo.Marca = Marca;
                nuevo.ClienteDNI = dni;
                return AutoDAO.AgregarAuto(nuevo, context);
            }
            catch(Exception exc)
            {
                nuevo = null;
                throw new Exception("Error inesperado");
            }
        }
    }
}
