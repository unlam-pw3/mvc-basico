using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ejemplo.MVC.Dominio.Entidades;

namespace Ejemplo.MVC.Dominio.Repositorios
{
    public class LocalidadesRepositorio
    {
        private static List<Localidad> Localidades;


        public LocalidadesRepositorio()
        {
            if (Localidades == null)
            {
                Localidades = new List<Localidad>();
                CargarDatosIniciales();
            }
        }

        private void CargarDatosIniciales()
        {
            Localidades.Add(new Localidad
            {
                Id = 1,
                Nombre = "San Justo",
            });
            Localidades.Add(new Localidad
            {
                Id = 2,
                Nombre = "Ramos Mejía",
            });
        }


        public List<Localidad> Obtener()
        {
            return Localidades;
        }
    }
}