using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Naciente 
    {
        public Byte Id_Naciente { get; set; }
        public string Nombre_Naciente { get; set; }
        public string Direccion_Naciente { get; set; }
        public float latitud { get; set; }
        public float longitud { get; set; }
        public string Descripcion_Naciente { get; set; }

        public Naciente() { }

        public Naciente(byte id_Naciente, string nombre_Naciente, string direccion_Naciente, float latitud, float longitud, string descripcion_Naciente)
        {
            this.Id_Naciente = id_Naciente;
            this.Nombre_Naciente = nombre_Naciente;
            this.Direccion_Naciente = direccion_Naciente;
            this.latitud = latitud;
            this.longitud = longitud;
            this.Descripcion_Naciente = descripcion_Naciente;
        }


    }

}
