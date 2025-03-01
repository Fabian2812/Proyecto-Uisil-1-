using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Distrito 
    {
        public byte Id_Distrito { get; set; }
        private string Nombre_Distrito { get; set; }

        public Distrito() { }

        public Distrito(byte id_Distrito, string nombre_Distrito)
        {
            this.Id_Distrito = id_Distrito;
            this.Nombre_Distrito = nombre_Distrito;
        }

    }
}
