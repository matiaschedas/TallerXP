using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerXP;

namespace Taller.Models.DB.DAO
{
    public class ClienteDAO
    {
        public static Cliente AgregarCliente (Cliente nuevoCliente, TallerEntity context)
        {  
                context.Clientes.Add(nuevoCliente);
                context.SaveChanges();
                return nuevoCliente;     
        }
        public static List<Cliente> BuscarTodosClientes (TallerEntity context)
        {
#pragma warning disable CS0472 // El resultado de la expresión siempre es el mismo ya que un valor de este tipo siempre es igual a "null"
            return context.Clientes.Where(cliente => cliente.DNI != null).ToList();
#pragma warning restore CS0472 // El resultado de la expresión siempre es el mismo ya que un valor de este tipo siempre es igual a "null"
        }

        public static Cliente EditarCliente(Cliente clienteEditado, TallerEntity context)
        {
            if (clienteEditado.Apellido.Length > 100 || clienteEditado.Nombre.Length > 100)
                throw new Exception("Muchos caracteres");
            Cliente clienteBuscado = context.Clientes.SingleOrDefault(cliente => cliente.DNI == clienteEditado.DNI);
            clienteBuscado.Nombre = clienteEditado.Nombre;
            clienteBuscado.Apellido = clienteEditado.Apellido;
            context.SaveChanges();
            return clienteBuscado;
        }
        public static Cliente BuscarCliente(int dni, TallerEntity context)
        {
            Cliente buscado = context.Clientes.SingleOrDefault(cliente => cliente.DNI == dni);
            return buscado;
        }
    }
}
