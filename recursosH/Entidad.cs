using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Entidad 
    {
        public byte Id_Entidad { get; set; }
        private string Cedula_Juridica { get; set; }
        private string Nombre_Entidad { get; set; }
        private string Email { get; set; }
        private int Telefono { get; set; }
        private string Direccion_Entidad { get; set; }
        private string Descripcion_Entidad { get; set; }

        public Entidad() { }

        public Entidad(byte id_Entidad, string cedula_Juridica, string nombre_Entidad, string email, int telefono, string direccion_Entidad, string descripcion_Entidad)
        {
            this.Id_Entidad = id_Entidad;
            this.Cedula_Juridica = cedula_Juridica;
            this.Nombre_Entidad = nombre_Entidad;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion_Entidad = direccion_Entidad;
            this.Descripcion_Entidad = descripcion_Entidad;
        }

    }
}
