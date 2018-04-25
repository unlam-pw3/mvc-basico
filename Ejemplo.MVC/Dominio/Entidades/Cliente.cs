using System;

namespace Ejemplo.MVC.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //otra opcion seria que Cliente tenga una propiedad del tipo Localidad en lugar de un string
        //pero esta como string para simplicidad de practica en clase
        //public Localidad Localidad { get; set; }
        public string NombreLocalidad { get; set; }
    }
}