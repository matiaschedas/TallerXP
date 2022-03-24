using System;
using System.Collections.Generic;
using System.Text;
using Taller.Models.DB;
using Taller.Models.DB.DAO;
using TallerXP;

namespace Taller.Servicios
{
   public class ClienteService
   {
        public static Cliente AgregarCliente(int dni, String nombre, String apellido, DateTime fechaCreacion, TallerEntity context)
        {
            if (nombre.Length > 100 || apellido.Length>100)
                throw new Exception("Muchos caracteres");
            Cliente nuevo = new Cliente();
            Cliente buscado = ClienteDAO.BuscarCliente(dni, context);
            if (buscado != null)
            {
                throw new Exception("Cliente ya existente");
            }
            try
            {
                nuevo.Apellido = apellido;
                nuevo.Nombre = nombre;
                nuevo.DNI = dni;
                nuevo.FechaCreacion = fechaCreacion;
                return ClienteDAO.AgregarCliente(nuevo, context);
            }
            catch(Exception exc)
            {
                nuevo = null;
                throw new Exception("Error inesperado");
            }
        }
        
       
   }
}
