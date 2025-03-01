using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Rol 
    {
        public byte Id_Rol { get; set; }
        private string Nombre_Rol { get; set; }

        public Rol() { }

        public Rol(byte id_Entidad, byte id_Rol, string nombre_Rol) : base()
        {
            this.Id_Rol = id_Rol;
            this.Nombre_Rol = nombre_Rol;
        }

    }
}
