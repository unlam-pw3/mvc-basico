using System;
using System.Collections.Generic;
using System.Linq;
using Ejemplo.MVC.Dominio.Entidades;

namespace Ejemplo.MVC.Dominio.Repositorios
{
    public class ClientesRepositorio
    {
        private static List<Cliente> Clientes;

        public ClientesRepositorio()
        {
            if (Clientes == null)
            {
                Clientes = new List<Cliente>();
                CargarDatosIniciales();
            }
        }

        private void CargarDatosIniciales()
        {
            Clientes.Add(new Cliente
            {
                Id = 1,
                Apellido = "PEREZ",
                Nombre = "JORGE",
                FechaNacimiento = new DateTime(1984, 12, 12),
                NombreLocalidad = "SAN JUSTO"
            });
            Clientes.Add(new Cliente
            {
                Id = 2,
                Apellido = "RODRIGUEZ",
                Nombre = "LUIS",
                FechaNacimiento = new DateTime(1957, 3, 12),
                NombreLocalidad = "RAMOS MEJIA"
            });
        }

        public Cliente Obtener(int idCliente)
        {
            return Clientes.FirstOrDefault(c => c.Id == idCliente);
        }
        public List<Cliente> Obtener()
        {
            return Clientes;
        }
        public void Agregar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
        public void Modificar(Cliente cliente)
        {
            Cliente clienteActual = Obtener(cliente.Id);
            clienteActual.Apellido = cliente.Apellido;
            clienteActual.Nombre = cliente.Nombre;
            clienteActual.FechaNacimiento = cliente.FechaNacimiento;
            clienteActual.NombreLocalidad = cliente.NombreLocalidad;
        }

        public void Eliminar(int idCliente)
        {
            Clientes.RemoveAll(c => c.Id == idCliente);
        }
    }
}